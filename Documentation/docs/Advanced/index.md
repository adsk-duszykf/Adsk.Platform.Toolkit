
# Customizing the SDK (Advanced)

## HttpClient

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

## Per Request Customization

The default response handlers can be customized by providing a custom `ResponseHandlerOption` to the `request`.

This approach is useful when you don't get response immediately because the server is still processing the request, or if you want to handle errors in a specific way. In this case, you can use the `responseHandler` to get the response

### Example 1: Custom Error Handling for a specific request

````csharp
public async Task TestMethod1()
{
    var auth = new Microsoft.Kiota.Abstractions.Authentication.BaseBearerTokenAuthenticationProvider(new Auth());

    var adapter = new Microsoft.Kiota.Http.HttpClientLibrary.HttpClientRequestAdapter(auth);

    var client = new Autodesk.DataManagement.DataManagementClient(adapter);

    Hubs? hubs = null;

    // Initialize the custom ResponseHandler here
    var responseHandler = new NativeResponseHandler();

    // Add the ResponseHandler to the request options
    await client.Project.V1.Hubs.GetAsync(request =>
    {
        request.Options.Add(new ResponseHandlerOption() { ResponseHandler = responseHandler });
    });

    // Adding a ResponseHandler skips the default error handling and response parsing.
    // Check if the response is successful.
    var response = responseHandler.Value as HttpResponseMessage;
    if (response?.IsSuccessStatusCode == false)
    {
        var errorMessage = await response.Content.ReadAsStringAsync();
        Trace.(errorMessage);
    }

    // Parse the response, because default parsing is skipped.
    hub = response.Content.ReadFromJsonAsync<Hubs>().Result;
}
````

### Example 2: Wait until the response is ready

Here is an example with the `ModelDerivativeClient` for getting a large object tree:

````csharp
  public async Task<ObjectTree?> GetObjectTree(string fileUrnToBase64, string modelGuid)
    {

        var getTreee = async () =>
        {
            var responseHandler = new NativeResponseHandler();
            var objectTree = await api.Designdata[fileUrnToBase64].Metadata[modelGuid].GetAsync(r =>
             {
                 r.QueryParameters.Forceget = true;
                 r.Headers.Add("ForceGet", "true");
                 r.Options.Add(new ResponseHandlerOption() { ResponseHandler = responseHandler });
             });

            return responseHandler.Value as HttpResponseMessage;
        };

        var response = await getTreee();

        // For large models, the response is 202 Accepted, and the tree is not ready yet.
        // We need to wait and retry until the tree is ready.
        while (response.StatusCode == System.Net.HttpStatusCode.Created)
        {
            await Task.Delay(5000);
            response = await getTreee();
        }

        // Now we call again the API to get the tree with the default response handler. 
        //In this way, the response is unzipped and parsed and the tree is returned.

        var objectTree = await api.Designdata[fileUrnToBase64].Metadata[modelGuid].GetAsync();

        return objectTree;

    }
````
