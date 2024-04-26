using Autodesk.Authentication;
using Autodesk.Authentication.Helpers.Models;
using Autodesk.ModelDerivative;
using Autodesk.ModelDerivative.Helpers.Models;
using Sdk_Tests;

namespace Tests.ModelDerivative;

[TestClass]
public class ModelDerivativeClientHelperTests
{
    readonly AuthenticationClient authClient = new();

    readonly Settings config = Settings.Load();

    [TestMethod]
    public async Task ShouldReturnObjectTree()
    {
        async Task<string> getAccessToken()
        {
            var token = await authClient.Helper.GetTwoLeggedToken(config.APS_CLIENT_ID, config.APS_CLIENT_SECRET, [AuthenticationScope.DataRead]);
            return token?.AccessToken is null ? throw new InvalidOperationException() : token.AccessToken;
        }
        var MDclient = new ModelDerivativeClient(Location.US, getAccessToken);

        var objectTree = await MDclient.Helper.GetObjectTree(config.FILE_URN);

        Assert.IsNotNull(objectTree);
    }
}
