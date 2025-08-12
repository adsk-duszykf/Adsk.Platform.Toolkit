using Autodesk.Common.HttpClientLibrary.Middleware.Options;
using Microsoft.Kiota.Http.HttpClientLibrary.Extensions;

namespace Autodesk.Common.HttpClientLibrary.Middleware;

/// <summary>
/// Middleware extending the uri query parameters
/// </summary>
public class QueryParameterHandler : DelegatingHandler
{
    private readonly QueryParameterHandlerOption _queryParameterHandlerOptions;

    public QueryParameterHandler(QueryParameterHandlerOption? errorHandlerOptions = null)
    {
        _queryParameterHandlerOptions = errorHandlerOptions ?? new QueryParameterHandlerOption();
    }
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var queryParameterHandlerOptions = request.GetRequestOption<QueryParameterHandlerOption>() ?? _queryParameterHandlerOptions;

        if (queryParameterHandlerOptions.QueryParameters.Count != 0)
        {
            var uriBuilder = new UriBuilder(request.RequestUri!);
            var query = System.Web.HttpUtility.ParseQueryString(uriBuilder.Query);

            foreach (var parameter in queryParameterHandlerOptions.QueryParameters)
            {
                query[parameter.Key] = parameter.Value;
            }

            uriBuilder.Query = query.ToString();
            request.RequestUri = uriBuilder.Uri;
        }

        var response = await base.SendAsync(request, cancellationToken);

        return response;
    }

}
