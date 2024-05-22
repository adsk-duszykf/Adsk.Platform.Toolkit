using Autodesk.Authentication;
using Autodesk.Authentication.Helpers.Models;
using Sdk_Tests;

namespace Tests;
[TestClass]
public class HttpClientTest
{
    public AuthenticationClient AuthClient { get; init; }

    public HttpClientTest()
    {
        AuthClient = InitializeAuthClient();
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
    public async Task ShouldThrowAnExceptionWhenInvalidCredentials()
    {
        Settings config = Settings.Load();

        try
        {
            await AuthClient.Helper.GetTwoLeggedToken(config.APS_CLIENT_ID, string.Empty, [AuthenticationScope.DataWrite, AuthenticationScope.DataRead]);
        }
        catch (HttpRequestException ex)
        {
            Assert.IsNotNull(ex.Message);
            return;
        }

        Assert.Fail();

    }
    private AuthenticationClient InitializeAuthClient()
    {
        var httpClient = Autodesk.Common.HttpClientLibrary.HttpClient.Create();

        var authProxyClient = APSmockServer.CreateProxyHttpClient(AdskService.Authentication, httpClient);

        var authClient = new AuthenticationClient(authProxyClient);

        return authClient;
    }
}
