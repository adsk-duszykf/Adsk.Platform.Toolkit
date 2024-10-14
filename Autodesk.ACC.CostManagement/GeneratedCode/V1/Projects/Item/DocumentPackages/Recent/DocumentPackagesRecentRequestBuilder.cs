// <auto-generated/>
#pragma warning disable CS0618
using Autodesk.ACC.CostManagement.V1.Projects.Item.DocumentPackages.Recent.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.DocumentPackages.Recent
{
    /// <summary>
    /// Builds and executes requests for operations under \v1\projects\{projectId}\document-packages\:recent
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DocumentPackagesRecentRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Autodesk.ACC.CostManagement.v1.projects.item.documentPackages.Recent.item collection</summary>
        /// <param name="position">The object ID of the item.</param>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.DocumentPackages.Recent.Item.RecentItemRequestBuilder"/></returns>
        public global::Autodesk.ACC.CostManagement.V1.Projects.Item.DocumentPackages.Recent.Item.RecentItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Autodesk.ACC.CostManagement.V1.Projects.Item.DocumentPackages.Recent.Item.RecentItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Autodesk.ACC.CostManagement.v1.projects.item.documentPackages.Recent.item collection</summary>
        /// <param name="position">The object ID of the item.</param>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.DocumentPackages.Recent.Item.RecentItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Autodesk.ACC.CostManagement.V1.Projects.Item.DocumentPackages.Recent.Item.RecentItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("id", position);
                return new global::Autodesk.ACC.CostManagement.V1.Projects.Item.DocumentPackages.Recent.Item.RecentItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.DocumentPackages.Recent.DocumentPackagesRecentRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DocumentPackagesRecentRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/document-packages/:recent", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.DocumentPackages.Recent.DocumentPackagesRecentRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DocumentPackagesRecentRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/document-packages/:recent", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
