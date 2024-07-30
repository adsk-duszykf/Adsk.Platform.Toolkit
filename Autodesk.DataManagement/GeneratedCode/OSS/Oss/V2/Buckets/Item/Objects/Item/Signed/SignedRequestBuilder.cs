// <auto-generated/>
using Autodesk.DataManagement.OSS.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Item.Signed
{
    /// <summary>
    /// Builds and executes requests for operations under \oss\v2\buckets\{bucketKey}\objects\{objectKey}\signed
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class SignedRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Item.Signed.SignedRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SignedRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/oss/v2/buckets/{bucketKey}/objects/{objectKey}/signed{?access*,useCdn*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Item.Signed.SignedRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SignedRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/oss/v2/buckets/{bucketKey}/objects/{objectKey}/signed{?access*,useCdn*}", rawUrl)
        {
        }
        /// <summary>
        /// This endpoint creates a signed URL that can be used to download an object within the specified expiration time. Be aware that if the object the signed URL points to is deleted or expires before the signed URL expires, then the signed URL will no longer be valid. A successful call to this endpoint requires bucket owner access.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.DataManagement.OSS.Models.Create_object_signed"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Autodesk.DataManagement.OSS.Models.Create_object_signed?> PostAsync(global::Autodesk.DataManagement.OSS.Models.Create_signed_resource body, Action<RequestConfiguration<global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Item.Signed.SignedRequestBuilder.SignedRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Autodesk.DataManagement.OSS.Models.Create_object_signed> PostAsync(global::Autodesk.DataManagement.OSS.Models.Create_signed_resource body, Action<RequestConfiguration<global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Item.Signed.SignedRequestBuilder.SignedRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::Autodesk.DataManagement.OSS.Models.Create_object_signed>(requestInfo, global::Autodesk.DataManagement.OSS.Models.Create_object_signed.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// This endpoint creates a signed URL that can be used to download an object within the specified expiration time. Be aware that if the object the signed URL points to is deleted or expires before the signed URL expires, then the signed URL will no longer be valid. A successful call to this endpoint requires bucket owner access.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Autodesk.DataManagement.OSS.Models.Create_signed_resource body, Action<RequestConfiguration<global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Item.Signed.SignedRequestBuilder.SignedRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Autodesk.DataManagement.OSS.Models.Create_signed_resource body, Action<RequestConfiguration<global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Item.Signed.SignedRequestBuilder.SignedRequestBuilderPostQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json, application/vnd.api+json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Item.Signed.SignedRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Item.Signed.SignedRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Item.Signed.SignedRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// This endpoint creates a signed URL that can be used to download an object within the specified expiration time. Be aware that if the object the signed URL points to is deleted or expires before the signed URL expires, then the signed URL will no longer be valid. A successful call to this endpoint requires bucket owner access.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class SignedRequestBuilderPostQueryParameters 
        {
            /// <summary>Access for signed resourceAcceptable values: `read`, `write`, `readwrite`. Default value: `read`</summary>
            [Obsolete("This property is deprecated, use AccessAsPostAccessQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("access")]
            public string? Access { get; set; }
#nullable restore
#else
            [QueryParameter("access")]
            public string Access { get; set; }
#endif
            /// <summary>Access for signed resourceAcceptable values: `read`, `write`, `readwrite`. Default value: `read`</summary>
            [QueryParameter("access")]
            public global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Item.Signed.PostAccessQueryParameterType? AccessAsPostAccessQueryParameterType { get; set; }
            /// <summary>When this is provided, OSS will return a URL that does not point to https://developer.api.autodesk.com.... , but instead points towards an alternate domain. A client can then interact with this public resource exactly as they would for a classic public resource in OSS, i.e. make a GET request to download an object or a PUT request to upload an object.</summary>
            [QueryParameter("useCdn")]
            public bool? UseCdn { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class SignedRequestBuilderPostRequestConfiguration : RequestConfiguration<global::Autodesk.DataManagement.OSS.Oss.V2.Buckets.Item.Objects.Item.Signed.SignedRequestBuilder.SignedRequestBuilderPostQueryParameters>
        {
        }
    }
}
