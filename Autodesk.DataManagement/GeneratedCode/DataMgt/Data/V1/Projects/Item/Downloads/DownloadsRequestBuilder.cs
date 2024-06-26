// <auto-generated/>
using Autodesk.DataManagement.Data.V1.Projects.Item.Downloads.Item;
using Autodesk.DataManagement.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.DataManagement.Data.V1.Projects.Item.Downloads {
    /// <summary>
    /// Builds and executes requests for operations under \data\v1\projects\{project_id}\downloads
    /// </summary>
    public class DownloadsRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the Autodesk.DataManagement.data.v1.projects.item.downloads.item collection</summary>
        /// <param name="position">The unique identifier of a download job.</param>
        /// <returns>A <see cref="WithDownload_ItemRequestBuilder"/></returns>
        public WithDownload_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("download_id", position);
                return new WithDownload_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="DownloadsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DownloadsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/data/v1/projects/{project_id}/downloads", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="DownloadsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DownloadsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/data/v1/projects/{project_id}/downloads", rawUrl)
        {
        }
        /// <summary>
        /// Request the creation of a new download for a specific and supported file type. The fileType specified in the POST body needs to be contained in the list of supported file types returned by the GET /data/v1/projects/:project_id/downloads endpoint for the specified version_id.
        /// </summary>
        /// <returns>A <see cref="CreatedDownload"/></returns>
        /// <param name="body">Describe the download to be created.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CreatedDownload?> PostAsync(CreateDownload body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<CreatedDownload> PostAsync(CreateDownload body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<CreatedDownload>(requestInfo, CreatedDownload.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Request the creation of a new download for a specific and supported file type. The fileType specified in the POST body needs to be contained in the list of supported file types returned by the GET /data/v1/projects/:project_id/downloads endpoint for the specified version_id.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Describe the download to be created.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(CreateDownload body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(CreateDownload body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/vnd.api+json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="DownloadsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DownloadsRequestBuilder WithUrl(string rawUrl)
        {
            return new DownloadsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class DownloadsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
