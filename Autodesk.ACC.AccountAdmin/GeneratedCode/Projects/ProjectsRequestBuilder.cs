// <auto-generated/>
#pragma warning disable CS0618
using Autodesk.ACC.AccountAdmin.Models;
using Autodesk.ACC.AccountAdmin.Projects.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.ACC.AccountAdmin.Projects
{
    /// <summary>
    /// Builds and executes requests for operations under \projects
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ProjectsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Autodesk.ACC.AccountAdmin.projects.item collection</summary>
        /// <param name="position">The project ID. This corresponds to project ID in the `Data Management API &lt;/en/docs/data/v2/&gt;`_. To convert a project ID in the Data Management API into a project ID in the BIM 360 API you need to remove the &quot;**b.**\&quot; prefix. For example, a project ID of **b.**\a4be0c34a-4ab7 translates to a project ID of a4be0c34a-4ab7.</param>
        /// <returns>A <see cref="global::Autodesk.ACC.AccountAdmin.Projects.Item.WithProjectItemRequestBuilder"/></returns>
        public global::Autodesk.ACC.AccountAdmin.Projects.Item.WithProjectItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("projectId", position);
                return new global::Autodesk.ACC.AccountAdmin.Projects.Item.WithProjectItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Autodesk.ACC.AccountAdmin.projects.item collection</summary>
        /// <param name="position">The project ID. This corresponds to project ID in the `Data Management API &lt;/en/docs/data/v2/&gt;`_. To convert a project ID in the Data Management API into a project ID in the BIM 360 API you need to remove the &quot;**b.**\&quot; prefix. For example, a project ID of **b.**\a4be0c34a-4ab7 translates to a project ID of a4be0c34a-4ab7.</param>
        /// <returns>A <see cref="global::Autodesk.ACC.AccountAdmin.Projects.Item.WithProjectItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Autodesk.ACC.AccountAdmin.Projects.Item.WithProjectItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("projectId", position);
                return new global::Autodesk.ACC.AccountAdmin.Projects.Item.WithProjectItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.AccountAdmin.Projects.ProjectsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProjectsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/projects{?fields*,filterTextMatch*,filter%5BaccountId%5D*,filter%5BbusinessUnitId%5D*,filter%5BdataServiceId%5D*,filter%5BjobNumber%5D*,filter%5Bname%5D*,filter%5Bplatform%5D*,filter%5Bproducts%5D*,filter%5BserviceName%5D*,filter%5Bsource%5D*,filter%5Bstatus%5D*,filter%5Btype%5D*,limit*,offset*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.AccountAdmin.Projects.ProjectsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProjectsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/projects{?fields*,filterTextMatch*,filter%5BaccountId%5D*,filter%5BbusinessUnitId%5D*,filter%5BdataServiceId%5D*,filter%5BjobNumber%5D*,filter%5Bname%5D*,filter%5Bplatform%5D*,filter%5Bproducts%5D*,filter%5BserviceName%5D*,filter%5Bsource%5D*,filter%5Bstatus%5D*,filter%5Btype%5D*,limit*,offset*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Private Use - Returns a list of projects for a user.  Can return up to 200 projects per request. Only projects that the user participates in will be returned. For Account Admins to see all projects in the account, please use GET /v1/accounts/:a_id/projects
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.AccountAdmin.Projects.ProjectsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.ValidationError">When receiving a 400 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Projects401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 403 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 404 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 406 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 410 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 500 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 503 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Autodesk.ACC.AccountAdmin.Projects.ProjectsGetResponse?> GetAsProjectsGetResponseAsync(Action<RequestConfiguration<global::Autodesk.ACC.AccountAdmin.Projects.ProjectsRequestBuilder.ProjectsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Autodesk.ACC.AccountAdmin.Projects.ProjectsGetResponse> GetAsProjectsGetResponseAsync(Action<RequestConfiguration<global::Autodesk.ACC.AccountAdmin.Projects.ProjectsRequestBuilder.ProjectsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Autodesk.ACC.AccountAdmin.Models.ValidationError.CreateFromDiscriminatorValue },
                { "401", global::Autodesk.ACC.AccountAdmin.Models.Projects401Error.CreateFromDiscriminatorValue },
                { "403", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "404", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "406", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "410", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "500", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "503", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Autodesk.ACC.AccountAdmin.Projects.ProjectsGetResponse>(requestInfo, global::Autodesk.ACC.AccountAdmin.Projects.ProjectsGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Private Use - Returns a list of projects for a user.  Can return up to 200 projects per request. Only projects that the user participates in will be returned. For Account Admins to see all projects in the account, please use GET /v1/accounts/:a_id/projects
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.AccountAdmin.Projects.ProjectsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.ValidationError">When receiving a 400 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Projects401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 403 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 404 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 406 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 410 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 500 status code</exception>
        /// <exception cref="global::Autodesk.ACC.AccountAdmin.Models.Error">When receiving a 503 status code</exception>
        [Obsolete("This method is obsolete. Use GetAsProjectsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Autodesk.ACC.AccountAdmin.Projects.ProjectsResponse?> GetAsync(Action<RequestConfiguration<global::Autodesk.ACC.AccountAdmin.Projects.ProjectsRequestBuilder.ProjectsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Autodesk.ACC.AccountAdmin.Projects.ProjectsResponse> GetAsync(Action<RequestConfiguration<global::Autodesk.ACC.AccountAdmin.Projects.ProjectsRequestBuilder.ProjectsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Autodesk.ACC.AccountAdmin.Models.ValidationError.CreateFromDiscriminatorValue },
                { "401", global::Autodesk.ACC.AccountAdmin.Models.Projects401Error.CreateFromDiscriminatorValue },
                { "403", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "404", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "406", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "410", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "500", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
                { "503", global::Autodesk.ACC.AccountAdmin.Models.Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Autodesk.ACC.AccountAdmin.Projects.ProjectsResponse>(requestInfo, global::Autodesk.ACC.AccountAdmin.Projects.ProjectsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Private Use - Returns a list of projects for a user.  Can return up to 200 projects per request. Only projects that the user participates in will be returned. For Account Admins to see all projects in the account, please use GET /v1/accounts/:a_id/projects
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Autodesk.ACC.AccountAdmin.Projects.ProjectsRequestBuilder.ProjectsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Autodesk.ACC.AccountAdmin.Projects.ProjectsRequestBuilder.ProjectsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Autodesk.ACC.AccountAdmin.Projects.ProjectsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Autodesk.ACC.AccountAdmin.Projects.ProjectsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Autodesk.ACC.AccountAdmin.Projects.ProjectsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Private Use - Returns a list of projects for a user.  Can return up to 200 projects per request. Only projects that the user participates in will be returned. For Account Admins to see all projects in the account, please use GET /v1/accounts/:a_id/projects
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ProjectsRequestBuilderGetQueryParameters 
        {
            /// <summary>List of fields to return in the response.  Defaults to all fields. Valid list of fields are `accountId`, `addressLine1`, `addressLine2`, `adminGroupId`, `businessUnitId`, `city`, `companyCount`, `constructionType`, `country`, `createdAt`, `deliveryMethod`, `endDate`, `imageUrl`, `isAcsUnified`, `jobNumber`, `lastSignIn`, `latitude`, `longitude`, `memberCount`, `memberGroupId`, `name`, `platform`, `postalCode`, `products`, `projectSize`, `projectValue`, `services`, `sheetCount`,`startDate`, `stateOrProvince`, `status`, `thumbnailImageUrl`, `timezone`, `type` and `updatedAt`.</summary>
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
            /// <summary>List of fields to return in the response.  Defaults to all fields. Valid list of fields are `accountId`, `addressLine1`, `addressLine2`, `adminGroupId`, `businessUnitId`, `city`, `companyCount`, `constructionType`, `country`, `createdAt`, `deliveryMethod`, `endDate`, `imageUrl`, `isAcsUnified`, `jobNumber`, `lastSignIn`, `latitude`, `longitude`, `memberCount`, `memberGroupId`, `name`, `platform`, `postalCode`, `products`, `projectSize`, `projectValue`, `services`, `sheetCount`,`startDate`, `stateOrProvince`, `status`, `thumbnailImageUrl`, `timezone`, `type` and `updatedAt`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields")]
            public global::Autodesk.ACC.AccountAdmin.Projects.GetFieldsQueryParameterType[]? FieldsAsGetFieldsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields")]
            public global::Autodesk.ACC.AccountAdmin.Projects.GetFieldsQueryParameterType[] FieldsAsGetFieldsQueryParameterType { get; set; }
#endif
            /// <summary>Filter the projects by account id.</summary>
            [QueryParameter("filter%5BaccountId%5D")]
            public Guid? FilteraccountId { get; set; }
            /// <summary>Filter the projects by Business Unit id.</summary>
            [QueryParameter("filter%5BbusinessUnitId%5D")]
            public Guid? FilterbusinessUnitId { get; set; }
            /// <summary>Find the project associated to the provided data service identifier.</summary>
            [QueryParameter("filter%5BdataServiceId%5D")]
            public Guid? FilterdataServiceId { get; set; }
            /// <summary>Filter projects by job number.  Can be a partial match based on the value of `filterTextMatch` provided.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5BjobNumber%5D")]
            public string? FilterjobNumber { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5BjobNumber%5D")]
            public string FilterjobNumber { get; set; }
#endif
            /// <summary>Filter projects by name.  Can be a partial match based on the value of `filterTextMatch` provided.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bname%5D")]
            public string? Filtername { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bname%5D")]
            public string Filtername { get; set; }
#endif
            /// <summary>Filter resource by platform.  Valid values are `acc` and `bim360`.</summary>
            [Obsolete("This property is deprecated, use FilterplatformAsGetFilterPlatformQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bplatform%5D")]
            public string[]? Filterplatform { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bplatform%5D")]
            public string[] Filterplatform { get; set; }
#endif
            /// <summary>Filter resource by platform.  Valid values are `acc` and `bim360`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bplatform%5D")]
            public global::Autodesk.ACC.AccountAdmin.Projects.GetFilterPlatformQueryParameterType[]? FilterplatformAsGetFilterPlatformQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bplatform%5D")]
            public global::Autodesk.ACC.AccountAdmin.Projects.GetFilterPlatformQueryParameterType[] FilterplatformAsGetFilterPlatformQueryParameterType { get; set; }
#endif
            /// <summary>Filter resource by provided list of products.  Valid values are `assets`, `build`, `capitalPlanning`, `cost`, `costManagement`, `designCollaboration`, `docs`, `documentManagement`, `field`, `fieldManagement`, `financials`, `glue`,`workshopxr`, `insight`, `modelCoordination`, `plan`, `projectAdministration`, `projectManagement`, `quantification`, and `takeoff`.</summary>
            [Obsolete("This property is deprecated, use FilterproductsAsGetFilterProductsQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bproducts%5D")]
            public string[]? Filterproducts { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bproducts%5D")]
            public string[] Filterproducts { get; set; }
#endif
            /// <summary>Filter resource by provided list of products.  Valid values are `assets`, `build`, `capitalPlanning`, `cost`, `costManagement`, `designCollaboration`, `docs`, `documentManagement`, `field`, `fieldManagement`, `financials`, `glue`,`workshopxr`, `insight`, `modelCoordination`, `plan`, `projectAdministration`, `projectManagement`, `quantification`, and `takeoff`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bproducts%5D")]
            public global::Autodesk.ACC.AccountAdmin.Projects.GetFilterProductsQueryParameterType[]? FilterproductsAsGetFilterProductsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bproducts%5D")]
            public global::Autodesk.ACC.AccountAdmin.Projects.GetFilterProductsQueryParameterType[] FilterproductsAsGetFilterProductsQueryParameterType { get; set; }
#endif
            /// <summary>Filter the list of projects based on the provided service.  Valid values include `documentManagement`, `projectManagement`, `costManagement`, `quantification`, `designCollaboration`, `fieldManagement`, `assets`, `modelCoordination`, `documents`, `sheets`, `field`, `glue` and `plan`.</summary>
            [Obsolete("This property is deprecated, use FilterserviceNameAsGetFilterServiceNameQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5BserviceName%5D")]
            public string? FilterserviceName { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5BserviceName%5D")]
            public string FilterserviceName { get; set; }
#endif
            /// <summary>Filter the list of projects based on the provided service.  Valid values include `documentManagement`, `projectManagement`, `costManagement`, `quantification`, `designCollaboration`, `fieldManagement`, `assets`, `modelCoordination`, `documents`, `sheets`, `field`, `glue` and `plan`.</summary>
            [QueryParameter("filter%5BserviceName%5D")]
            public global::Autodesk.ACC.AccountAdmin.Projects.GetFilterServiceNameQueryParameterType? FilterserviceNameAsGetFilterServiceNameQueryParameterType { get; set; }
            /// <summary>Filter the list of projects based on the source system it was created for. Can be an the value `acsUnified` or empty.</summary>
            [Obsolete("This property is deprecated, use FiltersourceAsGetFilterSourceQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bsource%5D")]
            public string[]? Filtersource { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bsource%5D")]
            public string[] Filtersource { get; set; }
#endif
            /// <summary>Filter the list of projects based on the source system it was created for. Can be an the value `acsUnified` or empty.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bsource%5D")]
            public global::Autodesk.ACC.AccountAdmin.Projects.GetFilterSourceQueryParameterType[]? FiltersourceAsGetFilterSourceQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bsource%5D")]
            public global::Autodesk.ACC.AccountAdmin.Projects.GetFilterSourceQueryParameterType[] FiltersourceAsGetFilterSourceQueryParameterType { get; set; }
#endif
            /// <summary>Filter the list of projects based on the provided statuses.  Can be an array of values including `active`, `pending`, `archived` and `suspended`.</summary>
            [Obsolete("This property is deprecated, use FilterstatusAsGetFilterStatusQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bstatus%5D")]
            public string[]? Filterstatus { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bstatus%5D")]
            public string[] Filterstatus { get; set; }
#endif
            /// <summary>Filter the list of projects based on the provided statuses.  Can be an array of values including `active`, `pending`, `archived` and `suspended`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bstatus%5D")]
            public global::Autodesk.ACC.AccountAdmin.Projects.GetFilterStatusQueryParameterType[]? FilterstatusAsGetFilterStatusQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bstatus%5D")]
            public global::Autodesk.ACC.AccountAdmin.Projects.GetFilterStatusQueryParameterType[] FilterstatusAsGetFilterStatusQueryParameterType { get; set; }
#endif
            /// <summary>When filtering on a text based field this indicates how to do the matching.  Valid values are ``contains``, ``startsWith``, ``endsWith`` and ``equals``.  Default is ``contains``.</summary>
            [Obsolete("This property is deprecated, use FilterTextMatchAsGetFilterTextMatchQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filterTextMatch")]
            public string? FilterTextMatch { get; set; }
#nullable restore
#else
            [QueryParameter("filterTextMatch")]
            public string FilterTextMatch { get; set; }
#endif
            /// <summary>When filtering on a text based field this indicates how to do the matching.  Valid values are ``contains``, ``startsWith``, ``endsWith`` and ``equals``.  Default is ``contains``.</summary>
            [QueryParameter("filterTextMatch")]
            public global::Autodesk.ACC.AccountAdmin.Projects.GetFilterTextMatchQueryParameterType? FilterTextMatchAsGetFilterTextMatchQueryParameterType { get; set; }
            /// <summary>Filter projects by type. To exclude a type, prefix with a hyphen -. GET v1/accounts/:a_id/project-types lists all possible project types.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Btype%5D")]
            public string[]? Filtertype { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Btype%5D")]
            public string[] Filtertype { get; set; }
#endif
            /// <summary>The maximum number of records to return in a single request. Possible range: 1-200. Default Can be a number between 1 and 200.  Default value: 20.  If a number greater than 200 is provided 200 will be returned.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>The number of records to skip before returning the result records.  Increase this value in subsequent requests to continue getting results when the number of records exceeds the requested limit.</summary>
            [QueryParameter("offset")]
            public int? Offset { get; set; }
            /// <summary>The list of fields to sort by.  When multiple fields are listed the later property is used to sort the resources where the previous fields have the same value. Each property can be followed by a direction modifier of either `asc` (ascending) or `desc` (descending).  If no direction is specified then `asc` is assumed.  Valid fields for sorting are `name`, `startDate`, `endDate`, `type`, `status`, `jobNumber`, `constructionType`, `deliveryMethod`, `contractType`, `currentPhase`, `createdAt` and `updatedAt`.  Default sort is `name`.</summary>
            [Obsolete("This property is deprecated, use SortAsGetSortQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort")]
            public string[]? Sort { get; set; }
#nullable restore
#else
            [QueryParameter("sort")]
            public string[] Sort { get; set; }
#endif
            /// <summary>The list of fields to sort by.  When multiple fields are listed the later property is used to sort the resources where the previous fields have the same value. Each property can be followed by a direction modifier of either `asc` (ascending) or `desc` (descending).  If no direction is specified then `asc` is assumed.  Valid fields for sorting are `name`, `startDate`, `endDate`, `type`, `status`, `jobNumber`, `constructionType`, `deliveryMethod`, `contractType`, `currentPhase`, `createdAt` and `updatedAt`.  Default sort is `name`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort")]
            public global::Autodesk.ACC.AccountAdmin.Projects.GetSortQueryParameterType[]? SortAsGetSortQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("sort")]
            public global::Autodesk.ACC.AccountAdmin.Projects.GetSortQueryParameterType[] SortAsGetSortQueryParameterType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ProjectsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Autodesk.ACC.AccountAdmin.Projects.ProjectsRequestBuilder.ProjectsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
