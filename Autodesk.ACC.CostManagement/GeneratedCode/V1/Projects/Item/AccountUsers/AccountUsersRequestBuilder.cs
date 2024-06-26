// <auto-generated/>
using Autodesk.ACC.CostManagement.Models;
using Autodesk.ACC.CostManagement.V1.Projects.Item.AccountUsers.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.AccountUsers {
    /// <summary>
    /// Builds and executes requests for operations under \v1\projects\{projectId}\account-users
    /// </summary>
    public class AccountUsersRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the Autodesk.ACC.CostManagement.v1.projects.item.accountUsers.item collection</summary>
        /// <param name="position">The user id.</param>
        /// <returns>A <see cref="AccountUsersItemRequestBuilder"/></returns>
        public AccountUsersItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new AccountUsersItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="AccountUsersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccountUsersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/account-users{?filter%5BdefaultCompanyId%5D*,filter%5Bemail%5D*,filter%5Bname%5D*,filter%5Bstatus%5D*,internalLimit*,limit*,offset*,orFilters*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="AccountUsersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccountUsersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/account-users{?filter%5BdefaultCompanyId%5D*,filter%5Bemail%5D*,filter%5Bname%5D*,filter%5Bstatus%5D*,internalLimit*,limit*,offset*,orFilters*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieves all the users in the account of current project.
        /// </summary>
        /// <returns>A List&lt;AccountUser&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="DefinedError">When receiving a 400 status code</exception>
        /// <exception cref="Error">When receiving a 401 status code</exception>
        /// <exception cref="Error">When receiving a 403 status code</exception>
        /// <exception cref="Error">When receiving a 404 status code</exception>
        /// <exception cref="Error">When receiving a 500 status code</exception>
        /// <exception cref="Error">When receiving a 503 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<AccountUser>?> GetAsync(Action<RequestConfiguration<AccountUsersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<AccountUser>> GetAsync(Action<RequestConfiguration<AccountUsersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"400", DefinedError.CreateFromDiscriminatorValue},
                {"401", Error.CreateFromDiscriminatorValue},
                {"403", Error.CreateFromDiscriminatorValue},
                {"404", Error.CreateFromDiscriminatorValue},
                {"500", Error.CreateFromDiscriminatorValue},
                {"503", Error.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<AccountUser>(requestInfo, AccountUser.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Creates a user in the account of current project.
        /// </summary>
        /// <returns>A <see cref="AccountUser"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="DefinedError">When receiving a 400 status code</exception>
        /// <exception cref="Error">When receiving a 401 status code</exception>
        /// <exception cref="Error">When receiving a 403 status code</exception>
        /// <exception cref="Error">When receiving a 404 status code</exception>
        /// <exception cref="Error">When receiving a 500 status code</exception>
        /// <exception cref="Error">When receiving a 503 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<AccountUser?> PostAsync(AccountUsersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<AccountUser> PostAsync(AccountUsersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"400", DefinedError.CreateFromDiscriminatorValue},
                {"401", Error.CreateFromDiscriminatorValue},
                {"403", Error.CreateFromDiscriminatorValue},
                {"404", Error.CreateFromDiscriminatorValue},
                {"500", Error.CreateFromDiscriminatorValue},
                {"503", Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<AccountUser>(requestInfo, AccountUser.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieves all the users in the account of current project.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AccountUsersRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AccountUsersRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a user in the account of current project.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(AccountUsersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(AccountUsersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/v1/projects/{projectId}/account-users", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="AccountUsersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public AccountUsersRequestBuilder WithUrl(string rawUrl)
        {
            return new AccountUsersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieves all the users in the account of current project.
        /// </summary>
        public class AccountUsersRequestBuilderGetQueryParameters 
        {
            /// <summary>The contact&apos;s default company id. For example, ``filter[defaultCompanyId]=b6445638-ca68-4e3c-9160-15864de6b818``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5BdefaultCompanyId%5D")]
            public string? FilterdefaultCompanyId { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5BdefaultCompanyId%5D")]
            public string FilterdefaultCompanyId { get; set; }
#endif
            /// <summary>The contact&apos;s email address. For example, ``filter[email]=test@autodesk.com``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bemail%5D")]
            public string? Filteremail { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bemail%5D")]
            public string Filteremail { get; set; }
#endif
            /// <summary>The item&apos;s name. For example, ``filter[name]=Labor``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bname%5D")]
            public string? Filtername { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bname%5D")]
            public string Filtername { get; set; }
#endif
            /// <summary>The status code. Separate multiple IDs with commas. For example, ``filter[status]=draft,open``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bstatus%5D")]
            public string[]? Filterstatus { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bstatus%5D")]
            public string[] Filterstatus { get; set; }
#endif
            /// <summary>The maximum number of items to return, this is for internal use, and the default maximum internal limit is 5000.</summary>
            [QueryParameter("internalLimit")]
            public int? InternalLimit { get; set; }
            /// <summary>The maximum number of items to return, default maximum limit is 100.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>The number of items to skip before starting to collect the result set.</summary>
            [QueryParameter("offset")]
            public int? Offset { get; set; }
            /// <summary>List of filtered fields to apply an &quot;or&quot; operator. For example ``orFilters=name,email```.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("orFilters")]
            public string[]? OrFilters { get; set; }
#nullable restore
#else
            [QueryParameter("orFilters")]
            public string[] OrFilters { get; set; }
#endif
            /// <summary>The sort order for items. Each attribute can be sorted in either ``asc`` (default) or ``desc`` order. For example, ``sort=name, updatedAt desc`` or ``sort=name + updatedAt desc`` sorts the results first by name in ascending order, then by date updated in descending order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort")]
            public string? Sort { get; set; }
#nullable restore
#else
            [QueryParameter("sort")]
            public string Sort { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class AccountUsersRequestBuilderGetRequestConfiguration : RequestConfiguration<AccountUsersRequestBuilderGetQueryParameters> 
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class AccountUsersRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
