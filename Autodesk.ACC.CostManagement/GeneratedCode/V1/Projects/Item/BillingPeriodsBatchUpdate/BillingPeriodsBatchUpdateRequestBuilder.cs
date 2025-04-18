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
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.BillingPeriodsBatchUpdate
{
    /// <summary>
    /// Builds and executes requests for operations under \v1\projects\{projectId}\billing-periods:batch-update
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class BillingPeriodsBatchUpdateRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.BillingPeriodsBatchUpdate.BillingPeriodsBatchUpdateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BillingPeriodsBatchUpdateRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/billing-periods:batch-update?associationId={associationId}&associationType={associationType}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.BillingPeriodsBatchUpdate.BillingPeriodsBatchUpdateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BillingPeriodsBatchUpdateRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/billing-periods:batch-update?associationId={associationId}&associationType={associationType}", rawUrl)
        {
        }
        /// <summary>
        /// Creates or update or delete billing period
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.CreatedBillingPeriodListResponse"/></returns>
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
        public async Task<global::Autodesk.ACC.CostManagement.Models.CreatedBillingPeriodListResponse?> PostAsync(global::Autodesk.ACC.CostManagement.Models.BillingPeriodBatchUpdate body, Action<RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.BillingPeriodsBatchUpdate.BillingPeriodsBatchUpdateRequestBuilder.BillingPeriodsBatchUpdateRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Autodesk.ACC.CostManagement.Models.CreatedBillingPeriodListResponse> PostAsync(global::Autodesk.ACC.CostManagement.Models.BillingPeriodBatchUpdate body, Action<RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.BillingPeriodsBatchUpdate.BillingPeriodsBatchUpdateRequestBuilder.BillingPeriodsBatchUpdateRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
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
            return await RequestAdapter.SendAsync<global::Autodesk.ACC.CostManagement.Models.CreatedBillingPeriodListResponse>(requestInfo, global::Autodesk.ACC.CostManagement.Models.CreatedBillingPeriodListResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates or update or delete billing period
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Autodesk.ACC.CostManagement.Models.BillingPeriodBatchUpdate body, Action<RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.BillingPeriodsBatchUpdate.BillingPeriodsBatchUpdateRequestBuilder.BillingPeriodsBatchUpdateRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Autodesk.ACC.CostManagement.Models.BillingPeriodBatchUpdate body, Action<RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.BillingPeriodsBatchUpdate.BillingPeriodsBatchUpdateRequestBuilder.BillingPeriodsBatchUpdateRequestBuilderPostQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.BillingPeriodsBatchUpdate.BillingPeriodsBatchUpdateRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Autodesk.ACC.CostManagement.V1.Projects.Item.BillingPeriodsBatchUpdate.BillingPeriodsBatchUpdateRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Autodesk.ACC.CostManagement.V1.Projects.Item.BillingPeriodsBatchUpdate.BillingPeriodsBatchUpdateRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Creates or update or delete billing period
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class BillingPeriodsBatchUpdateRequestBuilderPostQueryParameters 
        {
            /// <summary>The object ID of the item is associated to. For example the ID of the budget, contract or cost item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("associationId")]
            public string? AssociationId { get; set; }
#nullable restore
#else
            [QueryParameter("associationId")]
            public string AssociationId { get; set; }
#endif
            /// <summary>The type of the item is associated to. Possible values ``Budget``, ``Contract``, ``CostItem``, ``FormInstance``, ``Payment``, ``BudgetPayment``, ``Expense``, ``OCO``, ``SCO``.</summary>
            [Obsolete("This property is deprecated, use AssociationTypeAsPostAssociationTypeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("associationType")]
            public string? AssociationType { get; set; }
#nullable restore
#else
            [QueryParameter("associationType")]
            public string AssociationType { get; set; }
#endif
            /// <summary>The type of the item is associated to. Possible values ``Budget``, ``Contract``, ``CostItem``, ``FormInstance``, ``Payment``, ``BudgetPayment``, ``Expense``, ``OCO``, ``SCO``.</summary>
            [QueryParameter("associationType")]
            public global::Autodesk.ACC.CostManagement.V1.Projects.Item.BillingPeriodsBatchUpdate.PostAssociationTypeQueryParameterType? AssociationTypeAsPostAssociationTypeQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class BillingPeriodsBatchUpdateRequestBuilderPostRequestConfiguration : RequestConfiguration<global::Autodesk.ACC.CostManagement.V1.Projects.Item.BillingPeriodsBatchUpdate.BillingPeriodsBatchUpdateRequestBuilder.BillingPeriodsBatchUpdateRequestBuilderPostQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
