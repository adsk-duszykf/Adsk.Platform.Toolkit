// <auto-generated/>
using Autodesk.ACC.CostManagement.Models;
using Autodesk.ACC.CostManagement.V1.Projects.Item.DefaultValues.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.DefaultValues {
    /// <summary>
    /// Builds and executes requests for operations under \v1\projects\{projectId}\default-values
    /// </summary>
    public class DefaultValuesRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the Autodesk.ACC.CostManagement.v1.projects.item.defaultValues.item collection</summary>
        /// <param name="position">The object ID of the item.</param>
        /// <returns>A <see cref="DefaultValuesItemRequestBuilder"/></returns>
        public DefaultValuesItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new DefaultValuesItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Autodesk.ACC.CostManagement.v1.projects.item.defaultValues.item collection</summary>
        /// <param name="position">The object ID of the item.</param>
        /// <returns>A <see cref="DefaultValuesItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public DefaultValuesItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("id", position);
                return new DefaultValuesItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="DefaultValuesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DefaultValuesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/default-values{?sourceType*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="DefaultValuesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DefaultValuesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/default-values{?sourceType*}", rawUrl)
        {
        }
        /// <summary>
        /// Gets all default value definitions in the given container
        /// </summary>
        /// <returns>A <see cref="DefaultValuesGetResponse"/></returns>
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
        public async Task<DefaultValuesGetResponse?> GetAsDefaultValuesGetResponseAsync(Action<RequestConfiguration<DefaultValuesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<DefaultValuesGetResponse> GetAsDefaultValuesGetResponseAsync(Action<RequestConfiguration<DefaultValuesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
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
            return await RequestAdapter.SendAsync<DefaultValuesGetResponse>(requestInfo, DefaultValuesGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets all default value definitions in the given container
        /// </summary>
        /// <returns>A <see cref="DefaultValuesResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="DefinedError">When receiving a 400 status code</exception>
        /// <exception cref="Error">When receiving a 401 status code</exception>
        /// <exception cref="Error">When receiving a 403 status code</exception>
        /// <exception cref="Error">When receiving a 404 status code</exception>
        /// <exception cref="Error">When receiving a 500 status code</exception>
        /// <exception cref="Error">When receiving a 503 status code</exception>
        [Obsolete("This method is obsolete. Use GetAsDefaultValuesGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<DefaultValuesResponse?> GetAsync(Action<RequestConfiguration<DefaultValuesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<DefaultValuesResponse> GetAsync(Action<RequestConfiguration<DefaultValuesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
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
            return await RequestAdapter.SendAsync<DefaultValuesResponse>(requestInfo, DefaultValuesResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new default value definition.
        /// </summary>
        /// <returns>A <see cref="DefaultValue"/></returns>
        /// <param name="body">The request body</param>
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
        public async Task<DefaultValue?> PostAsync(DefaultValueCreate body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<DefaultValue> PostAsync(DefaultValueCreate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"400", DefinedError.CreateFromDiscriminatorValue},
                {"401", Error.CreateFromDiscriminatorValue},
                {"403", Error.CreateFromDiscriminatorValue},
                {"404", Error.CreateFromDiscriminatorValue},
                {"500", Error.CreateFromDiscriminatorValue},
                {"503", Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<DefaultValue>(requestInfo, DefaultValue.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets all default value definitions in the given container
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultValuesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultValuesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create a new default value definition.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(DefaultValueCreate body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(DefaultValueCreate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/v1/projects/{projectId}/default-values", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="DefaultValuesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DefaultValuesRequestBuilder WithUrl(string rawUrl)
        {
            return new DefaultValuesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets all default value definitions in the given container
        /// </summary>
        public class DefaultValuesRequestBuilderGetQueryParameters 
        {
            /// <summary>The type of the item with which the item is associated. Possible values: ``Budget``, ``Contract``, ``Expense``,``PCO``,  ``RFQ``, ``RCO``, ``OCO``,``SCO``,``CostItem``, ``Payment``, ``MainContract``, ``BudgetPayment``.</summary>
            [Obsolete("This property is deprecated, use SourceTypeAsGetSourceTypeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sourceType")]
            public string? SourceType { get; set; }
#nullable restore
#else
            [QueryParameter("sourceType")]
            public string SourceType { get; set; }
#endif
            /// <summary>The type of the item with which the item is associated. Possible values: ``Budget``, ``Contract``, ``Expense``,``PCO``,  ``RFQ``, ``RCO``, ``OCO``,``SCO``,``CostItem``, ``Payment``, ``MainContract``, ``BudgetPayment``.</summary>
            [QueryParameter("sourceType")]
            public GetSourceTypeQueryParameterType? SourceTypeAsGetSourceTypeQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class DefaultValuesRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultValuesRequestBuilderGetQueryParameters> 
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class DefaultValuesRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
