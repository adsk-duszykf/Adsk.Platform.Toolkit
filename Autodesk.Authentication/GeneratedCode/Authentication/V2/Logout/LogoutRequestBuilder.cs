// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.Authentication.Authentication.V2.Logout
{
    /// <summary>
    /// Builds and executes requests for operations under \authentication\v2\logout
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class LogoutRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.Authentication.Authentication.V2.Logout.LogoutRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LogoutRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/authentication/v2/logout{?post_logout_redirect_uri*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.Authentication.Authentication.V2.Logout.LogoutRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LogoutRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/authentication/v2/logout{?post_logout_redirect_uri*}", rawUrl)
        {
        }
        /// <summary>
        /// This API endpoint logs a user out by removing their user browser session and redirects the user to the Autodesk login page.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task GetAsync(Action<RequestConfiguration<global::Autodesk.Authentication.Authentication.V2.Logout.LogoutRequestBuilder.LogoutRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task GetAsync(Action<RequestConfiguration<global::Autodesk.Authentication.Authentication.V2.Logout.LogoutRequestBuilder.LogoutRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// This API endpoint logs a user out by removing their user browser session and redirects the user to the Autodesk login page.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Autodesk.Authentication.Authentication.V2.Logout.LogoutRequestBuilder.LogoutRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Autodesk.Authentication.Authentication.V2.Logout.LogoutRequestBuilder.LogoutRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.Authentication.Authentication.V2.Logout.LogoutRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Autodesk.Authentication.Authentication.V2.Logout.LogoutRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Autodesk.Authentication.Authentication.V2.Logout.LogoutRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// This API endpoint logs a user out by removing their user browser session and redirects the user to the Autodesk login page.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class LogoutRequestBuilderGetQueryParameters 
        {
            /// <summary>Location to redirect once the logout is performed. Note that the provided domain host should be in the allowed list. Contact #oxygen slack channel for more details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("post_logout_redirect_uri")]
            public string? PostLogoutRedirectUri { get; set; }
#nullable restore
#else
            [QueryParameter("post_logout_redirect_uri")]
            public string PostLogoutRedirectUri { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class LogoutRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Autodesk.Authentication.Authentication.V2.Logout.LogoutRequestBuilder.LogoutRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
