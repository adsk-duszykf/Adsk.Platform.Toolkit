// Ignore Spelling: Adsk

using AspNet.Security.OAuth.Autodesk;
using Autodesk.Common.HttpClientLibrary;
using Autodesk.DataManagement;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var clientId = builder.Configuration["AUTODESK_CLIENT_ID"] ?? throw new ArgumentException("'AUTODESK_CLIENT_ID' is undefined");
var clientSecret = builder.Configuration["AUTODESK_CLIENT_SECRET"] ?? throw new ArgumentException("'AUTODESK_CLIENT_SECRET' is undefined");

string[] scopes = ["data:read"];

// Add a named Adsk Toolkit http client to the DI store.
// This client includes the Adsk toolkit handlers: Error, Retry, Unzip, Redirect
// It might be useful to create a http client per APS service.
// In that way, you have the flexibility to manage the http handlers behavior per APS service
var DMhttpClientName = "MyDMHttpClient";
builder.Services.AddAdskToolkitHttpClient(DMhttpClientName);

builder.Services.AddAuthentication(options =>
{
    //Look first if there is cookie
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
})
.AddCookie(options =>
{
    options.LoginPath = "/signin";
    options.LogoutPath = "/signout";
});

// Add Autodesk authentication
builder.Services.AddAuthentication().AddAutodesk(options =>
{
    options.ClientId = clientId;
    options.ClientSecret = clientSecret;
    foreach (var scope in scopes)
    {
        options.Scope.Add(scope);
    }
    options.CallbackPath = "/signin-autodesk"; // No need to implement this endpoint the middleware automatically handle it
    options.SaveTokens = true; // Save the 3L access and refresh tokens that will accessible in the HttpContext 

});

builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapGet("/signin", () =>
{
    // Instruct the Autodesk authentication middleware to redirect the user agent to the Autodesk login page
    // When authenticated, the user is redirected to '/hubs'
    return Results.Challenge(new AuthenticationProperties { RedirectUri = "/hubs" },
        [AutodeskAuthenticationDefaults.AuthenticationScheme]);
});

app.MapGet("/signout", () =>
{
    // Instruct the cookies middleware to delete the local cookie created
    return Results.SignOut(new AuthenticationProperties { RedirectUri = "/hubs" },
        [CookieAuthenticationDefaults.AuthenticationScheme]);
});

// Retrieve the number of hubs visible with a 3L and 2L token
app.MapGet("/hubs", async (IHttpClientFactory clientFactory, HttpContext context) =>
{
    //Get the Adsk Toolkit HttpClient passed by DI
    var httpClient = clientFactory.CreateClient(DMhttpClientName);

    // Get the 3L token automatically stored during the 3L authentication flow
    var accessToken3L = await context.GetTokenAsync(AutodeskAuthenticationDefaults.AuthenticationScheme, "access_token");

    // Create an instance DataManagementClient. All subsequent calls with this client will use the 3L auth token
    Task<string> get3LeggedToken() => Task.FromResult(accessToken3L ?? "");
    var DMclientWith3LeggedAuth = new DataManagementClient(get3LeggedToken, httpClient);

    // Get the hubs visible with the 3L auth token
    var hubsFoundWith3L = await DMclientWith3LeggedAuth.DataMgtApi.Project.V1.Hubs.GetAsync();

    // Now create another DatamanegementClient but using a 2L token
    var authClient = new Autodesk.Authentication.AuthenticationClient(httpClient);
    var accessToken2L = await authClient.Helper.GetTwoLeggedToken(clientId, clientSecret, scopes);

    Task<string> get2LeggedToken() => Task.FromResult(accessToken2L.AccessToken ?? "");

    var DMclientWith2LeggedAuth = new DataManagementClient(get2LeggedToken, httpClient);

    // Get the hubs visible with the 2L auth token
    var hubsFoundWith2L = await DMclientWith2LeggedAuth.DataMgtApi.Project.V1.Hubs.GetAsync();

    return $"Number of hubs found with the 3L token: '{hubsFoundWith3L?.Data?.Count ?? 0}' and with the 2L token: '{hubsFoundWith2L?.Data?.Count ?? 0}'";
})
.RequireAuthorization()
.WithName("GetHubs")
.WithOpenApi();

app.Run();
