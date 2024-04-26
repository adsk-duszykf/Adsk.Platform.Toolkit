using Autodesk.Authentication.Helpers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Autodesk.Authentication;
public class AuthenticationClient
{
    public AuthenticationClient(HttpClient? httpClient = null)
    {
        httpClient ??= Autodesk.Common.HttpClientLibrary.HttpClient.Create();

        var adapter = new HttpClientRequestAdapter(
            authenticationProvider: new AnonymousAuthenticationProvider(),
            parseNodeFactory: null,
            serializationWriterFactory: null,
            httpClient: httpClient);

        Api = new BaseAuthenticationClient(adapter);
        Helper = new AuthenticationClientHelper(Api, httpClient);
    }

    public BaseAuthenticationClient Api { get; private set; }
    public AuthenticationClientHelper Helper { get; private set; }

}
