// <auto-generated/>
using Autodesk.ModelDerivative.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.ModelDerivative.Designdata.Item.Metadata.Item.PropertiesQuery {
    /// <summary>
    /// Builds and executes requests for operations under \designdata\{urn}\metadata\{modelGuid}\properties:query
    /// </summary>
    public class PropertiesQueryRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="PropertiesQueryRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PropertiesQueryRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/designdata/{urn}/metadata/{modelGuid}/properties:query", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="PropertiesQueryRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PropertiesQueryRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/designdata/{urn}/metadata/{modelGuid}/properties:query", rawUrl)
        {
        }
        /// <summary>
        /// Queries the objects in the model view (Viewable) specified by the modelGuid URI parameter and returns the specified properties in a paginated list. You can limit the number of objects to be queried by specifying a filter in the request body.Before you call this endpoint use the `GET {urn}/metadata endpoint`, to obtain the IDs of the model views (Viewables) contained in the design. After that, specify the ID of the model view you want to query as the `modelGuid` URI parameter.**Note**: Before you query a model view for properties, the design must be translated to SVF or SVF2.
        /// </summary>
        /// <returns>A <see cref="SpecificProperties"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="SpecificProperties400Error">When receiving a 400 status code</exception>
        /// <exception cref="SpecificProperties404Error">When receiving a 404 status code</exception>
        /// <exception cref="SpecificProperties429Error">When receiving a 429 status code</exception>
        /// <exception cref="SpecificProperties500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<SpecificProperties?> PostAsync(SpecificPropertiesPayload body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<SpecificProperties> PostAsync(SpecificPropertiesPayload body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"400", SpecificProperties400Error.CreateFromDiscriminatorValue},
                {"404", SpecificProperties404Error.CreateFromDiscriminatorValue},
                {"429", SpecificProperties429Error.CreateFromDiscriminatorValue},
                {"500", SpecificProperties500Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<SpecificProperties>(requestInfo, SpecificProperties.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Queries the objects in the model view (Viewable) specified by the modelGuid URI parameter and returns the specified properties in a paginated list. You can limit the number of objects to be queried by specifying a filter in the request body.Before you call this endpoint use the `GET {urn}/metadata endpoint`, to obtain the IDs of the model views (Viewables) contained in the design. After that, specify the ID of the model view you want to query as the `modelGuid` URI parameter.**Note**: Before you query a model view for properties, the design must be translated to SVF or SVF2.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(SpecificPropertiesPayload body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(SpecificPropertiesPayload body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="PropertiesQueryRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public PropertiesQueryRequestBuilder WithUrl(string rawUrl)
        {
            return new PropertiesQueryRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class PropertiesQueryRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
