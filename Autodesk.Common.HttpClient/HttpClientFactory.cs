using Autodesk.Common.HttpClientLibrary.Middleware;
using Autodesk.Common.HttpClientLibrary.Middleware.Options;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using static Microsoft.Kiota.Http.HttpClientLibrary.KiotaClientFactory;

namespace Autodesk.Common.HttpClientLibrary;
public static class HttpClientFactory
{

    /// <summary>
    /// Create a resilient Http Client
    /// </summary>
    /// <param name="rateLimit">Optional: Maximum calls per endpoint in a specific timeframe. Disabled by default</param>
    /// <returns>Http client including Kitoa middleware and custom error handling></returns>
    public static System.Net.Http.HttpClient Create((int maxConcurrentRequests, TimeSpan timeWindow)? rateLimit = null)
    {
        var rateLimitHandlerOption = new RateLimitingHandlerOption();
        if (rateLimit.HasValue)
        {
            rateLimitHandlerOption.SetRateLimit(rateLimit.Value.maxConcurrentRequests, rateLimit.Value.timeWindow);
        }

        var handlers = CreateDefaultHandlers();
        handlers.Add(new RateLimitingHandler(rateLimitHandlerOption));
        handlers.Add(new ErrorHandler());

        var defaultFinalHandler = GetDefaultHttpMessageHandler();
        var httpMessageHandler =
                    ChainHandlersCollectionAndGetFirstLink(defaultFinalHandler, [.. handlers])
                    ?? defaultFinalHandler;

        return new HttpClient(httpMessageHandler);
    }


    /// <summary>
    /// Creates a new HttpClientRequestAdapter with an AccessTokenProvider. The adapter will use the default error and decompression handlers.
    /// </summary>
    /// <param name="getAccessToken"></param>
    /// <param name="httpClient"></param>
    /// <returns>Request adapter for SDK client instances</returns>
    public static HttpClientRequestAdapter CreateAdapter(Func<Task<string>> getAccessToken, HttpClient? httpClient)
    {
        var auth = new BaseBearerTokenAuthenticationProvider(new AccessTokenProvider(getAccessToken));

        httpClient ??= Create();

        return new HttpClientRequestAdapter(auth, null, null, httpClient); ;
    }

    /// <summary>
    /// Gets the default handler types.
    /// </summary>
    /// <returns>A list of all the default handlers</returns>
    /// <remarks>Order matters</remarks>
    public static IList<ActivatableType> GetDefaultHandlerActivatableTypes()
    {
        var nativeDefaultHandlers = KiotaClientFactory.GetDefaultHandlerActivatableTypes();

        return [.. nativeDefaultHandlers, new(typeof(RateLimitingHandler)), new(typeof(ErrorHandler))];
    }
}