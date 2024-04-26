namespace Autodesk.Authentication.Helpers.Models;

public interface ITokenStore
{
    AuthTokenExtended? Get();
    void Set(AuthTokenExtended authToken);
}
