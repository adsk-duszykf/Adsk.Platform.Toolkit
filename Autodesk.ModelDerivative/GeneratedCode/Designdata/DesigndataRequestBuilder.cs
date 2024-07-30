// <auto-generated/>
using Autodesk.ModelDerivative.Designdata.Formats;
using Autodesk.ModelDerivative.Designdata.Item;
using Autodesk.ModelDerivative.Designdata.Job;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Autodesk.ModelDerivative.Designdata
{
    /// <summary>
    /// Builds and executes requests for operations under \designdata
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class DesigndataRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The formats property</summary>
        public global::Autodesk.ModelDerivative.Designdata.Formats.FormatsRequestBuilder Formats
        {
            get => new global::Autodesk.ModelDerivative.Designdata.Formats.FormatsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The job property</summary>
        public global::Autodesk.ModelDerivative.Designdata.Job.JobRequestBuilder Job
        {
            get => new global::Autodesk.ModelDerivative.Designdata.Job.JobRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Autodesk.ModelDerivative.designdata.item collection</summary>
        /// <param name="position">The Base64 (URL Safe) encoded design URN</param>
        /// <returns>A <see cref="global::Autodesk.ModelDerivative.Designdata.Item.WithUrnItemRequestBuilder"/></returns>
        public global::Autodesk.ModelDerivative.Designdata.Item.WithUrnItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("urn", position);
                return new global::Autodesk.ModelDerivative.Designdata.Item.WithUrnItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ModelDerivative.Designdata.DesigndataRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DesigndataRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/designdata", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ModelDerivative.Designdata.DesigndataRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DesigndataRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/designdata", rawUrl)
        {
        }
    }
}
