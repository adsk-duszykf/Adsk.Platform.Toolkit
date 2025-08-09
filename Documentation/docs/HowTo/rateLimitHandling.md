# Handling error 429 (Too Many Requests)

When you exceed the API rate limits, you may receive a `429 Too Many Requests` error.

There are 2 solutions to handle this error:

## Solution 1: Reactive approach

In this approach, you let the underlying `HttpClient` handle the `429 Too Many Requests` error automatically.

The underlying `HttpClient` will automatically handle this error by retrying the request after a delay returned by the endpoint in the `Retry-After` header. If this header is not present, the client will use a default backoff strategy.

## Solution 2: Proactive approach

In addition to the reactive approach, you can configure your client with a maximum concurrent request limit. This can help you avoid hitting the rate limit in the first place.

Here's an example of how to implement a proactive approach:

```csharp
using Autodesk.Common.HttpClientLibrary;

// Create an HttpClient with rate limiting middleware enabled
// Limit to 40 requests per minute per endpoint
var requestTimeWindow = TimeSpan.FromMinutes(1);
var httpClient = HttpClientFactory.Create((40, requestTimeWindow));

async Task<string> getAccessToken()
{
    //return access token with your logic
}

// Here we passed this customized HttpClient to the DataManagementClient, 
// It will override the default HttpClient used by the client
var DMclient = new DataManagementClient(getAccessToken, httpClient);

// Example: Making multiple concurrent requests
// The Get Hub endpoint has a rate limit of 50 requests per minute
// Sending 100 requests in parallel should lead to hitting the rate limit
// But here we enabled the proactive rate limiting setting a maximum of 40 requests per minute
// That means we should not hit the rate limit
var tasks = new List<Task<HttpResponseMessage>>();
for (int i = 0; i < 100; i++)
{
    var task = DMclient.DataMgtApi.Project.V1.Hubs.GetAsync();;
    tasks.Add(task);
}

// The HttpClient will automatically throttle requests
await Task.WhenAll(tasks);
```
