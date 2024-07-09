using System.Net;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using Autodesk.ModelDerivative.Helpers.Models;
using Autodesk.ModelDerivative.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Http.HttpClientLibrary.Middleware.Options;

namespace Autodesk.ModelDerivative.Helpers;

public class ModelDerivativeClientHelper
{
    /// <summary>
    /// The Model Derivative API client
    /// </summary>
    public BaseModelDerivativeClient Api { get; init; }
    internal ModelDerivativeClientHelper(BaseModelDerivativeClient api)
    {
        Api = api;
    }
    /// <summary>
    /// Returns the model tree, regardless of whether the model is in US or EMEA region.
    /// The ForceGet flag is used to retrieve large models tree.
    /// </summary>
    /// <param name="fileVersionUrn">FileUrn like: 'urn:adsk.wipprod:fs.file:vf.Efx_JwkDQkuOHB21T2k30w?version=1' or encoded in Base64 safe-URL</param>
    /// <param name="modelGuid">Optional: ModelGuid of the view to use. If not set, the first view is used</param>
    /// <param name="timeout">Default: 5 minutes</param>
    /// <returns>The model tree</returns>
    /// <exception cref="InvalidOperationException">Unable to retrieve the tree before the <paramref name="timeout"/></exception>"
    /// <remarks>The server location is defined with the client instantiation</remarks>
    public async Task<ObjectTree?> GetObjectTreeAsync(string fileVersionUrn, string? modelGuid = null, int timeout = 3000)
    {
        var fileUrnToBase64 = ToBase64UrlSafeString(fileVersionUrn);

        modelGuid ??= await GetDefaultModelGuid(modelGuid, fileUrnToBase64);

        var getTreee = async () =>
        {
            var headersInspectorOption = new HeadersInspectionHandlerOption
            {
                InspectResponseHeaders = true
            };
            var responseHandler = new NativeResponseHandler();
            var objectTree = await Api.Designdata[fileUrnToBase64].Metadata[modelGuid].GetAsync(r =>
            {
                r.QueryParameters.Forceget = true;
                r.Options.Add(headersInspectorOption);
                r.Options.Add(new ResponseHandlerOption() { ResponseHandler = responseHandler });
            });

            return (response: responseHandler.Value as HttpResponseMessage, headers: headersInspectorOption);
        };

        var result = await getTreee();

        // For large models, the response is 202 Accepted, and the tree is not ready yet.
        // We need to wait and retry until the tree is ready.
        var duration = 0;
        var delay = 1000; //in milliseconds
        timeout *= 1000; //convert to milliseconds

        while (duration < timeout && result.response.StatusCode == System.Net.HttpStatusCode.Created)
        {
            await Task.Delay(delay);
            result = await getTreee();
            duration += delay;
        }

        // If the tree is not ready after the timeout, we throw an exception.
        if (result.response.StatusCode == System.Net.HttpStatusCode.Accepted)
        {
            throw new TimeoutException("The tree is not ready yet.");
        }

        // Once the tree is ready, we can retrieve the data.
        // Note: Was not able to unzip the response body, so we are calling the API again to get the tree.
        // Then the content is unzipped with the HttpClient handler.
        var objectTree = await Api.Designdata[fileUrnToBase64].Metadata[modelGuid].GetAsync(r =>
        {
            r.QueryParameters.Forceget = true;
        });

        return objectTree;

    }

    private async Task<string?> GetDefaultModelGuid(string? modelGuid, string fileUrnToBase64)
    {
        var views = await Api.Designdata[fileUrnToBase64].Metadata.GetAsync();

        modelGuid = views?.Data?.Metadata?.FirstOrDefault()?.Guid
                        ?? throw new InvalidOperationException("No view found.");
        return modelGuid;
    }

    /// <summary>
    /// Return a specific set of properties of a specific set of objects in the model 
    /// </summary>
    /// <param name="fileVersionUrn">FileUrn like: 'urn:adsk.wipprod:fs.file:vf.Efx_JwkDQkuOHB21T2k30w?version=1' or encoded in Base64 safe-URL</param>
    /// <param name="modelGuid">Optional: ModelGuid of the view to use. If not set, the first view is used</param>
    /// <param name="query">Filter the objects to return</param>
    /// <param name="fields">Filter the properties to return</param>
    /// <param name="timeout">Default: 5 minutes</param>
    /// <returns>Properties of objects in the model</returns>
    /// <exception cref="InvalidOperationException">Unable to retrieve the tree before the <paramref name="timeout"/></exception>"
    /// <remarks>The server location is defined with the client instantiation</remarks>
    public async Task<ParsedSpecificProperties?> GetSpecificPropertiesAsync(string fileVersionUrn, UntypedObject query, List<string>? fields = null, string? modelGuid = null, int timeout = 3000)
    {
        var fileUrnToBase64 = ToBase64UrlSafeString(fileVersionUrn);

        modelGuid ??= await GetDefaultModelGuid(modelGuid, fileUrnToBase64);

        HttpStatusCode statusCode = HttpStatusCode.Accepted;

        //Loop until the response is the service ends the processing
        var duration = 0;
        var delay = 1000; //in milliseconds
        timeout *= 1000; //convert to milliseconds
        while (duration < timeout && statusCode == HttpStatusCode.Accepted)
        {
            var responseHandler = new NativeResponseHandler();

            await Api.Designdata[fileUrnToBase64].Metadata[modelGuid].PropertiesQuery.PostAsync(
                new()
                {
                    Query = query,
                    Fields = fields
                },
                r =>
                {
                    r.Options.Add(new ResponseHandlerOption() { ResponseHandler = responseHandler });
                });

            if (responseHandler.Value is HttpResponseMessage newStatusCode)
            {
                statusCode = newStatusCode.StatusCode;
            }

            if (statusCode == HttpStatusCode.Accepted)
            {
                await Task.Delay(1000);
            }

            duration += delay;
        }

        // If the data are not ready after the timeout, we throw an exception.
        if (statusCode == HttpStatusCode.Accepted)
        {
            throw new TimeoutException("The specific properties are not ready yet.");
        }

        //Once the response is not Accepted, we can retrieve the data
        var props = await Api.Designdata[fileUrnToBase64].Metadata[modelGuid].PropertiesQuery.PostAsync(
                            new()
                            {
                                Query = query,
                                Fields = fields
                            }
                            );

        var data = ParseData(props);

        return data;

    }

    private static ParsedSpecificProperties ParseData(SpecificProperties? props)
    {
        var data = new ParsedSpecificProperties
        {
            Type = props?.Data?.Type ?? string.Empty

        };

        foreach (var item in props?.Data?.Collection ?? [])
        {
            if (item.Properties is null) continue;

            var propsAsString = KiotaJsonSerializer.SerializeAsString(item.Properties);

            var newCollection = new ParsedSpecificProperties.ObjectCollection()
            {
                ObjectId = (int)(item.Objectid ?? -1),
                Name = item.Name ?? string.Empty,
                ExternalId = item.ExternalId ?? string.Empty,
                Properties = JsonNode.Parse(propsAsString, new() { PropertyNameCaseInsensitive = false }) ?? new JsonObject()
            };

            data.Collections.Add(newCollection);
        }

        return data;
    }

    public static bool IsBase64UrlSafeString(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return false;
        }

        // Replace URL-safe characters with regular Base64 characters
        input = input.Replace('-', '+').Replace('_', '/');

        // Pad the string if necessary
        int mod4 = input.Length % 4;
        if (mod4 > 0)
        {
            input += new string('=', 4 - mod4);
        }

        // Regular expression to check if the input string is a valid Base64 string
        string pattern = @"^[a-zA-Z0-9\+/]*={0,3}$";

        return Regex.IsMatch(input, pattern);
    }

    /// <summary>
    /// Returns a Base64 URL-safe encoded string
    /// </summary>
    /// <param name="input">Input string to convert</param>
    /// <param name="forceConversion">Optional: If 'true' doesn't check if the string is a compatible Base64 string; Default: False</param>
    /// <returns></returns>
    public static string ToBase64UrlSafeString(string input, bool forceConversion = false)
    {
        if (forceConversion == false && IsBase64UrlSafeString(input))
        {
            return input;
        }

        byte[] bytesToEncode = Encoding.UTF8.GetBytes(input);

        string base64Encoded = Convert.ToBase64String(bytesToEncode);

        string base64UrlSafe = base64Encoded.Replace("+", "-").Replace("/", "_").TrimEnd('=');

        return base64UrlSafe;
    }
}