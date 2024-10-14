// <auto-generated/>
#pragma warning disable CS0618
using Autodesk.ACC.CostManagement.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.SegmentValues
{
    /// <summary>
    /// Builds and executes requests for operations under \v1\projects\{projectId}\segment-values
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SegmentValuesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.SegmentValues.SegmentValuesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SegmentValuesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/segment-values{?cursorState*,filter%5Bcode%5D*,filter%5BlastModifiedSince%5D*,filter%5BoriginalCode%5D*,filter%5BparentId%5D*,filter%5BsegmentId%5D*,internalLimit*,limit*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.SegmentValues.SegmentValuesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SegmentValuesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/segment-values{?cursorState*,filter%5Bcode%5D*,filter%5BlastModifiedSince%5D*,filter%5BoriginalCode%5D*,filter%5BparentId%5D*,filter%5BsegmentId%5D*,internalLimit*,limit*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieves all of the defined segment values.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.SegmentValueListResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Autodesk.ACC.CostManagement.Models.DefinedError">When receiving a 400 status code</exception>
        /// <exception cref="global::Autodesk.ACC.CostManagement.Models.Error">When receiving a 401 status code</exception>
        /// <exception cref="global::Autodesk.ACC.CostManagement.Models.Error">When receiving a 403 status code</exception>
        /// <exception cref="global::Autodesk.ACC.CostManagement.Models.Error">When receiving a 404 status code</exception>
        /// <exception cref="global::Autodesk.ACC.CostManagement.Models.Error">When receiving a 500 status code</exception>
        /// <exception cref="global::Autodesk.ACC.CostManagement.Models.Error">When receiving a 503 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Autodesk.ACC.CostManagement.Models.SegmentValueListResponse?> GetAsync(Action<RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.SegmentValues.SegmentValuesRequestBuilder.SegmentValuesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Autodesk.ACC.CostManagement.Models.SegmentValueListResponse> GetAsync(Action<RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.SegmentValues.SegmentValuesRequestBuilder.SegmentValuesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Autodesk.ACC.CostManagement.Models.DefinedError.CreateFromDiscriminatorValue },
                { "401", global::Autodesk.ACC.CostManagement.Models.Error.CreateFromDiscriminatorValue },
                { "403", global::Autodesk.ACC.CostManagement.Models.Error.CreateFromDiscriminatorValue },
                { "404", global::Autodesk.ACC.CostManagement.Models.Error.CreateFromDiscriminatorValue },
                { "500", global::Autodesk.ACC.CostManagement.Models.Error.CreateFromDiscriminatorValue },
                { "503", global::Autodesk.ACC.CostManagement.Models.Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Autodesk.ACC.CostManagement.Models.SegmentValueListResponse>(requestInfo, global::Autodesk.ACC.CostManagement.Models.SegmentValueListResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieves all of the defined segment values.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.SegmentValues.SegmentValuesRequestBuilder.SegmentValuesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.SegmentValues.SegmentValuesRequestBuilder.SegmentValuesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.SegmentValues.SegmentValuesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Autodesk.ACC.CostManagement.V1.Projects.Item.SegmentValues.SegmentValuesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Autodesk.ACC.CostManagement.V1.Projects.Item.SegmentValues.SegmentValuesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieves all of the defined segment values.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class SegmentValuesRequestBuilderGetQueryParameters 
        {
            /// <summary>The cursor token to get the next page of results.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("cursorState")]
            public string? CursorState { get; set; }
#nullable restore
#else
            [QueryParameter("cursorState")]
            public string CursorState { get; set; }
#endif
            /// <summary>The item&apos;s codes. For example, ``filter[code]=01,02``. The code in number format needs to be enclosed in double quotes if you do filter like ``filter[code]=&quot;1&quot; / filter[code]=&quot;122.221&quot;``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bcode%5D")]
            public string[]? Filtercode { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bcode%5D")]
            public string[] Filtercode { get; set; }
#endif
            /// <summary>Retrieves items that were modified from the specified date and time, in the following format, YYYY-MM-DDThh:mm:ss.sz. For example, ``filter[lastModifiedSince]=2020-03-01T13:00:00Z``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5BlastModifiedSince%5D")]
            public string? FilterlastModifiedSince { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5BlastModifiedSince%5D")]
            public string FilterlastModifiedSince { get; set; }
#endif
            /// <summary>The segment original codes. For example, ``filter[originalCode]=originalCode,originalCode``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5BoriginalCode%5D")]
            public string[]? FilteroriginalCode { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5BoriginalCode%5D")]
            public string[] FilteroriginalCode { get; set; }
#endif
            /// <summary>The item&apos;s parent primary identifier. Separate multiple parent IDs with commas. For example, ``filter[parentId]=parentId1,parentId2``, or filter these items that have no parent ``filter[parentId]=blank``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5BparentId%5D")]
            public string[]? FilterparentId { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5BparentId%5D")]
            public string[] FilterparentId { get; set; }
#endif
            /// <summary>The budget code segment ID. Separate multiple IDs with commas. For example, ``filter[segmentId]=id1,id2``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5BsegmentId%5D")]
            public string[]? FiltersegmentId { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5BsegmentId%5D")]
            public string[] FiltersegmentId { get; set; }
#endif
            /// <summary>The maximum number of items to return, this is for internal use, and the default maximum internal limit is 5000.</summary>
            [QueryParameter("internalLimit")]
            public int? InternalLimit { get; set; }
            /// <summary>The maximum number of items to return, default maximum limit is 100.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>The sort order for items. Each attribute can be sorted in either ``asc`` (default) or ``desc`` order. For example, ``sort=name, updatedAt desc`` or ``sort=name + updatedAt desc`` sorts the results first by name in ascending order, then by date updated in descending order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort")]
            public string? Sort { get; set; }
#nullable restore
#else
            [QueryParameter("sort")]
            public string Sort { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class SegmentValuesRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.SegmentValues.SegmentValuesRequestBuilder.SegmentValuesRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
