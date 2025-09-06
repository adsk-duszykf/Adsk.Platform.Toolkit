using Microsoft.Kiota.Abstractions.Authentication;

namespace Autodesk.Vault;

public class VaultClient
{
    /// <summary>
    /// Vault server name
    /// </summary>
    public string VaultServer { get; private set; } = string.Empty;

    /// <summary>
    /// Data Management API client
    /// </summary>
    public BaseVaultClient Api { get; private set; }

    /// <summary>
    /// High-level order functions supporting common operations
    /// </summary>

    /// <summary>
    /// Create a new instance for the Fusion Manage APIv3 http client.
    /// </summary>
    /// <param name="get2LeggedAccessToken">Function for getting the APS 2 legged access token used for the following calls</param>
    /// <param name="userId">A valid, active user email address in the Fusion Manage. This user is going to be impersonated in all calls using the access token</param>
    /// <param name="vaultServer">Vault server name</param>
    /// <param name="httpClient">Optional: Override the default HttpClient used for performing API calls</param>
    public VaultClient(Func<Task<string>> get2LeggedAccessToken, string vaultServer, string userId, HttpClient? httpClient = null)
    {
        Api = CreateClient(get2LeggedAccessToken, vaultServer, httpClient);
        VaultServer = vaultServer;
    }

    /// <summary>
    /// Create a new instance for the Fusion Manage APIv3 http client.
    /// </summary>
    /// <param name="get3LeggedAccessToken">Function for getting the APS 2 legged access token used for the following calls</param>
    /// <param name="vaultServer">Tenant name for the Fusion Manage instance</param>
    /// <param name="httpClient">Optional: Override the default HttpClient used for performing API calls</param>
    public VaultClient(Func<Task<string>> get3LeggedAccessToken, string vaultServer, HttpClient? httpClient = null)
    {

        Api = CreateClient(get3LeggedAccessToken, vaultServer, httpClient);
        VaultServer = vaultServer;

    }

    private static BaseVaultClient CreateClient(Func<Task<string>> getAccessToken, string vaultServer, HttpClient? httpClient = null)
    {
        if (string.IsNullOrEmpty(vaultServer))
            throw new ArgumentNullException(nameof(vaultServer), "Cannot be null or empty.");


        var auth = new BaseBearerTokenAuthenticationProvider(new Common.HttpClientLibrary.AccessTokenProvider(getAccessToken));
        var adapter = new Microsoft.Kiota.Bundle.DefaultRequestAdapter(auth, null, null, httpClient)
        {
            BaseUrl = $"https://{vaultServer}/AutodeskDM/Services/api/vault/v2"
        };

        return new BaseVaultClient(adapter);
    }

}

