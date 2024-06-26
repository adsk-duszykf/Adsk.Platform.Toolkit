// <auto-generated/>
using Autodesk.ACC.FileManagement.Projects.Item.Folders.Item.CustomAttributeDefinitions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Autodesk.ACC.FileManagement.Projects.Item.Folders.Item {
    /// <summary>
    /// Builds and executes requests for operations under \projects\{project_id}\folders\{folder_id}
    /// </summary>
    public class WithFolder_ItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The customAttributeDefinitions property</summary>
        public CustomAttributeDefinitionsRequestBuilder CustomAttributeDefinitions
        {
            get => new CustomAttributeDefinitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="WithFolder_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithFolder_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/projects/{project_id}/folders/{folder_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithFolder_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithFolder_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/projects/{project_id}/folders/{folder_id}", rawUrl)
        {
        }
    }
}
