using Autodesk.Authentication;
using Autodesk.Authentication.Helpers.Models;
using Sdk_Tests;

namespace Tests.Authentication
{
    [TestClass]
    public class AutodeskAuthentication_Tests
    {
        private readonly AuthenticationClient authClient = new();

        [TestMethod]
        public async Task ShouldBeCreated()
        {
            Settings config = Settings.Load();

            var authToken = await authClient.Helper.GetTwoLeggedToken(config.APS_CLIENT_ID, config.APS_CLIENT_SECRET, [AuthenticationScope.DataWrite, AuthenticationScope.DataRead]);

            Assert.IsNotNull(authToken);

        }

    }
}