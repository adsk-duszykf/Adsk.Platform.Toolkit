# Adsk.Platform.HttpClient

`Adsk.Platform.HttpClient` is a dependency of the APS toolkit libraries, and it's used by default to make HTTP requests to the Autodesk Platform (APS) API endpoints.

`Adsk.Platform.HttpClient` is a implementation of `System.Net.Http.HttpClient`.

Compare to the standard `System.Net.Http.HttpClient`, this implementation has the following features:

- Include automatic retry logic
- Include response payload decompression
- Error handling. Response status code 4xx and 5xx will throw an `HttpRequestException` exception

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

### Error Handling

Response status code 4xx and 5xx will throw an `HttpRequestException` exception. The exception message will contain the response status code and the endpoint response content as a `string``.

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
