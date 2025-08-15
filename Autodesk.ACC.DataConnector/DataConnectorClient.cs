using Autodesk.ACC.DataConnector.Helpers;
namespace Autodesk.ACC.DataConnector;

public class DataConnectorClient
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DataConnectorClient"/> class.
    /// </summary>
    /// <param name="getAccessToken">Function for getting the access token used for the following calls</param>
    /// <param name="httpClient">Optional: Override the default HttpClient used for performing API calls</param>
    public DataConnectorClient(Func<Task<string>> getAccessToken, HttpClient? httpClient = null)
    {
        var adapter = Common.HttpClientLibrary.HttpClientFactory.CreateAdapter(getAccessToken, httpClient);

        Api = new BaseDataConnectorClient(adapter);
        Helper = new DataConnectorClientHelper(Api);

    }

    /// <summary>
    /// ACC Data Connector API client base path 'https://developer.api.autodesk.com/bim360/docs/v1'
    /// </summary>
    public BaseDataConnectorClient Api { get; protected set; }

    /// <summary>
    /// High-level order functions supporting common operations
    /// </summary>
    public DataConnectorClientHelper Helper { get; protected set; }
}
