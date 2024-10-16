using Autodesk.ACC.FileManagement.Helpers;

namespace Autodesk.ACC.FileManagement;
public class FileManagementClient
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FileManagementClient"/> class.
    /// </summary>
    /// <param name="getAccessToken">Function for getting the access token used for the following calls</param>
    /// <param name="httpClient">Optional: Override the default HttpClient used for performing API calls</param>
    public FileManagementClient(Func<Task<string>> getAccessToken, HttpClient? httpClient = null)
    {
        var adapter = Common.HttpClientLibrary.HttpClientFactory.CreateAdapter(getAccessToken, httpClient);

        Api = new BaseFileManagementClient(adapter);
        Helper = new FileManagementClientHelper(Api);
    }

    /// <summary>
    /// ACC File Management API client base path 'https://developer.api.autodesk.com/bim360/docs/v1'
    /// </summary>
    public BaseFileManagementClient Api { get; protected set; }

    /// <summary>
    /// High-level order functions supporting common operations
    /// </summary>
    public FileManagementClientHelper Helper { get; protected set; }

}


