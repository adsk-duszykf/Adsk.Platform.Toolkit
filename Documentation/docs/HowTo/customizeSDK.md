# Customizing the HttpClient in the SDK (Advanced)

You can pass your own `HttpClient` to the `{service}client` constructor.

You can either create a new instance of `HttpClient` with your custom settings or modify the existing one.

## Adding a new middleware in the HttpClient pipeline

````csharp
public async Task<Hubs> GetHub()
{

    async Task<string> getAccessToken()
    {
        //return access token with your logic
    }

    // Create a custom HttpClient with the desired middleware (see the implementation below)
    var customHttpClient = CreateCustomHttpClient();

    // Pass the custom HttpClient to the DataManagementClient
    var DMclient = new DataManagementClient(getAccessToken, customHttpClient);

    var hubs = await DMclient.DataMgtApi.Project.V1.Hubs.GetAsync();

    return hubs;
}

public static System.Net.Http.HttpClient CreateCustomHttpClient((int maxConcurrentRequests, TimeSpan timeWindow)? rateLimit = null)
{
    // Get the default middleware (Retry, error handling, etc.)
    var handlers = CreateDefaultHandlers();
    
    // Add your custom middleware (see the implementation below)
    handlers.Add(new Logger());

    var defaultFinalHandler = GetDefaultHttpMessageHandler();

    // Chain the middlewares.
    // The first in the collection is the next to the final handler
    var httpMessageHandler =
                ChainHandlersCollectionAndGetFirstLink(defaultFinalHandler, [.. handlers])
                ?? defaultFinalHandler;

    return new HttpClient(httpMessageHandler);
}


/// <summary>
/// Minimal logging handler for the HttpClient.
/// It must inherit from DelegatingHandler.
/// </summary>
public class Logger : DelegatingHandler
{

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var response = await base.SendAsync(request, cancellationToken);

        Trace.TraceInformation($"Response status code:  {response.StatusCode}");
    }

}

````

The requests and responses can be customized by providing a custom `HttpClient` to the `client` constructor by adding a `DelegatingHandler` to the `HttpClient` pipeline.

````csharp
public async Task GetHubs()
{
    var handler = new HttpClientHandler();
    
    // Initialize the custom DelegateHandler here
    var logger = new LoggingHandler()
    {
        InnerHandler = handler // This is the default handler
    };

    // Initialize the HttpClient with the custom handler
    var httpClient = KiotaClientFactory.Create(logger);

    var auth = new Microsoft.Kiota.Abstractions.Authentication.BaseBearerTokenAuthenticationProvider(new Auth());

    // Initialize the RequestAdapter with the custom HttpClient
    var adapter = new Microsoft.Kiota.Http.HttpClientLibrary.HttpClientRequestAdapter(auth, null, null, httpClient);

    var client = new Autodesk.DataManagement.DataManagementClient(adapter);

    Hubs? hubs = null;

    try
    {
        var responseHandler = new NativeResponseHandler();
        return await client.Project.V1.Hubs.GetAsync();
    }
    catch (Exception ex)
    {
        Trace.TraceError(ex.Message);
    }

}

public class LoggingHandler() : DelegatingHandler
{
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        Trace.TraceInformation("Right before making http request");

        var response = await base.SendAsync(request, cancellationToken);

        if (response.IsSuccessStatusCode) return response;

        var errorMessage = await response.Content.ReadAsStringAsync(cancellationToken);

        if (errorMessage is not null)
        {
            errorMessage = @$"Error Status: {response.StatusCode}.
                                Url: {request.Method}: {request.RequestUri}.
                                Error Message: {errorMessage}";

            Trace.TraceError(errorMessage);

        }

        return response;
    }
}
````
