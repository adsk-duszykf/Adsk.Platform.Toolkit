using Autodesk.ACC.CostManagement.Helpers;

namespace Autodesk.ACC.CostManagement;
public class CostManagementClient
{
    public CostManagementClient(Func<Task<string>> getAccessToken, HttpClient? httpClient = null)
    {
        var adapter = Common.HttpClientLibrary.HttpClient.CreateAdapter(getAccessToken, httpClient);

        Api = new BaseCostManagementClient(adapter);
        Helper = new CostManagementClientHelper(Api);
    }

    public BaseCostManagementClient Api { get; protected set; }
    public CostManagementClientHelper Helper { get; protected set; }

}


