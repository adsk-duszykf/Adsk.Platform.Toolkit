// <auto-generated/>
#pragma warning disable CS0618
using Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Item.Copyto.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Item.Copyto
{
    /// <summary>
    /// Builds and executes requests for operations under \oss\v2\buckets\{bucketKey}\objects\{objectKey}\copyto
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CopytoRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Autodesk.DataManagement.OSS.oss.v2.buckets.item.objects.item.copyto.item collection</summary>
        /// <param name="position">URL-encoded Object key to use as the destination</param>
        /// <returns>A <see cref="global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Item.Copyto.Item.WithNewObjNameItemRequestBuilder"/></returns>
        public global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Item.Copyto.Item.WithNewObjNameItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("newObjName", position);
                return new global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Item.Copyto.Item.WithNewObjNameItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Item.Copyto.CopytoRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CopytoRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/oss/v2/buckets/{bucketKey}/objects/{objectKey}/copyto", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Item.Copyto.CopytoRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CopytoRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/oss/v2/buckets/{bucketKey}/objects/{objectKey}/copyto", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
