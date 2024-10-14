// <auto-generated/>
#pragma warning disable CS0618
using Autodesk.ACC.CostManagement.Models;
using Autodesk.ACC.CostManagement.V1.Projects.Item.Payments.Item;
using Autodesk.ACC.CostManagement.V1.Projects.Item.Payments.Summary;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.Payments
{
    /// <summary>
    /// Builds and executes requests for operations under \v1\projects\{projectId}\payments
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PaymentsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The summary property</summary>
        public global::Autodesk.ACC.CostManagement.V1.Projects.Item.Payments.Summary.SummaryRequestBuilder Summary
        {
            get => new global::Autodesk.ACC.CostManagement.V1.Projects.Item.Payments.Summary.SummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Autodesk.ACC.CostManagement.v1.projects.item.payments.item collection</summary>
        /// <param name="position">The payment ID.</param>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.Payments.Item.ItemRequestBuilder"/></returns>
        public global::Autodesk.ACC.CostManagement.V1.Projects.Item.Payments.Item.ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("%2Did", position);
                return new global::Autodesk.ACC.CostManagement.V1.Projects.Item.Payments.Item.ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.Payments.PaymentsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PaymentsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/payments{?filter%5BassociationId%5D*,filter%5BassociationType%5D*,filter%5BbudgetPaymentId%5D*,filter%5Bid%5D*,filter%5BlastModifiedSince%5D*,filter%5Bnumber%5D*,include*,internalLimit*,limit*,offset*,q*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.Payments.PaymentsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PaymentsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/payments{?filter%5BassociationId%5D*,filter%5BassociationType%5D*,filter%5BbudgetPaymentId%5D*,filter%5Bid%5D*,filter%5BlastModifiedSince%5D*,filter%5Bnumber%5D*,include*,internalLimit*,limit*,offset*,q*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Gets payment by conditions
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.PaymentListResponse"/></returns>
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
        public async Task<global::Autodesk.ACC.CostManagement.Models.PaymentListResponse?> GetAsync(Action<RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.Payments.PaymentsRequestBuilder.PaymentsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Autodesk.ACC.CostManagement.Models.PaymentListResponse> GetAsync(Action<RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.Payments.PaymentsRequestBuilder.PaymentsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
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
            return await RequestAdapter.SendAsync<global::Autodesk.ACC.CostManagement.Models.PaymentListResponse>(requestInfo, global::Autodesk.ACC.CostManagement.Models.PaymentListResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a payment
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.Payment"/></returns>
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
        public async Task<global::Autodesk.ACC.CostManagement.Models.Payment?> PostAsync(global::Autodesk.ACC.CostManagement.Models.Payment body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Autodesk.ACC.CostManagement.Models.Payment> PostAsync(global::Autodesk.ACC.CostManagement.Models.Payment body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
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
            return await RequestAdapter.SendAsync<global::Autodesk.ACC.CostManagement.Models.Payment>(requestInfo, global::Autodesk.ACC.CostManagement.Models.Payment.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets payment by conditions
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.Payments.PaymentsRequestBuilder.PaymentsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.Payments.PaymentsRequestBuilder.PaymentsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a payment
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Autodesk.ACC.CostManagement.Models.Payment body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Autodesk.ACC.CostManagement.Models.Payment body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.Payments.PaymentsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Autodesk.ACC.CostManagement.V1.Projects.Item.Payments.PaymentsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Autodesk.ACC.CostManagement.V1.Projects.Item.Payments.PaymentsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets payment by conditions
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class PaymentsRequestBuilderGetQueryParameters 
        {
            /// <summary>The contract or main contract ID of the payment is associated to. Separate multiple IDs with commas. For example, ``filter[associationId]=id1,id2``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5BassociationId%5D")]
            public string[]? FilterassociationId { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5BassociationId%5D")]
            public string[] FilterassociationId { get; set; }
#endif
            /// <summary>The type of item the the payment is associated to. Possible values: ``Contract`` for cost payments and ``MainContract`` for budget payments. For example, ``filter[associationType]=Contract``.</summary>
            [Obsolete("This property is deprecated, use FilterassociationTypeAsGetFilterAssociationTypeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5BassociationType%5D")]
            public string? FilterassociationType { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5BassociationType%5D")]
            public string FilterassociationType { get; set; }
#endif
            /// <summary>The type of item the the payment is associated to. Possible values: ``Contract`` for cost payments and ``MainContract`` for budget payments. For example, ``filter[associationType]=Contract``.</summary>
            [QueryParameter("filter%5BassociationType%5D")]
            public global::Autodesk.ACC.CostManagement.V1.Projects.Item.Payments.GetFilterAssociationTypeQueryParameterType? FilterassociationTypeAsGetFilterAssociationTypeQueryParameterType { get; set; }
            /// <summary>The ID of the budget payment used to query the related cost payments or expenses. Separate multiple IDs with commas. For example, ``filter[budgetPaymentId]=id1,id2``, or filter these that are not linked to any budget payment ``filter[budgetPaymentId]=blank``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5BbudgetPaymentId%5D")]
            public string[]? FilterbudgetPaymentId { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5BbudgetPaymentId%5D")]
            public string[] FilterbudgetPaymentId { get; set; }
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
            /// <summary>The item&apos;s number. For example, ``filter[number]=0001,0002``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bnumber%5D")]
            public string[]? Filternumber { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bnumber%5D")]
            public string[] Filternumber { get; set; }
#endif
            /// <summary>Include nested resources in the response. For example, ``include=paymentReferences`` will return payment references to each payment. ``include=attributes`` will return custom attributes which represents the &quot;properties&quot; in the response. Possible values: ``paymentReferences``, ``attributes``.</summary>
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
        public partial class PaymentsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.Payments.PaymentsRequestBuilder.PaymentsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class PaymentsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
