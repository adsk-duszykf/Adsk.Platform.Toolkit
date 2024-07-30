// <auto-generated/>
using Autodesk.DataManagement.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.DataManagement.Project.V1.Hubs.Item.Projects.Item.TopFolders
{
    /// <summary>
    /// Builds and executes requests for operations under \project\v1\hubs\{hub_id}\projects\{project_id}\topFolders
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class TopFoldersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.DataManagement.Project.V1.Hubs.Item.Projects.Item.TopFolders.TopFoldersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TopFoldersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/project/v1/hubs/{hub_id}/projects/{project_id}/topFolders{?excludeDeleted*,projectFilesOnly*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.DataManagement.Project.V1.Hubs.Item.Projects.Item.TopFolders.TopFoldersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TopFoldersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/project/v1/hubs/{hub_id}/projects/{project_id}/topFolders{?excludeDeleted*,projectFilesOnly*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns the details of the highest level folders the user has access to for a given project. The user must have at least read access to the folders.If the user is a Project Admin, it returns all top level folders in the project. Otherwise, it returns all the highest level folders in the folder hierarchy the user has access to.Note that when users have access to a folder, access is automatically granted to its subfolders.New! Autodesk Construction Cloud platform (ACC). Note that this endpoint is compatible with ACC projects. For more information about the Autodesk Construction Cloud APIs, see the Autodesk Construction Cloud documentation.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.DataManagement.Models.TopFolders"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Autodesk.DataManagement.Models.TopFolders400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::Autodesk.DataManagement.Models.TopFolders403Error">When receiving a 403 status code</exception>
        /// <exception cref="global::Autodesk.DataManagement.Models.TopFolders404Error">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Autodesk.DataManagement.Models.TopFolders?> GetAsync(Action<RequestConfiguration<global::Autodesk.DataManagement.Project.V1.Hubs.Item.Projects.Item.TopFolders.TopFoldersRequestBuilder.TopFoldersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Autodesk.DataManagement.Models.TopFolders> GetAsync(Action<RequestConfiguration<global::Autodesk.DataManagement.Project.V1.Hubs.Item.Projects.Item.TopFolders.TopFoldersRequestBuilder.TopFoldersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Autodesk.DataManagement.Models.TopFolders400Error.CreateFromDiscriminatorValue },
                { "403", global::Autodesk.DataManagement.Models.TopFolders403Error.CreateFromDiscriminatorValue },
                { "404", global::Autodesk.DataManagement.Models.TopFolders404Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Autodesk.DataManagement.Models.TopFolders>(requestInfo, global::Autodesk.DataManagement.Models.TopFolders.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns the details of the highest level folders the user has access to for a given project. The user must have at least read access to the folders.If the user is a Project Admin, it returns all top level folders in the project. Otherwise, it returns all the highest level folders in the folder hierarchy the user has access to.Note that when users have access to a folder, access is automatically granted to its subfolders.New! Autodesk Construction Cloud platform (ACC). Note that this endpoint is compatible with ACC projects. For more information about the Autodesk Construction Cloud APIs, see the Autodesk Construction Cloud documentation.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Autodesk.DataManagement.Project.V1.Hubs.Item.Projects.Item.TopFolders.TopFoldersRequestBuilder.TopFoldersRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Autodesk.DataManagement.Project.V1.Hubs.Item.Projects.Item.TopFolders.TopFoldersRequestBuilder.TopFoldersRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Autodesk.DataManagement.Project.V1.Hubs.Item.Projects.Item.TopFolders.TopFoldersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Autodesk.DataManagement.Project.V1.Hubs.Item.Projects.Item.TopFolders.TopFoldersRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Autodesk.DataManagement.Project.V1.Hubs.Item.Projects.Item.TopFolders.TopFoldersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns the details of the highest level folders the user has access to for a given project. The user must have at least read access to the folders.If the user is a Project Admin, it returns all top level folders in the project. Otherwise, it returns all the highest level folders in the folder hierarchy the user has access to.Note that when users have access to a folder, access is automatically granted to its subfolders.New! Autodesk Construction Cloud platform (ACC). Note that this endpoint is compatible with ACC projects. For more information about the Autodesk Construction Cloud APIs, see the Autodesk Construction Cloud documentation.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class TopFoldersRequestBuilderGetQueryParameters 
        {
            /// <summary>Specify whether to exclude deleted folders in response for BIM 360 Docs projects when user context is provided. true: response will exclude deleted folders for BIM 360 Docs projects.  false (default): response will not exclude deleted folders for BIM 360 Docs projects.</summary>
            [QueryParameter("excludeDeleted")]
            public bool? ExcludeDeleted { get; set; }
            /// <summary>Specify whether only Project Files folder or its subfolders will be returned for BIM 360 Docs projects when user context is provided. true: response will include only Project Files folder and its subfolders for BIM 360 Docs projects.  false (default): response will include all available folders.</summary>
            [QueryParameter("projectFilesOnly")]
            public bool? ProjectFilesOnly { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class TopFoldersRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Autodesk.DataManagement.Project.V1.Hubs.Item.Projects.Item.TopFolders.TopFoldersRequestBuilder.TopFoldersRequestBuilderGetQueryParameters>
        {
        }
    }
}
