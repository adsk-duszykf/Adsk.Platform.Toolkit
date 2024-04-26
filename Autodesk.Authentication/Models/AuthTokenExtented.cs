using Autodesk.Authentication.Models;

namespace Autodesk.Authentication.Helpers.Models;

public class AuthTokenExtended : AuthToken
{
    public AuthTokenExtended(AuthToken? accessToken)
    {
        Initialize(accessToken, DateTime.UtcNow);
    }
    public AuthTokenExtended(AuthToken? accessToken, DateTime createAt)
    {
        Initialize(accessToken, createAt);
    }

    private void Initialize(AuthToken? accessToken, DateTime createAt)
    {
        AccessToken = accessToken?.AccessToken;
        ExpiresIn = accessToken?.ExpiresIn;
        RefreshToken = accessToken?.RefreshToken;
        IdToken = accessToken?.IdToken;
        ExpiresAt = createAt.AddSeconds(ExpiresIn ?? 0);
    }

    /// <summary>
    /// Return the expiration date of the access token in UTC
    /// </summary>
    public DateTime ExpiresAt { get; private set; }

}
