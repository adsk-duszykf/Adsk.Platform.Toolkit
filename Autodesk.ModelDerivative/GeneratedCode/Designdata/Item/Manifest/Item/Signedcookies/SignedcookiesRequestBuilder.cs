// <auto-generated/>
#pragma warning disable CS0618
using Autodesk.ModelDerivative.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.ModelDerivative.Designdata.Item.Manifest.Item.Signedcookies
{
    /// <summary>
    /// Builds and executes requests for operations under \designdata\{urn}\manifest\{derivativeUrn}\signedcookies
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SignedcookiesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ModelDerivative.Designdata.Item.Manifest.Item.Signedcookies.SignedcookiesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SignedcookiesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/designdata/{urn}/manifest/{derivativeUrn}/signedcookies{?minutes%2Dexpiration*,response%2Dcontent%2Ddisposition*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ModelDerivative.Designdata.Item.Manifest.Item.Signedcookies.SignedcookiesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SignedcookiesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/designdata/{urn}/manifest/{derivativeUrn}/signedcookies{?minutes%2Dexpiration*,response%2Dcontent%2Ddisposition*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns a download URL and a set of signed cookies, which lets you securely download the derivative specified by the `derivativeUrn` URI parameter. The signed cookies have a lifetime of 6 hours. Although you cannot use range headers for this endpoint, you can use range headers for the returned download URL to download the derivative in chunks, in parallel.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ModelDerivative.Designdata.Item.Manifest.Item.Signedcookies.SignedcookiesGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Autodesk.ModelDerivative.Models.Signedcookies400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::Autodesk.ModelDerivative.Models.Signedcookies401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::Autodesk.ModelDerivative.Models.Signedcookies403Error">When receiving a 403 status code</exception>
        /// <exception cref="global::Autodesk.ModelDerivative.Models.Signedcookies404Error">When receiving a 404 status code</exception>
        /// <exception cref="global::Autodesk.ModelDerivative.Models.Signedcookies500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Autodesk.ModelDerivative.Designdata.Item.Manifest.Item.Signedcookies.SignedcookiesGetResponse?> GetAsSignedcookiesGetResponseAsync(Action<RequestConfiguration<global::Autodesk.ModelDerivative.Designdata.Item.Manifest.Item.Signedcookies.SignedcookiesRequestBuilder.SignedcookiesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Autodesk.ModelDerivative.Designdata.Item.Manifest.Item.Signedcookies.SignedcookiesGetResponse> GetAsSignedcookiesGetResponseAsync(Action<RequestConfiguration<global::Autodesk.ModelDerivative.Designdata.Item.Manifest.Item.Signedcookies.SignedcookiesRequestBuilder.SignedcookiesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Autodesk.ModelDerivative.Models.Signedcookies400Error.CreateFromDiscriminatorValue },
                { "401", global::Autodesk.ModelDerivative.Models.Signedcookies401Error.CreateFromDiscriminatorValue },
                { "403", global::Autodesk.ModelDerivative.Models.Signedcookies403Error.CreateFromDiscriminatorValue },
                { "404", global::Autodesk.ModelDerivative.Models.Signedcookies404Error.CreateFromDiscriminatorValue },
                { "500", global::Autodesk.ModelDerivative.Models.Signedcookies500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Autodesk.ModelDerivative.Designdata.Item.Manifest.Item.Signedcookies.SignedcookiesGetResponse>(requestInfo, global::Autodesk.ModelDerivative.Designdata.Item.Manifest.Item.Signedcookies.SignedcookiesGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a download URL and a set of signed cookies, which lets you securely download the derivative specified by the `derivativeUrn` URI parameter. The signed cookies have a lifetime of 6 hours. Although you cannot use range headers for this endpoint, you can use range headers for the returned download URL to download the derivative in chunks, in parallel.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ModelDerivative.Designdata.Item.Manifest.Item.Signedcookies.SignedcookiesResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Autodesk.ModelDerivative.Models.Signedcookies400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::Autodesk.ModelDerivative.Models.Signedcookies401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::Autodesk.ModelDerivative.Models.Signedcookies403Error">When receiving a 403 status code</exception>
        /// <exception cref="global::Autodesk.ModelDerivative.Models.Signedcookies404Error">When receiving a 404 status code</exception>
        /// <exception cref="global::Autodesk.ModelDerivative.Models.Signedcookies500Error">When receiving a 500 status code</exception>
        [Obsolete("This method is obsolete. Use GetAsSignedcookiesGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Autodesk.ModelDerivative.Designdata.Item.Manifest.Item.Signedcookies.SignedcookiesResponse?> GetAsync(Action<RequestConfiguration<global::Autodesk.ModelDerivative.Designdata.Item.Manifest.Item.Signedcookies.SignedcookiesRequestBuilder.SignedcookiesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Autodesk.ModelDerivative.Designdata.Item.Manifest.Item.Signedcookies.SignedcookiesResponse> GetAsync(Action<RequestConfiguration<global::Autodesk.ModelDerivative.Designdata.Item.Manifest.Item.Signedcookies.SignedcookiesRequestBuilder.SignedcookiesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Autodesk.ModelDerivative.Models.Signedcookies400Error.CreateFromDiscriminatorValue },
                { "401", global::Autodesk.ModelDerivative.Models.Signedcookies401Error.CreateFromDiscriminatorValue },
                { "403", global::Autodesk.ModelDerivative.Models.Signedcookies403Error.CreateFromDiscriminatorValue },
                { "404", global::Autodesk.ModelDerivative.Models.Signedcookies404Error.CreateFromDiscriminatorValue },
                { "500", global::Autodesk.ModelDerivative.Models.Signedcookies500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Autodesk.ModelDerivative.Designdata.Item.Manifest.Item.Signedcookies.SignedcookiesResponse>(requestInfo, global::Autodesk.ModelDerivative.Designdata.Item.Manifest.Item.Signedcookies.SignedcookiesResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a download URL and a set of signed cookies, which lets you securely download the derivative specified by the `derivativeUrn` URI parameter. The signed cookies have a lifetime of 6 hours. Although you cannot use range headers for this endpoint, you can use range headers for the returned download URL to download the derivative in chunks, in parallel.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Autodesk.ModelDerivative.Designdata.Item.Manifest.Item.Signedcookies.SignedcookiesRequestBuilder.SignedcookiesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Autodesk.ModelDerivative.Designdata.Item.Manifest.Item.Signedcookies.SignedcookiesRequestBuilder.SignedcookiesRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Autodesk.ModelDerivative.Designdata.Item.Manifest.Item.Signedcookies.SignedcookiesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Autodesk.ModelDerivative.Designdata.Item.Manifest.Item.Signedcookies.SignedcookiesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Autodesk.ModelDerivative.Designdata.Item.Manifest.Item.Signedcookies.SignedcookiesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a download URL and a set of signed cookies, which lets you securely download the derivative specified by the `derivativeUrn` URI parameter. The signed cookies have a lifetime of 6 hours. Although you cannot use range headers for this endpoint, you can use range headers for the returned download URL to download the derivative in chunks, in parallel.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class SignedcookiesRequestBuilderGetQueryParameters 
        {
            /// <summary>Specifies how many minutes the signed cookies should remain valid. Default value is 360 minutes. The value you specify must be lower than the default value for this parameter. If you specify a value greater than the default value, the Model Derivative service will return an error with an HTTP status code of 400.</summary>
            [QueryParameter("minutes%2Dexpiration")]
            public int? MinutesExpiration { get; set; }
            /// <summary>The value that must be returned with the download URL as the response-content-disposition query string parameter. Must begin with attachment. This value defaults to the default value corresponding to the derivative/file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("response%2Dcontent%2Ddisposition")]
            public string? ResponseContentDisposition { get; set; }
#nullable restore
#else
            [QueryParameter("response%2Dcontent%2Ddisposition")]
            public string ResponseContentDisposition { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class SignedcookiesRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Autodesk.ModelDerivative.Designdata.Item.Manifest.Item.Signedcookies.SignedcookiesRequestBuilder.SignedcookiesRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
