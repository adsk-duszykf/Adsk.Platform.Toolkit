// <auto-generated/>
using Autodesk.ModelDerivative.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.ModelDerivative.Designdata.Formats
{
    /// <summary>
    /// Builds and executes requests for operations under \designdata\formats
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class FormatsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ModelDerivative.Designdata.Formats.FormatsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FormatsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/designdata/formats", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ModelDerivative.Designdata.Formats.FormatsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FormatsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/designdata/formats", rawUrl)
        {
        }
        /// <summary>
        /// Returns an up-to-date list of supported translations. You can use to this list to find out what derivatives are supported by each source file type. You can set options to return the list of supported translations only if they have been updated since a specified date.See the `Supported Translation Formats table &lt;/en/docs/model-derivative/v2/overview/supported-translations&gt;`_ for more details about supported translations.**Note:** We keep adding new file formats to our supported translations list, constantly.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ModelDerivative.Models.Formats"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Autodesk.ModelDerivative.Models.Formats400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::Autodesk.ModelDerivative.Models.Formats401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::Autodesk.ModelDerivative.Models.Formats403Error">When receiving a 403 status code</exception>
        /// <exception cref="global::Autodesk.ModelDerivative.Models.Formats404Error">When receiving a 404 status code</exception>
        /// <exception cref="global::Autodesk.ModelDerivative.Models.Formats500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Autodesk.ModelDerivative.Models.Formats?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Autodesk.ModelDerivative.Models.Formats> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Autodesk.ModelDerivative.Models.Formats400Error.CreateFromDiscriminatorValue },
                { "401", global::Autodesk.ModelDerivative.Models.Formats401Error.CreateFromDiscriminatorValue },
                { "403", global::Autodesk.ModelDerivative.Models.Formats403Error.CreateFromDiscriminatorValue },
                { "404", global::Autodesk.ModelDerivative.Models.Formats404Error.CreateFromDiscriminatorValue },
                { "500", global::Autodesk.ModelDerivative.Models.Formats500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Autodesk.ModelDerivative.Models.Formats>(requestInfo, global::Autodesk.ModelDerivative.Models.Formats.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns an up-to-date list of supported translations. You can use to this list to find out what derivatives are supported by each source file type. You can set options to return the list of supported translations only if they have been updated since a specified date.See the `Supported Translation Formats table &lt;/en/docs/model-derivative/v2/overview/supported-translations&gt;`_ for more details about supported translations.**Note:** We keep adding new file formats to our supported translations list, constantly.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Autodesk.ModelDerivative.Designdata.Formats.FormatsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Autodesk.ModelDerivative.Designdata.Formats.FormatsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Autodesk.ModelDerivative.Designdata.Formats.FormatsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class FormatsRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
