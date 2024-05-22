using Autodesk.ACC.RFIs.Models;
using CommonUtils;
using static Autodesk.ACC.RFIs.V2.Containers.Item.Rfis.RfisRequestBuilder;

namespace Autodesk.ACC.RFIs.Helpers
{
    public class RFIsClientHelper
    {
        public BaseRFIsClient Api { get; init; }
        internal RFIsClientHelper(BaseRFIsClient api)
        {
            Api = api;
        }

        /// <summary>
        /// Get all RFIs from the container
        /// </summary>
        /// <param name="containerId">RFIs container Id</param>
        /// <param name="filter">(Optional) RFIs filter</param>
        /// <returns>List of all RFIs</returns>
        /// <exception cref="InvalidOperationException"></exception>
        public async Task<List<RfiBase>> GetAllRFIsAsync(string containerId, RfisRequestBuilderGetQueryParameters? filter = null)
        {
            return await GetRFIsAsync(containerId, filter).GetAll();
        }

        /// <summary>
        /// Get all RFIs from the container
        /// </summary>
        /// <param name="containerId">RFIs container Id</param>
        /// <param name="filter">(Optional) RFIs filter</param>
        /// <returns>Stream of all RFIs</returns>
        /// <exception cref="InvalidOperationException"></exception>
        public async IAsyncEnumerable<RfiBase> GetRFIsAsync(string containerId, RfisRequestBuilderGetQueryParameters? filter = null)
        {
            filter ??= new RfisRequestBuilderGetQueryParameters();

            filter.Offset = 0;
            filter.Limit = 200; // max limit
            var totalResults = 0;

            while (totalResults >= filter.Offset * filter.Limit)
            {
                var rfisResponse = (await Api.V2.Containers[containerId].Rfis.GetAsync(r =>
                {
                    r.QueryParameters = filter;
                }));

                var rfis = (rfisResponse?.Results ?? throw new InvalidOperationException("No RFIs returned"));

                foreach (var rfi in rfis)
                {
                    yield return rfi;
                }

                totalResults = rfisResponse?.Pagination?.TotalResults ?? throw new InvalidOperationException("Cannot find 'TotalResults' in the response.");

                filter.Offset++;
            }
        }
    }
}
