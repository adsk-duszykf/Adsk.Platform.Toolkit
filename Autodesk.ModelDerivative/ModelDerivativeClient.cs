using Autodesk.ModelDerivative.Helpers;
using Autodesk.ModelDerivative.Helpers.Models;

namespace Autodesk.ModelDerivative;
public class ModelDerivativeClient
{
    public ModelDerivativeClient(Location serverLocation, Func<Task<string>> getAccessToken, HttpClient? httpClient = null)
    {
        var adapter = Autodesk.Common.HttpClientLibrary.HttpClientFactory.CreateAdapter(getAccessToken, httpClient);

        //Only override the BaseUrl if it is not set for testing purposes
        //Tests method could set the BaseUrl to a mock server
        if (serverLocation == Location.EMEA && adapter.BaseUrl is null)
        {
            adapter.BaseUrl = "https://developer.api.autodesk.com/modelderivative/v2/regions/eu";
        }

        Api = new BaseModelDerivativeClient(adapter);
        Helper = new ModelDerivativeClientHelper(Api);
    }

    public BaseModelDerivativeClient Api { get; protected set; }
    public ModelDerivativeClientHelper Helper { get; protected set; }


}