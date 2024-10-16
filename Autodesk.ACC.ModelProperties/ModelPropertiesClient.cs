using Autodesk.ACC.ModelProperties.Helpers;

namespace Autodesk.ACC.ModelProperties;

public class ModelPropertiesClient
{
    public ModelPropertiesClient(Func<Task<string>> getAccessToken, HttpClient? httpClient = null)
    {
        var adapter = Autodesk.Common.HttpClientLibrary.HttpClientFactory.CreateAdapter(getAccessToken, httpClient);
        Api = new BaseModelPropertiesClient(adapter);
        Helper = new ModelPropertiesClientHelper(Api);

    }

    public BaseModelPropertiesClient Api { get; private set; }

    public ModelPropertiesClientHelper Helper { get; private set; }

}