# Adsk.Platform.HttpClient

`Adsk.Platform.HttpClient` is a dependency of the APS toolkit libraries, and it's used by default to make HTTP requests to the Autodesk Platform (APS) API endpoints.

`Adsk.Platform.HttpClient` is a implementation of `System.Net.Http.HttpClient`.

Compare to the standard `System.Net.Http.HttpClient`, this implementation has the following features:

- [Retry logic](#retry-logic)
- Response decompression
- [Error handling](#error-handling)
- [Url Redirection](#url-redirection)
- [Concurrency rate limit](#concurrency-rate-limit)

## Installation

```bash
dotnet add package Adsk.Platform.DataManagement
```

This package is a dependency of the other packages`Adsk.Platform.*`.

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
The rate limit is defined by the maximum number of concurrent requests and the time window. This limit is per endpoint.

```csharp
public async Task GetUsersConcurrently()
{

    //Limit to 10 requests per second
    var requestTimeWindow = TimeSpan.FromMilliseconds(1000);
    var httpClient = Autodesk.Common.HttpClientLibrary.HttpClient.Create((10, requestTimeWindow));

    //Just run all tasks in parallel. The HttpClient will handle the concurrency rate limit
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
- Status code is not handled by the [retry logic](#retry-logic) or the [redirection logic](#url-redirection)

The exception message contains the response status code and the endpoint response content as a `string`.

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

The client uses the default retry logic provided with `Kiota`. The code below shows which status codes are considered as 'retry-able'.

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

The client uses the default redirection logic provided with `Kiota`. The code below shows which status codes are considered as redirection.

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

## Bring your own `HttpClient`

This default `httpClient` can be replaced by your own implementation.

For example, the [Polly](https://www.pollydocs.org/) library could be used to implement a retry policy.

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

// Create a custom HttpClient with a Polly retry policy
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
