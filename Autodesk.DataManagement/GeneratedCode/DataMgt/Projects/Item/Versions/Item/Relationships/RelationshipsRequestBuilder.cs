// <auto-generated/>
using Autodesk.DataManagement.Projects.Item.Versions.Item.Relationships.Links;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Autodesk.DataManagement.Projects.Item.Versions.Item.Relationships
{
    /// <summary>
    /// Builds and executes requests for operations under \projects\{project_id}\versions\{version_id}\relationships
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class RelationshipsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The links property</summary>
        public global::Autodesk.DataManagement.Projects.Item.Versions.Item.Relationships.Links.LinksRequestBuilder Links
        {
            get => new global::Autodesk.DataManagement.Projects.Item.Versions.Item.Relationships.Links.LinksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.DataManagement.Projects.Item.Versions.Item.Relationships.RelationshipsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RelationshipsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/projects/{project_id}/versions/{version_id}/relationships", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.DataManagement.Projects.Item.Versions.Item.Relationships.RelationshipsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RelationshipsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/projects/{project_id}/versions/{version_id}/relationships", rawUrl)
        {
        }
    }
}
