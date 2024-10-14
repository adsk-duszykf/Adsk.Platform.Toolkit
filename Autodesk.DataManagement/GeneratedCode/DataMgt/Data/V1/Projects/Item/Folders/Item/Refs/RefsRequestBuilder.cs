// <auto-generated/>
#pragma warning disable CS0618
using Autodesk.DataManagement.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.DataManagement.Data.V1.Projects.Item.Folders.Item.Refs
{
    /// <summary>
    /// Builds and executes requests for operations under \data\v1\projects\{project_id}\folders\{folder_id}\refs
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RefsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.DataManagement.Data.V1.Projects.Item.Folders.Item.Refs.RefsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RefsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/data/v1/projects/{project_id}/folders/{folder_id}/refs{?filter%5Bextension%2Etype%5D*,filter%5Bid%5D*,filter%5Btype%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.DataManagement.Data.V1.Projects.Item.Folders.Item.Refs.RefsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RefsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/data/v1/projects/{project_id}/folders/{folder_id}/refs{?filter%5Bextension%2Etype%5D*,filter%5Bid%5D*,filter%5Btype%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns the resources (items, folders, and versions) that have a custom relationship with the given folder_id. Custom relationships can be established between a folder and other resources within the data domain service (folders, items, and versions).Notes:Each relationship is defined by the id of the object at the other end of the relationship, together with type, attributes, and relationships links.Callers will typically use a filter parameter to restrict the response to the custom relationship types (filter[meta.refType]) they are interested in.The response body will have an included array which contains the ref resources that are involved in the relationship, which is essentially the GET projects/:project_id/folders/:folder_id/relationships/refs endpoint.New! Autodesk Construction Cloud platform (ACC). Note that this endpoint is compatible with ACC projects. For more information about the Autodesk Construction Cloud APIs, see the Autodesk Construction Cloud documentation.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.DataManagement.Models.FolderRefs"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Autodesk.DataManagement.Models.FolderRefs400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::Autodesk.DataManagement.Models.FolderRefs403Error">When receiving a 403 status code</exception>
        /// <exception cref="global::Autodesk.DataManagement.Models.FolderRefs404Error">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Autodesk.DataManagement.Models.FolderRefs?> GetAsync(Action<RequestConfiguration<global::Autodesk.DataManagement.Data.V1.Projects.Item.Folders.Item.Refs.RefsRequestBuilder.RefsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Autodesk.DataManagement.Models.FolderRefs> GetAsync(Action<RequestConfiguration<global::Autodesk.DataManagement.Data.V1.Projects.Item.Folders.Item.Refs.RefsRequestBuilder.RefsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Autodesk.DataManagement.Models.FolderRefs400Error.CreateFromDiscriminatorValue },
                { "403", global::Autodesk.DataManagement.Models.FolderRefs403Error.CreateFromDiscriminatorValue },
                { "404", global::Autodesk.DataManagement.Models.FolderRefs404Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Autodesk.DataManagement.Models.FolderRefs>(requestInfo, global::Autodesk.DataManagement.Models.FolderRefs.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns the resources (items, folders, and versions) that have a custom relationship with the given folder_id. Custom relationships can be established between a folder and other resources within the data domain service (folders, items, and versions).Notes:Each relationship is defined by the id of the object at the other end of the relationship, together with type, attributes, and relationships links.Callers will typically use a filter parameter to restrict the response to the custom relationship types (filter[meta.refType]) they are interested in.The response body will have an included array which contains the ref resources that are involved in the relationship, which is essentially the GET projects/:project_id/folders/:folder_id/relationships/refs endpoint.New! Autodesk Construction Cloud platform (ACC). Note that this endpoint is compatible with ACC projects. For more information about the Autodesk Construction Cloud APIs, see the Autodesk Construction Cloud documentation.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Autodesk.DataManagement.Data.V1.Projects.Item.Folders.Item.Refs.RefsRequestBuilder.RefsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Autodesk.DataManagement.Data.V1.Projects.Item.Folders.Item.Refs.RefsRequestBuilder.RefsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Autodesk.DataManagement.Data.V1.Projects.Item.Folders.Item.Refs.RefsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Autodesk.DataManagement.Data.V1.Projects.Item.Folders.Item.Refs.RefsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Autodesk.DataManagement.Data.V1.Projects.Item.Folders.Item.Refs.RefsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns the resources (items, folders, and versions) that have a custom relationship with the given folder_id. Custom relationships can be established between a folder and other resources within the data domain service (folders, items, and versions).Notes:Each relationship is defined by the id of the object at the other end of the relationship, together with type, attributes, and relationships links.Callers will typically use a filter parameter to restrict the response to the custom relationship types (filter[meta.refType]) they are interested in.The response body will have an included array which contains the ref resources that are involved in the relationship, which is essentially the GET projects/:project_id/folders/:folder_id/relationships/refs endpoint.New! Autodesk Construction Cloud platform (ACC). Note that this endpoint is compatible with ACC projects. For more information about the Autodesk Construction Cloud APIs, see the Autodesk Construction Cloud documentation.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class RefsRequestBuilderGetQueryParameters 
        {
            /// <summary>Filter by the extension type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bextension%2Etype%5D")]
            public string[]? FilterextensionType { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bextension%2Etype%5D")]
            public string[] FilterextensionType { get; set; }
#endif
            /// <summary>Filter by the id of the ref target.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bid%5D")]
            public string? Filterid { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bid%5D")]
            public string Filterid { get; set; }
#endif
            /// <summary>Filter by the type of the ref target. Supported values include folders, items, and versions</summary>
            [Obsolete("This property is deprecated, use FiltertypeAsGetFilterTypeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Btype%5D")]
            public string[]? Filtertype { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Btype%5D")]
            public string[] Filtertype { get; set; }
#endif
            /// <summary>Filter by the type of the ref target. Supported values include folders, items, and versions</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Btype%5D")]
            public global::Autodesk.DataManagement.Data.V1.Projects.Item.Folders.Item.Refs.GetFilterTypeQueryParameterType[]? FiltertypeAsGetFilterTypeQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Btype%5D")]
            public global::Autodesk.DataManagement.Data.V1.Projects.Item.Folders.Item.Refs.GetFilterTypeQueryParameterType[] FiltertypeAsGetFilterTypeQueryParameterType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class RefsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Autodesk.DataManagement.Data.V1.Projects.Item.Folders.Item.Refs.RefsRequestBuilder.RefsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
