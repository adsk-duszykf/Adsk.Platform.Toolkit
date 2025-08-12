using Microsoft.Kiota.Abstractions;

namespace Autodesk.Common.HttpClientLibrary.Middleware.Options;

public class QueryParameterHandlerOption : IRequestOption
{
    /// <summary>
    /// List of query parameters to be added to the request.
    /// </summary>
    public Dictionary<string, string> QueryParameters { get; set; } = new Dictionary<string, string>();
}
