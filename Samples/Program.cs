// See https://aka.ms/new-console-template for more information

using Autodesk.Authentication;
using Autodesk.Authentication.Helpers.Models;
using Autodesk.DataManagement;
using Microsoft.Kiota.Abstractions.Serialization;

String APS_CLIENT_ID = "YOUR_CLIENT_ID";
String APS_CLIENT_SECRET = "YOUR_CLIENT_SECRET";

// Initialize the DataManagementClient
var DMclient = InitializeDMclient();

var ACCfilePath = "Account/Project/Folder/SubFolder/FileName.ext";
var fileId = await GetFileId(ACCfilePath);

Console.WriteLine($"'{fileId}' is the id of '{ACCfilePath}'");

var hubIds = await GetHubIds();
Console.WriteLine($"Hubs: {string.Join(';', hubIds)}");

async Task<string> GetFileId(string ACCfilePath)
{
    // A single method call to get the file id by path
    var file = await DMclient.Helper.GetFileItemByPathAsync(ACCfilePath);

    return file.FileData.Data.Id ?? throw new InvalidDataException();
}
async Task<string[]> GetHubIds()
{
    var hubs = await DMclient.DataMgtApi.Project.V1.Hubs.GetAsync();
    return hubs?.Data?.Select(h => h?.Id ?? "")?.ToArray() ?? [];
}
DataManagementClient InitializeDMclient()
{

    var getAccessTokenFunc = GetAccessToken();

    var DMclient = new DataManagementClient(getAccessTokenFunc);

    return DMclient;
}

Func<Task<string>> GetAccessToken()
{
    var authClient = new AuthenticationClient();

    var scope = new List<AuthenticationScope>
        {
            AuthenticationScope.DataRead,
        };

    return async () =>
    {
        var token = await authClient.Helper.GetTwoLeggedToken(APS_CLIENT_ID, APS_CLIENT_SECRET, scope);

        return token?.AccessToken is null ? throw new InvalidOperationException() : token.AccessToken;
    };
}

class ParseNode : IParseNodeFactory
{
    public string ValidContentType => throw new NotImplementedException();

    public IParseNode GetRootParseNode(string contentType, Stream content)
    {
        throw new NotImplementedException();
    }
}
