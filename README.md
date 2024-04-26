# Autodesk Platform Services Toolkit

This toolkit provides a collection of .NET libraries, featuring a [Fluent API](https://dzone.com/articles/java-fluent-api) derived from the [API specifications](https://swagger.io/specification/) and a set of convenient functions designed to enhance the developer experience when using Autodesk Platform Services (APS) in C#.

## Helper functions

Example:
**Get the file id by the file path**

```csharp
using Autodesk.DataManagement;

// Initialize the DataManagementClient
var authToken() => Task.FromResult("YOUR_ACCESS_TOKEN");

var DMclient = new DataManagementClient(authToken);

// A single method getting the file id by path
var file = await DMclient.Helper.GetFileItemByPathAsync("Account/Project/Folder/SubFolder/FileName.ext");

Console.WriteLine($"File ID: {file.Id}");    
```

## Fluent API

Example: **Get the hub ids**

```csharp
using Autodesk.DataManagement;

// Initialize the DataManagementClient
var authToken() => Task.FromResult("YOUR_ACCESS_TOKEN");

var DMclient = new DataManagementClient(authToken);

// Fluent API reproducing the API endpoint to get the hub ids
var hubs = await DMclient.DataMgtApi.Project.V1.Hubs.GetAsync();

var hubIds = hubs?.Data?.Select(h => h?.Id ?? "")?.ToArray() ?? [];

Console.WriteLine($"Hubs: {string.Join(';', hubIds)}");  
```

The repository contains a C# SDK for several APS services, including:

| Service | SDK | Helper functions |
|:--|:--|:--|
| Authentication | Stable | Yes |
| Data Management | Stable | Yes |
| Model Derivative | Stable | Yes |
| ACC/BIM360 Account Admin | In development | No |
| ACC Assets | In development | No |
| ACC Cost Management | In development | No |

## Get started

The root object for each service is `{service}Client`. For example, the root object for the Data Management service is `DataManagementClient`.
This object contains 2 properties:

- `Api`: Contains the root object for the Fluent API.
- `Helper`: Contains methods that cover common scenarios combining multiple API calls.

The Fluent API reflects the Rest API endpoint structure:

````csharp
//https://developer.api.autodesk.com/project/v1/hubs (GET)
                   client.DataMgtApi.Project.V1.Hubs.GetAsync()
````

For more details about the SDK structure, see the [Kiota documentation](https://learn.microsoft.com/en-us/openapi/kiota/request-builders)

For code examples look at the files `{service}ClientHelper.cs`.

## Motivations

### Why this toolkit?

- Needs full typed SDKs with a more complete and comprehensive API from the API specifications compared to existing solution. Thanks to [Kiota](https://learn.microsoft.com/en-us/openapi/kiota/overview) by Microsoft
- Needs higher level functions to cover common scenarios combining multiple API calls:
  - Authentication: Create and refresh automatically a 2 legged token
  - DataManagement: Download/Upload a file
  - Model Derivative: Get large model tree
  - Model Properties: Run the query and wait until done
  - ...

### More about the SDK generator [Kiota](https://learn.microsoft.com/en-us/openapi/kiota/overview)

There are other SDK generators like [OpenAPI Generator](https://github.com/OpenAPITools/openapi-generator), [AutoRest](https://github.com/Azure/autorest), [NSwag](https://github.com/RicoSuter/NSwag), etc.

[Kiota](https://learn.microsoft.com/en-us/openapi/kiota/overview) offers several benefits:

- Support all OpenAPI specifications => Full typed SDK including:
  - Request and response bodies
  - Headers
  - Query parameters
  - Path parameters
- Easy to map the API provider documentation to the SDK => Easy to use
- Log error in reports and continue during SDK generation => Robust
- Can exclude some endpoints for the SDK generation => Customizable
- Open source => Transparent
- Developed by Microsoft and used for their Graph SDK (very large API) => Reliable/scalable
- Coded in C# => Easy to understand, extend and execute

Here is an introduction by the authors: [Introducing project Kiota a client generator for OpenAPI | .NET Conf 2023](https://www.youtube.com/watch?v=sQ9Pv-rQ1s8)

## Run Tests

1. Create an app on Autodesk Platform Services (APS) and get the client id and client secret.
1. Create a `appsettings.json` file based on this example:

````json
{
    "APS_CLIENT_ID": "ednqAmsC....N6eQPAKLsfVnXg",
    "APS_CLIENT_SECRET": "CHib...d4Bijb"
}
````
