# Getting the HTTP response

In some cases, it might be useful to inspect the raw HTTP response from the server, and skip the automatic deserialization

By passing a `NativeResponseHandler` object to your request, you can access the raw HTTP response. Here is an example with the `ModelDerivativeClient` for getting a large object tree:

````csharp
  public async Task<ObjectTree?> GetObjectTree(string fileUrnToBase64, string modelGuid)
    {

        // Override the default response handler to get the response
        HttpResponseMessage getTree = async () =>
        {
            // Create a response handler to capture the raw HTTP response
            var responseHandler = new NativeResponseHandler();

            var objectTree = await api.Designdata[fileUrnToBase64].Metadata[modelGuid].GetAsync(r =>
             {
                 r.QueryParameters.Forceget = true;
                 r.Headers.Add("ForceGet", "true");
                 // Add the response handler to the request options
                 r.Options.Add(new ResponseHandlerOption() { ResponseHandler = responseHandler });
             });

            // Return the raw HTTP response
            return responseHandler.Value as HttpResponseMessage;
        };

        HttpResponseMessage response = await getTree();

        // For large models, the response is 202 Accepted, and the tree is not ready yet.
        // We need to wait and retry until the tree is ready.
        while (response.StatusCode == System.Net.HttpStatusCode.Created)
        {
            await Task.Delay(5000);
            response = await getTree();
        }

        // Now we call again the API to get the tree with the default response handler. 
        //In this way, the response is unzipped and parsed and the tree is returned.

        var objectTree = await api.Designdata[fileUrnToBase64].Metadata[modelGuid].GetAsync();

        return objectTree;

    }
```
