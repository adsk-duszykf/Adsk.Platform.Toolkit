// <auto-generated/>
using Autodesk.ACC.CostManagement.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.Payments.Summary {
    /// <summary>
    /// Builds and executes requests for operations under \v1\projects\{projectId}\payments\summary
    /// </summary>
    public class SummaryRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="SummaryRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SummaryRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/payments/summary{?filter%5BassociationId%5D*,filter%5BassociationType%5D*,filter%5BpaymentItemAssociationId%5D*,filter%5BpaymentItemAssociationType%5D*,filter%5Bstatus%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="SummaryRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SummaryRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/payments/summary{?filter%5BassociationId%5D*,filter%5BassociationType%5D*,filter%5BpaymentItemAssociationId%5D*,filter%5BpaymentItemAssociationType%5D*,filter%5Bstatus%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// Gets paid values.
        /// </summary>
        /// <returns>A List&lt;PaymentSummary&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="DefinedError">When receiving a 400 status code</exception>
        /// <exception cref="Error">When receiving a 401 status code</exception>
        /// <exception cref="Error">When receiving a 403 status code</exception>
        /// <exception cref="Error">When receiving a 404 status code</exception>
        /// <exception cref="Error">When receiving a 500 status code</exception>
        /// <exception cref="Error">When receiving a 503 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<PaymentSummary>?> GetAsync(Action<RequestConfiguration<SummaryRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<PaymentSummary>> GetAsync(Action<RequestConfiguration<SummaryRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"400", DefinedError.CreateFromDiscriminatorValue},
                {"401", Error.CreateFromDiscriminatorValue},
                {"403", Error.CreateFromDiscriminatorValue},
                {"404", Error.CreateFromDiscriminatorValue},
                {"500", Error.CreateFromDiscriminatorValue},
                {"503", Error.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<PaymentSummary>(requestInfo, PaymentSummary.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Gets paid values.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<SummaryRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<SummaryRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="SummaryRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public SummaryRequestBuilder WithUrl(string rawUrl)
        {
            return new SummaryRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets paid values.
        /// </summary>
        public class SummaryRequestBuilderGetQueryParameters 
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
            public GetFilterAssociationTypeQueryParameterType? FilterassociationTypeAsGetFilterAssociationTypeQueryParameterType { get; set; }
            /// <summary>The ID of the object is associated to payment item. For example, the ID of a schedule of value, main contract item, form instance, or cost item. Separate multiple IDs with commas. For example, ``filter[paymentItemAssociationId]=id1,id2``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5BpaymentItemAssociationId%5D")]
            public string[]? FilterpaymentItemAssociationId { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5BpaymentItemAssociationId%5D")]
            public string[] FilterpaymentItemAssociationId { get; set; }
#endif
            /// <summary>The type of the item associated to payment item. Possible values ``MainContractItem``, ``SOV``, ``OCO``, ``SCO``, ``CostItem``, ``MaterialsOnSite``. For example, ``filter[paymentItemAssociationType]=MainContractItem``.</summary>
            [Obsolete("This property is deprecated, use FilterpaymentItemAssociationTypeAsGetFilterPaymentItemAssociationTypeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5BpaymentItemAssociationType%5D")]
            public string[]? FilterpaymentItemAssociationType { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5BpaymentItemAssociationType%5D")]
            public string[] FilterpaymentItemAssociationType { get; set; }
#endif
            /// <summary>The type of the item associated to payment item. Possible values ``MainContractItem``, ``SOV``, ``OCO``, ``SCO``, ``CostItem``, ``MaterialsOnSite``. For example, ``filter[paymentItemAssociationType]=MainContractItem``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5BpaymentItemAssociationType%5D")]
            public GetFilterPaymentItemAssociationTypeQueryParameterType[]? FilterpaymentItemAssociationTypeAsGetFilterPaymentItemAssociationTypeQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5BpaymentItemAssociationType%5D")]
            public GetFilterPaymentItemAssociationTypeQueryParameterType[] FilterpaymentItemAssociationTypeAsGetFilterPaymentItemAssociationTypeQueryParameterType { get; set; }
#endif
            /// <summary>The status code. Separate multiple IDs with commas. For example, ``filter[status]=draft,open``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bstatus%5D")]
            public string[]? Filterstatus { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bstatus%5D")]
            public string[] Filterstatus { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class SummaryRequestBuilderGetRequestConfiguration : RequestConfiguration<SummaryRequestBuilderGetQueryParameters> 
        {
        }
    }
}
