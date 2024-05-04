using Autodesk.ACC.FileManagement.Helpers;

namespace Autodesk.ACC.FileManagement;
public class FileManagementClient
{
    public FileManagementClient(Func<Task<string>> getAccessToken, HttpClient? httpClient = null)
    {
        var adapter = Common.HttpClientLibrary.HttpClient.CreateAdapter(getAccessToken, httpClient);

        Api = new BaseFileManagementClient(adapter);
        Helper = new FileManagementClientHelper(Api);
    }

    public BaseFileManagementClient Api { get; protected set; }
    public FileManagementClientHelper Helper { get; protected set; }

}


