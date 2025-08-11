﻿using Autodesk.Common.HttpClientLibrary.Middleware.Options;
using Microsoft.Kiota.Http.HttpClientLibrary.Extensions;

namespace Autodesk.Common.HttpClientLibrary.Middleware;

/// <summary>
/// Error handler for the HttpClient that will throw an exception if the response is not successful.
/// </summary>
public class ErrorHandler : DelegatingHandler
{
    private readonly ErrorHandlerOption _errorHandlerOptions;

    public ErrorHandler(ErrorHandlerOption? errorHandlerOptions = null)
    {
        _errorHandlerOptions = errorHandlerOptions ?? new ErrorHandlerOption() { Enabled = true };
    }
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var response = await base.SendAsync(request, cancellationToken);

        // Check if the request has a specific ErrorHandlerOptions set, otherwise use the default options
        var errorOptions = request.GetRequestOption<ErrorHandlerOption>() ?? _errorHandlerOptions;

        if (errorOptions.Enabled && response.IsSuccessStatusCode == false)
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
