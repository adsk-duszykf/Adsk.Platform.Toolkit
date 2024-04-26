using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Autodesk.ACC.ModelProperties.Helpers;

/// <summary>
/// Fix: Issue with Kiota 1.7 that doesn't support untyped JSON objects
/// See [Kiota issue #2319](https://github.com/microsoft/kiota/issues/2319)
/// </summary>
public class FixSQLlikeRequestBodyHandler : DelegatingHandler
{

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        string pattern = @"^https:\/\/developer\.api\.autodesk\.com\/construction\/index\/v2\/projects\/([0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12})\/indexes\/([0-9a-zA-Z\-_]+)\/queries$";
        var isMatch = Regex.IsMatch(request.RequestUri?.OriginalString ?? string.Empty, pattern);

        if (request.Method == HttpMethod.Post && request.Content != null && isMatch)
        {
            // Read the original content
            var originalContent = await request.Content.ReadAsStringAsync(cancellationToken);

            // Parse the string as a JSON object
            JsonDocument document = JsonDocument.Parse(originalContent);

            // Get the value of the "query" property
            var encodedInnerJson = document.RootElement.GetProperty("query").GetString();

            if (encodedInnerJson is not null)
            {
                // Replace the escaped Unicode characters with their actual characters
                string decodedInnerJson = System.Text.RegularExpressions.Regex.Unescape(encodedInnerJson);

                // Create a new StringContent with the updated content
                var newContent = new StringContent(decodedInnerJson, Encoding.UTF8, "application/json");

                // Replace the request content
                request.Content = newContent;
            }
        }

        return await base.SendAsync(request, cancellationToken);

    }
}
