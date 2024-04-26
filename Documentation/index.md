# Yet Another SDK!

Monorepo containing the APS SDK in C# for the following services:

- Authentication
- Data Management/OSS
- Model Derivative
- ACC/BIM360 Model Properties

The SDK is generated using the [Kiota](https://learn.microsoft.com/en-us/openapi/kiota/overview) code generator from the [OpenAPI](https://forge.autodesk.com/en/docs) specifications.

> [!Video https://www.youtube.com/embed/sQ9Pv-rQ1s8]

## Motivations

### Why another SDK?

- The existing SDKs have some limitations, that are addressed by this SDK with the help of the [Kiota](https://learn.microsoft.com/en-us/openapi/kiota/overview) code generator. See bellow.
- Those SDKs contains a `Helper` class that contains methods wrapping common actions combining multiple API calls.
  - Authentication: Create and refresh automatically a 2 legged token
  - DataManagement: Download/Upload a file
  - Model Derivative: Get large model tree
  - Model Properties: Run the query and wait until done
  - ...

### Why [Kiota](https://learn.microsoft.com/en-us/openapi/kiota/overview)?

There are other SDK generators like [OpenAPI Generator](https://github.com/OpenAPITools/openapi-generator), [AutoRest](https://github.com/Azure/autorest), [NSwag](https://github.com/RicoSuter/NSwag), etc.

- Support all OpenAPI specifications => Full typed SDK including:
  - Request and response bodies
  - Headers
  - Query parameters
  - Path parameters
- Easy to map the API provider documentation to the SDK => Easy to use
- Log error in reports and continue during SDK generation => Robust
- Can exclude some endpoints from the SDK generation => Customizable
- Open source => Transparent
- Developed by Microsoft and used for their Graph SDK (very large API) => Reliable
- Coded in C# => Easy to understand, extend and execute
- Others: Flexible `HttpClient` with built-in retry policy; VS Code extension for Kiota, easy setup and CI/CD integration...

## How to use the SDKs

The root object for each service is `{service}Client`. For example, the root object for the Data Management service is `DataManagementClient`.
This object contains 2 properties:
    - `Api`: Contains the root object for the API.
    - `Helper`: Contains methods that cover common scenarios combining multiple API calls.

The SDK reflects the Rest API endpoint structure. For example, the endpoint `GET https://developer.api.autodesk.com/project/v1/hubs` is represented by the following code:

````csharp
client.DataMgtApi.Project.V1.Hubs.GetAsync()
````

For more details about the SDK structure, see the [Kiota documentation](https://learn.microsoft.com/en-us/openapi/kiota/request-builders)

For code examples look at the files `{service}ClientHelper.cs`.

### Authentication

Each service needs an authentication provider. The authentication provider is passed to the `client` constructor as a function retrieving the access token.

**Example with authentication SDK:**

````csharp
public async Task<Hubs> GetHub()
{

    var APS_CLIENT_ID="abcd"; // Replace with your client id
    var APS_CLIENT_SECRET="1234"; // Replace with your client secret

    AuthenticationClient authClient = new();

    async Task<string> getAccessToken()
    {
        var token = await authClient.Helper.GetTwoLeggedToken(APS_CLIENT_ID, APS_CLIENT_SECRET, [ AuthenticationScope.DataRead]);

        return token?.AccessToken is null ? throw new InvalidOperationException() : token.AccessToken;
    }

    var DMclient = new DataManagementClient(getAccessToken);

    var hubs = await DMclient.DataMgtApi.Project.V1.Hubs.GetAsync();

    return hubs;
}
````

**Example without authentication SDK:**

````csharp
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
````