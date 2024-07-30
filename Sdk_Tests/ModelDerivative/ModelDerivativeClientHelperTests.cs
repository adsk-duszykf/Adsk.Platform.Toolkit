using Autodesk.Authentication;
using Autodesk.Authentication.Helpers.Models;
using Autodesk.ModelDerivative;
using Autodesk.ModelDerivative.Helpers.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Sdk_Tests;

namespace Tests.ModelDerivative;

[TestClass]
public class ModelDerivativeClientHelperTests
{
    readonly AuthenticationClient authClient = new();

    readonly Settings config = Settings.Load();

    public ModelDerivativeClient MDclient { get; init; }

    public ModelDerivativeClientHelperTests()
    {
        MDclient = InitializeDMclient();
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
    public async Task ShouldReturnObjectTree()
    {
        var objectTree = await MDclient.Helper.GetObjectTreeAsync(config.FILE_URN);

        Assert.IsNotNull(objectTree);
    }
    [TestMethod]
    public async Task ShouldReturSpecificProperties()
    {

        var query = new UntypedObject(new Dictionary<string, UntypedNode> {
            { "$in",new UntypedArray(
                        [
                            new UntypedString("objectid"),
                            new UntypedInteger(1)
                        ])
            }
        });

        var properties = await MDclient.Helper.GetSpecificPropertiesAsync(
            config.FILE_URN, query);

        Assert.IsNotNull(properties);
    }
    private ModelDerivativeClient InitializeDMclient()
    {

        var authProxyClient = APSmockServer.CreateProxyHttpClient(AdskService.Authentication);

        var authClient = new AuthenticationClient(authProxyClient);

        var scope = new List<string>
        {
            AuthenticationScopeDefaults.BucketCreate,
            AuthenticationScopeDefaults.BucketDelete,
            AuthenticationScopeDefaults.DataRead,
            AuthenticationScopeDefaults.DataCreate,
            AuthenticationScopeDefaults.DataWrite,
            AuthenticationScopeDefaults.DataSearch
        };


        async Task<string> getAccessToken()
        {
            var token = await authClient.Helper.GetTwoLeggedToken(config.APS_CLIENT_ID, config.APS_CLIENT_SECRET, scope);

            return token?.AccessToken is null ? throw new InvalidOperationException() : token.AccessToken;
        }

        var MDProxyClient = APSmockServer.CreateProxyHttpClient(AdskService.ModelDerivative);

        var MDclient = new ModelDerivativeClient(Location.US, getAccessToken, MDProxyClient);

        return MDclient;
    }
}
