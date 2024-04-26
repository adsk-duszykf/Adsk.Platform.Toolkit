using System.Net;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Autodesk.Common.HttpClientLibrary;
public class HttpClient
{
    /// <summary>
    /// Creates a new HttpClient with an error handler and a decompression handler.
    /// </summary>
    /// <param name="finalHandler">Optional: If set will replace the default error and decompression handlers</param>
    /// <returns>A new instance of <see cref="Microsoft.Kiota.Http.HttpClientLibrary.KiotaClientFactory"/></returns>
    public static System.Net.Http.HttpClient Create(HttpMessageHandler? finalHandler = null)
    {
        var handler = finalHandler ?? DefaultHandler;
        return KiotaClientFactory.Create(handler);
    }

    /// <summary>
    /// Creates a new HttpClientRequestAdapter with an AccessTokenProvider. The adapter will use the default error and decompression handlers.
    /// </summary>
    /// <param name="getAccessToken"></param>
    /// <param name="httpClient"></param>
    /// <returns>Request adapter for SDK client instances</returns>
    public static HttpClientRequestAdapter CreateAdapter(Func<Task<string>> getAccessToken, System.Net.Http.HttpClient? httpClient)
    {
        var auth = new BaseBearerTokenAuthenticationProvider(new AccessTokenProvider(getAccessToken));

        httpClient ??= Create();

        return new HttpClientRequestAdapter(auth, null, null, httpClient); ;
    }

    private static HttpMessageHandler DefaultHandler
    {
        get
        {

            var error = new ErrorHandler
            {
                InnerHandler = new HttpClientHandler()
                {
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,

                }
            };

            return error;

        }
    }
}

