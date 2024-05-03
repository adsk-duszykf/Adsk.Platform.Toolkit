using Autodesk.ACC.CustomAttributes.Helpers;

namespace Autodesk.ACC.CustomAttributes;
public class CustomAttributesClient
{
    public CustomAttributesClient(Func<Task<string>> getAccessToken, HttpClient? httpClient = null)
    {
        var adapter = Common.HttpClientLibrary.HttpClient.CreateAdapter(getAccessToken, httpClient);

        Api = new BaseCustomAttributesClient(adapter);
        Helper = new CustomAttributesClientHelper(Api);
    }

    public BaseCustomAttributesClient Api { get; protected set; }
    public CustomAttributesClientHelper Helper { get; protected set; }

}


