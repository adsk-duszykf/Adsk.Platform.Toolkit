using System.Text;
using System.Text.RegularExpressions;
using Autodesk.ModelDerivative.Models;
using Microsoft.Kiota.Abstractions;
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
    /// <returns></returns>
    public async Task<ObjectTree?> GetObjectTree(string fileVersionUrn, string? modelGuid = null)
    {
        var fileUrnToBase64 = fileVersionUrn;
        //Check if fileVersionUrn is Base64 safe encoded
        //bool isBase64Safe = false;
        var isBase64Safe = IsBase64UrlSafeString(fileVersionUrn);

        if (isBase64Safe == false)
        {
            fileUrnToBase64 = ToBase64UrlSafeString(fileVersionUrn);
        }

        if (string.IsNullOrEmpty(modelGuid))
        {
            var views = await Api.Designdata[fileUrnToBase64].Metadata.GetAsync();
            modelGuid = views?.Data?.Metadata?.FirstOrDefault()?.Guid
                            ?? throw new InvalidOperationException("No view found.");
        }

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
        while (result.response.StatusCode == System.Net.HttpStatusCode.Created)
        {
            await Task.Delay(5000);
            result = await getTreee();
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
    public static string ToBase64UrlSafeString(string input)
    {
        byte[] bytesToEncode = Encoding.UTF8.GetBytes(input);

        string base64Encoded = Convert.ToBase64String(bytesToEncode);

        string base64UrlSafe = base64Encoded.Replace("+", "-").Replace("/", "_").TrimEnd('=');

        return base64UrlSafe;
    }
}