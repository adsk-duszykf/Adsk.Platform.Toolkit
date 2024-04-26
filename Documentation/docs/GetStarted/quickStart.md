# Quick Start

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

## Authentication

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
