// <auto-generated/>
using Autodesk.ACC.ModelProperties.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.ACC.ModelProperties.V2.Projects.Item.CustomProperties.Lineages.Item.Values
{
    /// <summary>
    /// Builds and executes requests for operations under \v2\projects\{projectId}\custom-properties\lineages\{lineageUrn}\values
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class ValuesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.ModelProperties.V2.Projects.Item.CustomProperties.Lineages.Item.Values.ValuesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ValuesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/projects/{projectId}/custom-properties/lineages/{lineageUrn}/values", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.ModelProperties.V2.Projects.Item.CustomProperties.Lineages.Item.Values.ValuesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ValuesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/projects/{projectId}/custom-properties/lineages/{lineageUrn}/values", rawUrl)
        {
        }
        /// <summary>
        /// Set Custom Property values for specified Design Entities.The success case returns 200 if at least some of the writes were successful. The response bodymust also be checked to see if any partial failures occurred.NOTE: There is no &quot;get&quot; endpoint to read custom property values. Values For Custom Propertieswill be combined with the model properties into an index. Therefore, the user can query andfilter any Custom Properties using the existing Model Properties API query endpoints.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.ModelProperties.Models.BulkCustomPropertiesUpdateResult"/></returns>
        /// <param name="body">List of specified Custom Property values to set for a list of Design Elements.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Autodesk.ACC.ModelProperties.Models.ResourceError">When receiving a 401 status code</exception>
        /// <exception cref="global::Autodesk.ACC.ModelProperties.Models.ResourceError">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Autodesk.ACC.ModelProperties.Models.BulkCustomPropertiesUpdateResult?> PatchAsync(List<global::Autodesk.ACC.ModelProperties.Models.CustomPropertyChangeSet> body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Autodesk.ACC.ModelProperties.Models.BulkCustomPropertiesUpdateResult> PatchAsync(List<global::Autodesk.ACC.ModelProperties.Models.CustomPropertyChangeSet> body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::Autodesk.ACC.ModelProperties.Models.ResourceError.CreateFromDiscriminatorValue },
                { "404", global::Autodesk.ACC.ModelProperties.Models.ResourceError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Autodesk.ACC.ModelProperties.Models.BulkCustomPropertiesUpdateResult>(requestInfo, global::Autodesk.ACC.ModelProperties.Models.BulkCustomPropertiesUpdateResult.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Set Custom Property values for specified Design Entities.The success case returns 200 if at least some of the writes were successful. The response bodymust also be checked to see if any partial failures occurred.NOTE: There is no &quot;get&quot; endpoint to read custom property values. Values For Custom Propertieswill be combined with the model properties into an index. Therefore, the user can query andfilter any Custom Properties using the existing Model Properties API query endpoints.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">List of specified Custom Property values to set for a list of Design Elements.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(List<global::Autodesk.ACC.ModelProperties.Models.CustomPropertyChangeSet> body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(List<global::Autodesk.ACC.ModelProperties.Models.CustomPropertyChangeSet> body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.ModelProperties.V2.Projects.Item.CustomProperties.Lineages.Item.Values.ValuesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Autodesk.ACC.ModelProperties.V2.Projects.Item.CustomProperties.Lineages.Item.Values.ValuesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Autodesk.ACC.ModelProperties.V2.Projects.Item.CustomProperties.Lineages.Item.Values.ValuesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class ValuesRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
