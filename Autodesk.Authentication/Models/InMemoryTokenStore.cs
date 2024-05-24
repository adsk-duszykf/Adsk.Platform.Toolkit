namespace Autodesk.Authentication.Helpers.Models;

public class InMemoryTokenStore : ITokenStore
{
    private AuthTokenExtended? _authToken;
    /// <summary>
    /// Read the token from the store
    /// </summary>
    /// <returns>Authorization token</returns>
    public AuthTokenExtended? Get()
    {
        return _authToken;
    }
    /// <summary>
    /// Save the token in the store
    /// </summary>
    /// <param name="authToken">Authorization token</param>
    public void Set(AuthTokenExtended token)
    {
        _authToken = token;
    }
}
