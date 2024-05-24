using Autodesk.ACC.RFIs;
using Autodesk.Authentication;
using Autodesk.Authentication.Helpers.Models;
using Autodesk.DataManagement;
using Sdk_Tests;

namespace Tests.ACC.RFIs;

[TestClass]
public class RFIsClientHelperTests
{
    private static readonly Settings config = Settings.Load();
    private RFIsClient RFIsClient { get; init; }
    private DataManagementClient DMClient { get; init; }

    public RFIsClientHelperTests()
    {
        (RFIsClient, DMClient) = InitializeClient();
    }

    [ClassInitialize]
    public static void StartMockServer(TestContext context)
    {
        APSmockServer.StartMockServer();
    }

    [ClassCleanup]
    public static void StopMockServer()
    {
        APSmockServer.Dispose();
    }

    [TestMethod]
    public async Task ShouldReturnListOfRFIs()
    {

        var hubId = (await DMClient.Helper.GetHubsByNameAsync(config.HUB_NAME))[0].Id ?? "";

        var containerId = await DMClient.Helper.GetRFIsContainerIdAsync(hubId, config.PROJECT_ID);

        var rfis = await RFIsClient.Helper.GetAllRFIsAsync(containerId);

        Assert.IsNotNull(rfis);
    }

    private (RFIsClient RFIsClient, DataManagementClient DMClient) InitializeClient()
    {
        var authProxyClient = APSmockServer.CreateProxyHttpClient(AdskService.Authentication);

        var authClient = new AuthenticationClient(authProxyClient);

        var scope = new List<AuthenticationScope>
        {
            AuthenticationScope.BucketCreate,
            AuthenticationScope.BucketDelete,
            AuthenticationScope.DataRead,
            AuthenticationScope.DataCreate,
            AuthenticationScope.DataWrite,
            AuthenticationScope.DataSearch
        };

        async Task<string> getAccessToken()
        {
            var token = await authClient.Helper.GetTwoLeggedToken(config.APS_CLIENT_ID, config.APS_CLIENT_SECRET, scope);

            return token?.AccessToken is null ? throw new InvalidOperationException() : token.AccessToken;
        }

        var DMproxyClient = APSmockServer.CreateProxyHttpClient(AdskService.DataManagement);

        var DataMgtClient = new DataManagementClient(getAccessToken, DMproxyClient);

        var RFIproxyClient = APSmockServer.CreateProxyHttpClient(AdskService.ACC_RFIs);

        var RFIsClient = new RFIsClient(() => { return ThreeLeggedTokenGenerator.GenerateToken(); }, RFIproxyClient);

        return (RFIsClient, DataMgtClient);
    }
}

