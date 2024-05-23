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
    //Test the Http error handler
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

    [TestMethod]
    //Test the rate limit handler
    public async Task ShouldSlowerDownByRateLimit()
    {
        var requestTimeWindow = TimeSpan.FromMilliseconds(1000);
        var httpClient = Autodesk.Common.HttpClientLibrary.HttpClient.Create((10, requestTimeWindow));

        var startingAt = DateTime.Now;

        var tasks = new List<Task<HttpResponseMessage>>();
        for (int i = 0; i < 20; i++)
        {
            //Response delay from the mock server 2ms
            var resp = httpClient.GetAsync("http://localhost:4200/ratelimit/test?testparam=1");
            tasks.Add(resp);

        }

        await Task.WhenAll(tasks);

        var endAt = DateTime.Now;

        Assert.IsTrue((endAt - startingAt).TotalMilliseconds >= requestTimeWindow.TotalMilliseconds);

    }

    [TestMethod]
    //Test the rate limit handler
    public async Task ShouldIgnoreRateLimit()
    {
        var requestTimeWindow = TimeSpan.FromSeconds(1);
        var httpClient = Autodesk.Common.HttpClientLibrary.HttpClient.Create();

        var startingAt = DateTime.Now;

        var tasks = new List<Task>();
        for (int i = 0; i < 20; i++)
        {
            //Response delay from the mock server 2ms
            var resp = httpClient.GetAsync("http://localhost:4200/ratelimit/test?testparam=1");
            tasks.Add(resp);

        }

        await Task.WhenAll(tasks);

        var endAt = DateTime.Now;

        Assert.IsTrue((endAt - startingAt).TotalMilliseconds < requestTimeWindow.TotalMilliseconds);

    }
    private AuthenticationClient InitializeAuthClient()
    {
        var httpClient = Autodesk.Common.HttpClientLibrary.HttpClient.Create();

        var authProxyClient = APSmockServer.CreateProxyHttpClient(AdskService.Authentication, httpClient);

        var authClient = new AuthenticationClient(authProxyClient);

        return authClient;
    }
}
