# Adsk.Platform.HttpClient

`Adsk.Platform.HttpClient` is a dependency of the APS toolkit libraries, and it's used by default to make HTTP requests to the Autodesk Platform (APS) API endpoints.

`Adsk.Platform.HttpClient` is a implementation of `System.Net.Http.HttpClient`.

Compare to the standard `System.Net.Http.HttpClient`, this implementation has the following features:

- Retry logic
- Response decompression
- Error handling.
- Url Redirection
- Concurrency

## Installation

Not necessary to install separately. It's included in the APS toolkit libraries.

## Usage

In the following example, we create a new instance of `DataManagementClient` is based on the `HttpClient` implementation.

```csharp
using Autodesk.DataManagement;

public async Task<Hubs> GetHub()
{

    async Task<string> getAccessToken()
    {
        //return access token with your logic
    }

    var DMclient = new DataManagementClient(getAccessToken);

    var hubs = await DMclient.DataMgtApi.Project.V1.Hubs.GetAsync();

    return hubs;
}
```

### Concurrency rate limit

The concurrency rate limit can be enabled with the `HttpClient` constructor.

```csharp
public async Task GetUsersConcurrently()
{
    var requestTimeWindow = TimeSpan.FromMilliseconds(1000);

    //Pass the max number of concurrent requests and the time window to the HttpClient
    var httpClient = Autodesk.Common.HttpClientLibrary.HttpClient.Create((10, requestTimeWindow));

    var tasks = new List<Task>();
    for (int i = 0; i < 20; i++)
    {
        var resp = httpClient.GetAsync("https://randomuser.me/api/");
        tasks.Add(resp);

    }

    await Task.WhenAll(tasks);

    }
```

By default, the concurrency rate limit is disabled.

> Note: The concurrency rate limit is per endpoint, not global.

### Error handling

The error handler throw an `HttpRequestException` exception if:

- Status code is not in the range 200-299
- Status code is handled by the [retry logic](#retry-logic) or the [redirection logic](#url-redirection)

The exception message will contain the response status code and the endpoint response content as a `string``.

```csharp
using Autodesk.DataManagement;

public async Task<Hubs> GetHub()
{

    async Task<string> getAccessToken()
    {
        //return access token with your logic
    }

    var DMclient = new DataManagementClient(getAccessToken);

    try {

        var hubs = await DMclient.DataMgtApi.Project.V1.Hubs.GetAsync();
        return hubs;

    } catch (HttpRequestException ex) {

        Console.WriteLine(ex.StatusCode);
        Console.WriteLine(ex.Message); //Response content returned by the API endpoint

    }
}
```

### Retry logic

The client use the default retry logic provided with `Kiota`.

```csharp
private static bool ShouldRetry(HttpStatusCode? statusCode)
{
    return statusCode switch
    {
        HttpStatusCode.ServiceUnavailable => true,
        HttpStatusCode.GatewayTimeout => true,
        (HttpStatusCode)429 => true,
        _ => false
    };
}
```

### Url Redirection

The client use the default redirection logic provided with `Kiota`.

```csharp
private static bool IsRedirect(HttpStatusCode statusCode)
{
    return statusCode switch
    {
        HttpStatusCode.MovedPermanently => true,
        HttpStatusCode.Found => true,
        HttpStatusCode.SeeOther => true,
        HttpStatusCode.TemporaryRedirect => true,
        (HttpStatusCode)308 => true,
        _ => false
    };
}
```



### Custom HttpClient

This default `httpClient` can be replaced by a custom implementation. For example, you can use the `Polly` library to implement a retry policy.

```csharp
using System;
using System.Net.Http;
using Microsoft.Extensions.Http;
using Microsoft.Extensions.Http.Resilience;
using Polly;
using Autodesk.DataManagement;

public async Task<Hubs> GetHub()
{

    async Task<string> getAccessToken()
    {
        //return access token with your logic
    }

    // Create a custom HttpClient
    var customHttpClient = CreateHttpClient();

    //Pass it to the DataManagementClient
    var DMclient = new DataManagementClient(getAccessToken, customHttpClient);

    var hubs = await DMclient.DataMgtApi.Project.V1.Hubs.GetAsync();

    return hubs;
}

private HttpClient CreateHttpClient() {

    var retryPipeline = new ResiliencePipelineBuilder<HttpResponseMessage>()
        .AddRetry(new HttpRetryStrategyOptions
        {
            BackoffType = DelayBackoffType.Exponential,
            MaxRetryAttempts = 3
        })
        .Build();
    
    var socketHandler = new SocketsHttpHandler
    {
        PooledConnectionLifetime = TimeSpan.FromMinutes(15)
    };

    var resilienceHandler = new ResilienceHandler(retryPipeline)
    {
        InnerHandler = socketHandler,
    };
    
    return new HttpClient(resilienceHandler);
}
```
