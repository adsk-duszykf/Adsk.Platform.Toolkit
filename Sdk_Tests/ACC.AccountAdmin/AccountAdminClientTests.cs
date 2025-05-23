using Microsoft.VisualStudio.TestTools.UnitTesting;
using Autodesk.ACC.AccountAdmin; // Make sure this using is correct for AccountAdminClient
using System.Threading.Tasks; // For Task
using System; // For Func

namespace Sdk_Tests.ACC.AccountAdmin
{
    [TestClass]
    public class AccountAdminClientTests
    {
        private static async Task<string> MockGetAccessTokenAsync()
        {
            await Task.Delay(1); // Simulate async work
            return "dummy_token";
        }

        [TestMethod]
        public void Constructor_Should_Initialize_Api_Property()
        {
            // Arrange
            Func<Task<string>> getAccessTokenProvider = MockGetAccessTokenAsync;

            // Act
            var client = new AccountAdminClient(getAccessTokenProvider);

            // Assert
            Assert.IsNotNull(client, "Client should not be null.");
            Assert.IsNotNull(client.Api, "Client.Api property should not be null.");
        }

        [TestMethod]
        public void Constructor_NullAccessTokenProvider_ShouldThrowArgumentNullException()
        {
            // Arrange
            Func<Task<string>>? getAccessTokenProvider = null;

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                var client = new AccountAdminClient(getAccessTokenProvider);
            });
        }
    }
}
