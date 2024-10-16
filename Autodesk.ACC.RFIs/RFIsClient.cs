using Autodesk.ACC.RFIs.Helpers;

namespace Autodesk.ACC.RFIs;
public class RFIsClient
{
    public RFIsClient(Func<Task<string>> getAccessToken, HttpClient? httpClient = null)
    {
        var adapter = Common.HttpClientLibrary.HttpClientFactory.CreateAdapter(getAccessToken, httpClient);

        Api = new BaseRFIsClient(adapter);
        Helper = new RFIsClientHelper(Api);
    }

    public BaseRFIsClient Api { get; protected set; }
    public RFIsClientHelper Helper { get; protected set; }

}
