using Microsoft.Kiota.Abstractions;

namespace Autodesk.Common.HttpClientLibrary.Middleware.Options;

public class ErrorHandlerOption : IRequestOption
{
    /// <summary>
    /// If true, the error handler will throw an exception if the response has not a success status.
    /// </summary>
    public bool Enabled { get; set; } = true;
}
