using Autodesk.Common.HttpClientLibrary.Middleware.Options;
using Microsoft.Kiota.Http.HttpClientLibrary.Extensions;

namespace Autodesk.Common.HttpClientLibrary.Middleware;

/// <summary>
/// Error handler for the HttpClient that will throw an exception if the response is not successful.
/// </summary>
public class ErrorHandler : DelegatingHandler
{
    private readonly ErrorHandlerOptions _options;

    public ErrorHandler(ErrorHandlerOptions? options = null)
    {
        _options = options ?? new ErrorHandlerOptions() { ThrowErrorOnFailure = true };
    }
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var response = await base.SendAsync(request, cancellationToken);

        // Check if the request has a specific ErrorHandlerOptions set, otherwise use the default options
        var errorOptions = request.GetRequestOption<ErrorHandlerOptions>() ?? _options;

        if (errorOptions.ThrowErrorOnFailure && response.IsSuccessStatusCode == false)
        {

            var err = new HttpRequestException($"Request to '{request.RequestUri}' failed with status code '{response.StatusCode}'.", null, response.StatusCode)
            {
                Data =
                {
                    ["context"] = response
                }

            };

            throw err;
        }

        return response;

    }

}
