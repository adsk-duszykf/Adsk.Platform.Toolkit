# Autodesk Authentication Service SDK

## Quick Start

````csharp
// Create a new instance of the AuthenticationClient
var authClient = new AuthenticationClient();

// Use helpers to get a 2-legged access token
 AuthTokenExtended authToken1 = await authClient.Helper.GetTwoLeggedToken(
	APS_CLIENT_ID, 
	APS_CLIENT_SECRET, 
	[AuthenticationScope.DataWrite, AuthenticationScope.DataRead]);

// Or use API directly and helper static methods
var body = new TokenPostRequestBody()
{
    GrantType = Granttype.Client_credentials,
    Scope = CreateScopeString(scopes)
};

var authString = AuthenticationClientHelper.CreateAuthorizationString(APS_CLIENT_ID, APS_CLIENT_SECRET);

AuthToken authToken2 = await authClient.Authentication.V2.Token.PostAsync(body, r =>
{
    r.Headers.Add("Authorization", authString);
});

// Or use API only
...

````

