using Microsoft.Kiota.Abstractions.Authentication;

namespace Autodesk.ModelDerivative;

internal class AccessTokenProvider(Func<Task<string>> getAccessToken) : IAccessTokenProvider
{
    public AllowedHostsValidator AllowedHostsValidator => throw new NotImplementedException();

    public async Task<string> GetAuthorizationTokenAsync(Uri uri, Dictionary<string, object>? additionalAuthenticationContext = null, CancellationToken cancellationToken = default)
    {
        return await getAccessToken();
    }
}
