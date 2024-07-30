// <auto-generated/>
using Autodesk.ACC.ModelProperties.V2.Projects;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Autodesk.ACC.ModelProperties.V2
{
    /// <summary>
    /// Builds and executes requests for operations under \v2
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class V2RequestBuilder : BaseRequestBuilder
    {
        /// <summary>The projects property</summary>
        public global::Autodesk.ACC.ModelProperties.V2.Projects.ProjectsRequestBuilder Projects
        {
            get => new global::Autodesk.ACC.ModelProperties.V2.Projects.ProjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.ModelProperties.V2.V2RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public V2RequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.ModelProperties.V2.V2RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public V2RequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2", rawUrl)
        {
        }
    }
}
