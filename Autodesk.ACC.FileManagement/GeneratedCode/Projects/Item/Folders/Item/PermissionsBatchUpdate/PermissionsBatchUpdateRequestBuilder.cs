// <auto-generated/>
#pragma warning disable CS0618
using Autodesk.ACC.FileManagement.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.ACC.FileManagement.Projects.Item.Folders.Item.PermissionsBatchUpdate
{
    /// <summary>
    /// Builds and executes requests for operations under \projects\{project-id}\folders\{folder_id}\permissions:batch-update
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PermissionsBatchUpdateRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.FileManagement.Projects.Item.Folders.Item.PermissionsBatchUpdate.PermissionsBatchUpdateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PermissionsBatchUpdateRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/projects/{project%2Did}/folders/{folder_id}/permissions:batch-update", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.FileManagement.Projects.Item.Folders.Item.PermissionsBatchUpdate.PermissionsBatchUpdateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PermissionsBatchUpdateRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/projects/{project%2Did}/folders/{folder_id}/permissions:batch-update", rawUrl)
        {
        }
        /// <summary>
        /// Update permissions on a folder
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.FileManagement.Models.PermissionBatchCreateResponse"/></returns>
        /// <param name="body">List of subjects and their respective permissions</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Autodesk.ACC.FileManagement.Models.PermissionBatchCreateResponse?> PostAsync(List<global::Autodesk.ACC.FileManagement.Models.PermissionBatchCreateRequest> body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Autodesk.ACC.FileManagement.Models.PermissionBatchCreateResponse> PostAsync(List<global::Autodesk.ACC.FileManagement.Models.PermissionBatchCreateRequest> body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::Autodesk.ACC.FileManagement.Models.PermissionBatchCreateResponse>(requestInfo, global::Autodesk.ACC.FileManagement.Models.PermissionBatchCreateResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update permissions on a folder
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">List of subjects and their respective permissions</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(List<global::Autodesk.ACC.FileManagement.Models.PermissionBatchCreateRequest> body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(List<global::Autodesk.ACC.FileManagement.Models.PermissionBatchCreateRequest> body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Autodesk.ACC.FileManagement.Projects.Item.Folders.Item.PermissionsBatchUpdate.PermissionsBatchUpdateRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Autodesk.ACC.FileManagement.Projects.Item.Folders.Item.PermissionsBatchUpdate.PermissionsBatchUpdateRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Autodesk.ACC.FileManagement.Projects.Item.Folders.Item.PermissionsBatchUpdate.PermissionsBatchUpdateRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class PermissionsBatchUpdateRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
