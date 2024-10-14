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
namespace Autodesk.ACC.AccountAdmin.Projects.Item.Users.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \projects\{projectId}\users\{userId}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithUserItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.AccountAdmin.Projects.Item.Users.Item.WithUserItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithUserItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/projects/{projectId}/users/{userId}{?fields*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.AccountAdmin.Projects.Item.Users.Item.WithUserItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithUserItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/projects/{projectId}/users/{userId}{?fields*}", rawUrl)
        {
        }
        /// <summary>
        /// Private Use - Remove a user from the project.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.ValidationError">When receiving a 400 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 401 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 403 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 404 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 410 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 415 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 500 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 503 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Autodesk.ACC.AccountAdmin.Models.ValidationError.CreateFromDiscriminatorValue },
                { "401", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "403", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "404", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "410", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "415", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "500", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "503", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieves detailed information about a single user in a project.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.AccountAdmin.Models.ProjectUserResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.ValidationError">When receiving a 400 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 401 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 403 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 404 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 406 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.ValidationError">When receiving a 409 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 410 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 500 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 503 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Autodesk.ACC.AccountAdmin.Models.ProjectUserResponse?> GetAsync(Action<RequestConfiguration<global::Autodesk.ACC.AccountAdmin.Projects.Item.Users.Item.WithUserItemRequestBuilder.WithUserItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Autodesk.ACC.AccountAdmin.Models.ProjectUserResponse> GetAsync(Action<RequestConfiguration<global::Autodesk.ACC.AccountAdmin.Projects.Item.Users.Item.WithUserItemRequestBuilder.WithUserItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Autodesk.ACC.AccountAdmin.Models.ValidationError.CreateFromDiscriminatorValue },
                { "401", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "403", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "404", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "406", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "409", global::Autodesk.ACC.AccountAdmin.Models.ValidationError.CreateFromDiscriminatorValue },
                { "410", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "500", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "503", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Autodesk.ACC.AccountAdmin.Models.ProjectUserResponse>(requestInfo, global::Autodesk.ACC.AccountAdmin.Models.ProjectUserResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Private Use - Update the user in a project.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.AccountAdmin.Projects.Item.Users.Item.ProjectUserResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.ValidationError">When receiving a 400 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 401 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 403 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 404 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 410 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 415 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 500 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 503 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Autodesk.ACC.AccountAdmin.Projects.Item.Users.Item.ProjectUserResponse?> PatchAsync(global::Autodesk.ACC.AccountAdmin.Models.ProjectUser body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Autodesk.ACC.AccountAdmin.Projects.Item.Users.Item.ProjectUserResponse> PatchAsync(global::Autodesk.ACC.AccountAdmin.Models.ProjectUser body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Autodesk.ACC.AccountAdmin.Models.ValidationError.CreateFromDiscriminatorValue },
                { "401", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "403", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "404", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "410", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "415", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "500", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "503", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Autodesk.ACC.AccountAdmin.Projects.Item.Users.Item.ProjectUserResponse>(requestInfo, global::Autodesk.ACC.AccountAdmin.Projects.Item.Users.Item.ProjectUserResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Private Use - Remove a user from the project.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Retrieves detailed information about a single user in a project.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Autodesk.ACC.AccountAdmin.Projects.Item.Users.Item.WithUserItemRequestBuilder.WithUserItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Autodesk.ACC.AccountAdmin.Projects.Item.Users.Item.WithUserItemRequestBuilder.WithUserItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Private Use - Update the user in a project.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Autodesk.ACC.AccountAdmin.Models.ProjectUser body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Autodesk.ACC.AccountAdmin.Models.ProjectUser body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.AccountAdmin.Projects.Item.Users.Item.WithUserItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Autodesk.ACC.AccountAdmin.Projects.Item.Users.Item.WithUserItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Autodesk.ACC.AccountAdmin.Projects.Item.Users.Item.WithUserItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithUserItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Retrieves detailed information about a single user in a project.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithUserItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Specify which attributes you want to see in the response. Possible values: ``name``, ``email``, ``firstName``, ``lastName``, ``autodeskId``, ``addressLine1``, ``addressLine2``, ``city``, ``stateOrProvince``, ``postalCode``, ``country``, ``imageUrl``, ``lastSignIn``, ``phone``, ``jobTitle``, ``industry``, ``aboutMe``, ``createdAt``, ``updatedAt``, ``accessLevels``, ``companyId``, ``roleIds``, ``services``, ``status``, `addedOn` and `products`. Separate multiple values with commas.</summary>
            [Obsolete("This property is deprecated, use FieldsAsGetFieldsQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields")]
            public string[]? Fields { get; set; }
#nullable restore
#else
            [QueryParameter("fields")]
            public string[] Fields { get; set; }
#endif
            /// <summary>Specify which attributes you want to see in the response. Possible values: ``name``, ``email``, ``firstName``, ``lastName``, ``autodeskId``, ``addressLine1``, ``addressLine2``, ``city``, ``stateOrProvince``, ``postalCode``, ``country``, ``imageUrl``, ``lastSignIn``, ``phone``, ``jobTitle``, ``industry``, ``aboutMe``, ``createdAt``, ``updatedAt``, ``accessLevels``, ``companyId``, ``roleIds``, ``services``, ``status``, `addedOn` and `products`. Separate multiple values with commas.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields")]
            public global::Autodesk.ACC.AccountAdmin.Projects.Item.Users.Item.GetFieldsQueryParameterType[]? FieldsAsGetFieldsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields")]
            public global::Autodesk.ACC.AccountAdmin.Projects.Item.Users.Item.GetFieldsQueryParameterType[] FieldsAsGetFieldsQueryParameterType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithUserItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Autodesk.ACC.AccountAdmin.Projects.Item.Users.Item.WithUserItemRequestBuilder.WithUserItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithUserItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
