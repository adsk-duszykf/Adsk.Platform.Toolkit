using Autodesk.ACC.DataConnector.Models;
using CommonUtils;

namespace Autodesk.ACC.DataConnector.Helpers;

public class DataConnectorClientHelper
{
    public BaseDataConnectorClient Api { get; init; }
    internal DataConnectorClientHelper(BaseDataConnectorClient api)
    {
        Api = api;
    }


    /// <summary>
    /// Retrieves all data requests for a specific ACC account.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="accountId">ACC Account ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Data Requests</returns>
    /// <exception cref="InvalidOperationException"></exception>
    public async IAsyncEnumerable<DataRequest> GetAllRequestsAsync<T>(string accountId, [System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken = default)
    {

        var currentPage = new Pagination
        {
            Limit = 20,
            Offset = 0,
            TotalResults = 0
        };

        bool isLastPage = false;

        do
        {
            var response = await Api.Accounts[Guid.Parse(accountId)].Requests.GetAsync(
                r => r.QueryParameters.Offset = currentPage.Offset,
                cancellationToken: cancellationToken);

            var requests = response ?? throw new InvalidOperationException("No results found.");

            currentPage.TotalResults = response.Pagination?.TotalResults;
            currentPage.Offset += currentPage.Limit;

            isLastPage = currentPage.Offset + currentPage.Limit >= currentPage.TotalResults;

            foreach (var request in response?.Results ?? [])
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    yield break;
                }

                yield return request;
            }

            if (cancellationToken.IsCancellationRequested)
            {
                yield break;
            }
        }
        while (isLastPage == false);
    }
}
