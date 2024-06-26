﻿namespace Autodesk.Authentication.Helpers.Models;

public interface ITokenStore
{
    /// <summary>
    /// Read the token from the store
    /// </summary>
    /// <returns>Authorization token</returns>
    AuthTokenExtended? Get();

    /// <summary>
    /// Save the token in the store
    /// </summary>
    /// <param name="authToken">Authorization token</param>
    void Set(AuthTokenExtended authToken);
}
