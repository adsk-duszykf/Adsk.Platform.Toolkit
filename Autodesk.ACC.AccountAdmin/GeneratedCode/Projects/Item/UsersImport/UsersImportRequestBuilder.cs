// <auto-generated/>
#pragma warning disable CS0618
using Autodesk.ACC.AccountAdmin.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.ACC.AccountAdmin.Projects.Item.UsersImport
{
    /// <summary>
    /// Builds and executes requests for operations under \projects\{projectId}\users:import
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UsersImportRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.AccountAdmin.Projects.Item.UsersImport.UsersImportRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersImportRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/projects/{projectId}/users:import", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.AccountAdmin.Projects.Item.UsersImport.UsersImportRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersImportRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/projects/{projectId}/users:import", rawUrl)
        {
        }
        /// <summary>
        /// Private Use - Add multiple users to the project at once.  Can add up to 200 users per request.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.AccountAdmin.Projects.Item.UsersImport.UsersImportPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.ValidationError">When receiving a 400 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.UsersImport401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 403 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 404 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.ValidationError">When receiving a 409 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 410 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 412 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 415 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 500 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 503 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Autodesk.ACC.AccountAdmin.Projects.Item.UsersImport.UsersImportPostResponse?> PostAsUsersImportPostResponseAsync(global::Autodesk.ACC.AccountAdmin.Projects.Item.UsersImport.UsersImportPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Autodesk.ACC.AccountAdmin.Projects.Item.UsersImport.UsersImportPostResponse> PostAsUsersImportPostResponseAsync(global::Autodesk.ACC.AccountAdmin.Projects.Item.UsersImport.UsersImportPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Autodesk.ACC.AccountAdmin.Models.ValidationError.CreateFromDiscriminatorValue },
                { "401", global::Autodesk.ACC.AccountAdmin.Models.UsersImport401Error.CreateFromDiscriminatorValue },
                { "403", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "404", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "409", global::Autodesk.ACC.AccountAdmin.Models.ValidationError.CreateFromDiscriminatorValue },
                { "410", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "412", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "415", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "500", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "503", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Autodesk.ACC.AccountAdmin.Projects.Item.UsersImport.UsersImportPostResponse>(requestInfo, global::Autodesk.ACC.AccountAdmin.Projects.Item.UsersImport.UsersImportPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Private Use - Add multiple users to the project at once.  Can add up to 200 users per request.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.AccountAdmin.Projects.Item.UsersImport.UsersImportResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.ValidationError">When receiving a 400 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.UsersImport401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 403 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 404 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.ValidationError">When receiving a 409 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 410 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 412 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 415 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 500 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 503 status code</exception>
        [Obsolete("This method is obsolete. Use PostAsUsersImportPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Autodesk.ACC.AccountAdmin.Projects.Item.UsersImport.UsersImportResponse?> PostAsync(global::Autodesk.ACC.AccountAdmin.Projects.Item.UsersImport.UsersImportPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Autodesk.ACC.AccountAdmin.Projects.Item.UsersImport.UsersImportResponse> PostAsync(global::Autodesk.ACC.AccountAdmin.Projects.Item.UsersImport.UsersImportPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Autodesk.ACC.AccountAdmin.Models.ValidationError.CreateFromDiscriminatorValue },
                { "401", global::Autodesk.ACC.AccountAdmin.Models.UsersImport401Error.CreateFromDiscriminatorValue },
                { "403", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "404", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "409", global::Autodesk.ACC.AccountAdmin.Models.ValidationError.CreateFromDiscriminatorValue },
                { "410", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "412", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "415", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "500", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "503", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Autodesk.ACC.AccountAdmin.Projects.Item.UsersImport.UsersImportResponse>(requestInfo, global::Autodesk.ACC.AccountAdmin.Projects.Item.UsersImport.UsersImportResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Private Use - Add multiple users to the project at once.  Can add up to 200 users per request.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Autodesk.ACC.AccountAdmin.Projects.Item.UsersImport.UsersImportPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Autodesk.ACC.AccountAdmin.Projects.Item.UsersImport.UsersImportPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.AccountAdmin.Projects.Item.UsersImport.UsersImportRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Autodesk.ACC.AccountAdmin.Projects.Item.UsersImport.UsersImportRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Autodesk.ACC.AccountAdmin.Projects.Item.UsersImport.UsersImportRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class UsersImportRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
