// <auto-generated/>
#pragma warning disable CS0618
using Autodesk.ACC.CostManagement.Models;
using Autodesk.ACC.CostManagement.V1.Projects.Item.ChangeOrders.Item.BatchCreate;
using Autodesk.ACC.CostManagement.V1.Projects.Item.ChangeOrders.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.ChangeOrders
{
    /// <summary>
    /// Builds and executes requests for operations under \v1\projects\{projectId}\change-orders
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ChangeOrdersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Autodesk.ACC.CostManagement.v1.projects.item.changeOrders.item collection</summary>
        /// <param name="position">The change order type. Possible values: ``pco``, ``rfq``, ``rco``, ``oco``, ``sco``.</param>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.ChangeOrders.Item.WithChangeOrderItemRequestBuilder"/></returns>
        public global::Autodesk.ACC.CostManagement.V1.Projects.Item.ChangeOrders.Item.WithChangeOrderItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("changeOrder", position);
                return new global::Autodesk.ACC.CostManagement.V1.Projects.Item.ChangeOrders.Item.WithChangeOrderItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.ChangeOrders.ChangeOrdersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ChangeOrdersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/change-orders", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.ChangeOrders.ChangeOrdersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ChangeOrdersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/change-orders", rawUrl)
        {
        }
        /// <summary>
        /// Lists all the types of change orders available in a specific project.Currently there are 5 predefined types (``PCO``, ``RFQ``, ``RCO``, ``OCO``, ``SCO``) and each of them is represented as a form definition.Customization might be allowed in the future to add more change order types.
        /// </summary>
        /// <returns>A List&lt;global::Autodesk.ACC.CostManagement.Models.FormDefinition&gt;</returns>
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
        public async Task<List<global::Autodesk.ACC.CostManagement.Models.FormDefinition>?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::Autodesk.ACC.CostManagement.Models.FormDefinition>> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
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
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::Autodesk.ACC.CostManagement.Models.FormDefinition>(requestInfo, global::Autodesk.ACC.CostManagement.Models.FormDefinition.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Lists all the types of change orders available in a specific project.Currently there are 5 predefined types (``PCO``, ``RFQ``, ``RCO``, ``OCO``, ``SCO``) and each of them is represented as a form definition.Customization might be allowed in the future to add more change order types.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Builds and executes requests for operations under \v1\projects\{projectId}\change-orders\{changeOrder}\:batch-create
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.ChangeOrders.Item.BatchCreate.WithChangeOrderBatchCreateRequestBuilder"/></returns>
        /// <param name="changeOrder">The change order type. Possible values: ``pco``, ``rfq``, ``rco``, ``oco``, ``sco``.</param>
        public global::Autodesk.ACC.CostManagement.V1.Projects.Item.ChangeOrders.Item.BatchCreate.WithChangeOrderBatchCreateRequestBuilder WithChangeOrderBatchCreate(string changeOrder)
        {
            if(string.IsNullOrEmpty(changeOrder)) throw new ArgumentNullException(nameof(changeOrder));
            return new global::Autodesk.ACC.CostManagement.V1.Projects.Item.ChangeOrders.Item.BatchCreate.WithChangeOrderBatchCreateRequestBuilder(PathParameters, RequestAdapter, changeOrder);
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.ChangeOrders.ChangeOrdersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Autodesk.ACC.CostManagement.V1.Projects.Item.ChangeOrders.ChangeOrdersRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Autodesk.ACC.CostManagement.V1.Projects.Item.ChangeOrders.ChangeOrdersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ChangeOrdersRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
