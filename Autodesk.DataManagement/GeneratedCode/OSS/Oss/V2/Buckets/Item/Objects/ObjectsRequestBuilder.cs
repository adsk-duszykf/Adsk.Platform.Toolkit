// <auto-generated/>
#pragma warning disable CS0618
using Autodesk.DataManagement.OSS.Models;
using Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Batchcompleteupload;
using Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Batchsigneds3download;
using Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Batchsigneds3upload;
using Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects
{
    /// <summary>
    /// Builds and executes requests for operations under \oss\v2\buckets\{bucketKey}\objects
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ObjectsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The batchcompleteupload property</summary>
        public global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Batchcompleteupload.BatchcompleteuploadRequestBuilder Batchcompleteupload
        {
            get => new global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Batchcompleteupload.BatchcompleteuploadRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The batchsigneds3download property</summary>
        public global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Batchsigneds3download.Batchsigneds3downloadRequestBuilder Batchsigneds3download
        {
            get => new global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Batchsigneds3download.Batchsigneds3downloadRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The batchsigneds3upload property</summary>
        public global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Batchsigneds3upload.Batchsigneds3uploadRequestBuilder Batchsigneds3upload
        {
            get => new global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Batchsigneds3upload.Batchsigneds3uploadRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Autodesk.DataManagement.OSS.oss.v2.buckets.item.objects.item collection</summary>
        /// <param name="position">URL-encoded key of the object to delete.</param>
        /// <returns>A <see cref="global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Item.WithObjectKeyItemRequestBuilder"/></returns>
        public global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Item.WithObjectKeyItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("objectKey", position);
                return new global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Item.WithObjectKeyItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.ObjectsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ObjectsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/oss/v2/buckets/{bucketKey}/objects{?beginsWith*,limit*,startAt*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.ObjectsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ObjectsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/oss/v2/buckets/{bucketKey}/objects{?beginsWith*,limit*,startAt*}", rawUrl)
        {
        }
        /// <summary>
        /// List objects in a bucket. It is only available to the bucket creator.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.DataManagement.OSS.Models.Bucket_objects"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Autodesk.DataManagement.OSS.Models.Bucket_objects?> GetAsync(Action<RequestConfiguration<global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.ObjectsRequestBuilder.ObjectsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Autodesk.DataManagement.OSS.Models.Bucket_objects> GetAsync(Action<RequestConfiguration<global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.ObjectsRequestBuilder.ObjectsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Autodesk.DataManagement.OSS.Models.Bucket_objects>(requestInfo, global::Autodesk.DataManagement.OSS.Models.Bucket_objects.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List objects in a bucket. It is only available to the bucket creator.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.ObjectsRequestBuilder.ObjectsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.ObjectsRequestBuilder.ObjectsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json, application/vnd.api+json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.ObjectsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.ObjectsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.ObjectsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List objects in a bucket. It is only available to the bucket creator.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ObjectsRequestBuilderGetQueryParameters 
        {
            /// <summary>Provides a way to filter the based on object key name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("beginsWith")]
            public string? BeginsWith { get; set; }
#nullable restore
#else
            [QueryParameter("beginsWith")]
            public string BeginsWith { get; set; }
#endif
            /// <summary>Limit to the response size,Acceptable values: 1-100 Default = 10</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>Key to use as an offset to continue pagination. This is typically the last bucket key found in a preceding GET buckets response</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("startAt")]
            public string? StartAt { get; set; }
#nullable restore
#else
            [QueryParameter("startAt")]
            public string StartAt { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ObjectsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.ObjectsRequestBuilder.ObjectsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
