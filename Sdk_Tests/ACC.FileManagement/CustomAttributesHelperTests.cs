using System.Net;
using Autodesk.ACC.FileManagement;
using Autodesk.ACC.FileManagement.Helpers.Models;
using Autodesk.ACC.FileManagement.Projects.Item.VersionsBatchGet;
using Autodesk.Authentication;
using Autodesk.Authentication.Helpers.Models;
using Sdk_Tests;

namespace Tests.ACC.FileManagement;

[TestClass]
public class CustomAttributesHelperTests
{
    private static readonly Settings config = Settings.Load();
    private FileManagementClient CustomAttrClient { get; init; }

    public CustomAttributesHelperTests()
    {
        CustomAttrClient = InitializeClient();
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
    public async Task ShouldReturnListOfCustomAttributes()
    {

        var customAttributes = await CustomAttrClient.Helper.GetAllCustomAttributeDefinitionAsync(config.PROJECT_ID, config.FOLDER_ID);

        Assert.IsNotNull(customAttributes);
    }

    [TestMethod]
    public async Task ShouldUpdateCustomAttributes()
    {

        //Arrange
        //Generate a random value for the custom attribute
        var attributeName = "MyAttribute";
        var random = new Random();
        var attrValue = random.Next().ToString();

        var attributes = new List<CustomAttribute>()
        {
            new(attributeName, attrValue)
        };

        //Act
        //Update the custom attribute
        var fileId = WebUtility.UrlEncode(WebUtility.UrlEncode(config.FILE_URN));  //WORKAROUND: Wiremock decodes the url parameters, so we need to encode it before sending it. See https://github.com/WireMock-Net/WireMock.Net/issues/1097

        var errors = await CustomAttrClient.Helper.UpdateCustomAttributesAsync(config.PROJECT_ID, config.FOLDER_ID, fileId, attributes);

        //Get the updated custom attribute
        var customAttributes = await CustomAttrClient.Api.Projects[config.PROJECT_ID].VersionsBatchGet.PostAsync(new VersionsBatchGetPostRequestBody()
        {
            Urns = [config.FILE_URN]
        });

        var updatedAttribute = customAttributes?.Results?.FirstOrDefault()
                                   ?.CustomAttributes?.FirstOrDefault(attr => string.Equals(attr.Name, attributeName, StringComparison.InvariantCultureIgnoreCase));

        //Assert
        Assert.IsTrue(errors.Count == 0);
        Assert.AreEqual(attrValue, updatedAttribute?.Value);
    }
    private FileManagementClient InitializeClient()
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

        var CCProxyClient = APSmockServer.CreateProxyHttpClient(AdskService.ACC_CustomAttributes);

        var CustomAttrClient = new FileManagementClient(getAccessToken, CCProxyClient);

        return CustomAttrClient;
    }
}

