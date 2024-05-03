using Autodesk.Authentication;
using Autodesk.Authentication.Helpers.Models;
using Sdk_Tests;

namespace Tests.Authentication
{
    [TestClass]
    public class AutodeskAuthentication_Tests
    {
        public AuthenticationClient AuthClient { get; init; }

        public AutodeskAuthentication_Tests()
        {
            AuthClient = InitializeDMclient();
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
        public async Task ShouldBeCreated()
        {
            Settings config = Settings.Load();

            var authToken = await AuthClient.Helper.GetTwoLeggedToken(config.APS_CLIENT_ID, config.APS_CLIENT_SECRET, [AuthenticationScope.DataWrite, AuthenticationScope.DataRead]);

            Assert.IsNotNull(authToken);

        }
        private AuthenticationClient InitializeDMclient()
        {

            var authProxyClient = Autodesk.Common.HttpClientLibrary.HttpClient.Create();

            authProxyClient.BaseAddress = new Uri(APSmockServer.GetProxyUrl(AdskService.Authentication));

            var authClient = new AuthenticationClient(authProxyClient);

            return authClient;
        }
    }
}