// <auto-generated/>
#pragma warning disable CS0618
using Autodesk.ACC.CostManagement.Models;
using Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.Item;
using Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.Meta;
using Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.Overview;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets
{
    /// <summary>
    /// Builds and executes requests for operations under \v1\projects\{projectId}\budgets
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class BudgetsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The meta property</summary>
        public global::Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.Meta.MetaRequestBuilder Meta
        {
            get => new global::Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.Meta.MetaRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The overview property</summary>
        public global::Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.Overview.OverviewRequestBuilder Overview
        {
            get => new global::Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.Overview.OverviewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Autodesk.ACC.CostManagement.v1.projects.item.budgets.item collection</summary>
        /// <param name="position">The budget ID.</param>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.Item.WithBudgetItemRequestBuilder"/></returns>
        public global::Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.Item.WithBudgetItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("budgetId", position);
                return new global::Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.Item.WithBudgetItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Autodesk.ACC.CostManagement.v1.projects.item.budgets.item collection</summary>
        /// <param name="position">The budget ID.</param>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.Item.WithBudgetItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.Item.WithBudgetItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("budgetId", position);
                return new global::Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.Item.WithBudgetItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.BudgetsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BudgetsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/budgets{?filter%5Bcode%5D*,filter%5BexternalId%5D*,filter%5BexternalSystem%5D*,filter%5Bid%5D*,filter%5BlastModifiedSince%5D*,filter%5BrootId%5D*,force*,include*,internalLimit*,limit*,offset*,q*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.BudgetsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BudgetsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/budgets{?filter%5Bcode%5D*,filter%5BexternalId%5D*,filter%5BexternalSystem%5D*,filter%5Bid%5D*,filter%5BlastModifiedSince%5D*,filter%5BrootId%5D*,force*,include*,internalLimit*,limit*,offset*,q*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns all the budgets in a specific project.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.BudgetListResponse"/></returns>
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
        public async Task<global::Autodesk.ACC.CostManagement.Models.BudgetListResponse?> GetAsync(Action<RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.BudgetsRequestBuilder.BudgetsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Autodesk.ACC.CostManagement.Models.BudgetListResponse> GetAsync(Action<RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.BudgetsRequestBuilder.BudgetsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
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
            return await RequestAdapter.SendAsync<global::Autodesk.ACC.CostManagement.Models.BudgetListResponse>(requestInfo, global::Autodesk.ACC.CostManagement.Models.BudgetListResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a budget in a given project.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.Budget"/></returns>
        /// <param name="body">The request body</param>
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
        public async Task<global::Autodesk.ACC.CostManagement.Models.Budget?> PostAsync(global::Autodesk.ACC.CostManagement.Models.BudgetCreate body, Action<RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.BudgetsRequestBuilder.BudgetsRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Autodesk.ACC.CostManagement.Models.Budget> PostAsync(global::Autodesk.ACC.CostManagement.Models.BudgetCreate body, Action<RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.BudgetsRequestBuilder.BudgetsRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Autodesk.ACC.CostManagement.Models.DefinedError.CreateFromDiscriminatorValue },
                { "401", global::Autodesk.ACC.CostManagement.Models.Error.CreateFromDiscriminatorValue },
                { "403", global::Autodesk.ACC.CostManagement.Models.Error.CreateFromDiscriminatorValue },
                { "404", global::Autodesk.ACC.CostManagement.Models.Error.CreateFromDiscriminatorValue },
                { "500", global::Autodesk.ACC.CostManagement.Models.Error.CreateFromDiscriminatorValue },
                { "503", global::Autodesk.ACC.CostManagement.Models.Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Autodesk.ACC.CostManagement.Models.Budget>(requestInfo, global::Autodesk.ACC.CostManagement.Models.Budget.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns all the budgets in a specific project.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.BudgetsRequestBuilder.BudgetsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.BudgetsRequestBuilder.BudgetsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a budget in a given project.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Autodesk.ACC.CostManagement.Models.BudgetCreate body, Action<RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.BudgetsRequestBuilder.BudgetsRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Autodesk.ACC.CostManagement.Models.BudgetCreate body, Action<RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.BudgetsRequestBuilder.BudgetsRequestBuilderPostQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.BudgetsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.BudgetsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.BudgetsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns all the budgets in a specific project.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class BudgetsRequestBuilderGetQueryParameters 
        {
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
            /// <summary>The ID of the item in its original external system. This ID can be used to track the source of truth or to look up the data in an integrated system. Separate multiple IDs with commas. For example, ``filter[externalId]=id1,id2``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5BexternalId%5D")]
            public string[]? FilterexternalId { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5BexternalId%5D")]
            public string[] FilterexternalId { get; set; }
#endif
            /// <summary>The name of the external system. This name can be used to track the source of truth or to search in an integrated system. For example, ``filter[externalSystem]=Sage300``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5BexternalSystem%5D")]
            public string? FilterexternalSystem { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5BexternalSystem%5D")]
            public string FilterexternalSystem { get; set; }
#endif
            /// <summary>The item&apos;s primary identifier. Separate multiple IDs with commas. For example, ``filter[id]=id1,id2``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bid%5D")]
            public string[]? Filterid { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bid%5D")]
            public string[] Filterid { get; set; }
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
            /// <summary>Query related sub-items for the given root item ID. Separate multiple IDs with commas. For example, ``filter[rootId]=id1,id2``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5BrootId%5D")]
            public string[]? FilterrootId { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5BrootId%5D")]
            public string[] FilterrootId { get; set; }
#endif
            /// <summary>Include nested resources in the response. For example, ``include=subitems`` will return the sub budget items. ``include=attributes`` will return custom attributes which represents the &quot;properties&quot; in the response.  Possible values: ``subitems``, ``attributes``, ``contract``, ``mainContract``, ``mainContractItem``, ``segments``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("include")]
            public string[]? Include { get; set; }
#nullable restore
#else
            [QueryParameter("include")]
            public string[] Include { get; set; }
#endif
            /// <summary>The maximum number of items to return, this is for internal use, and the default maximum internal limit is 5000.</summary>
            [QueryParameter("internalLimit")]
            public int? InternalLimit { get; set; }
            /// <summary>The maximum number of items to return, default maximum limit is 100.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>The number of items to skip before starting to collect the result set.</summary>
            [QueryParameter("offset")]
            public int? Offset { get; set; }
            /// <summary>The conditions to query against items, such as ``id=0`` or (``id&gt;2`` and ``id&lt;4``). This parameter is deprecated in favor of the ``filter[]`` based syntax.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("q")]
            public string? Q { get; set; }
#nullable restore
#else
            [QueryParameter("q")]
            public string Q { get; set; }
#endif
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
        public partial class BudgetsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.BudgetsRequestBuilder.BudgetsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Creates a budget in a given project.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class BudgetsRequestBuilderPostQueryParameters 
        {
            /// <summary>The flag to indicate whether this is a force update request. Only Project Admin is allowded to update, create, delete budgets after budgets are locked.</summary>
            [QueryParameter("force")]
            public bool? Force { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class BudgetsRequestBuilderPostRequestConfiguration : RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.BudgetsRequestBuilder.BudgetsRequestBuilderPostQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
