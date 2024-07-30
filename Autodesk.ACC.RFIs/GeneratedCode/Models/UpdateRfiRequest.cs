// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.RFIs.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class UpdateRfiRequest : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The assignedTo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignedTo { get; set; }
#nullable restore
#else
        public string AssignedTo { get; set; }
#endif
        /// <summary>The categories of the RFI.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.RFIs.Models.WithRfi?>? Category { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.RFIs.Models.WithRfi?> Category { get; set; }
#endif
        /// <summary>Comments to add while doing the RFI update</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.RFIs.Models.UpdateRfiRequest_commentsAttributes>? CommentsAttributes { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.RFIs.Models.UpdateRfiRequest_commentsAttributes> CommentsAttributes { get; set; }
#endif
        /// <summary>Mobile user last RFI Comment sync token</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommentSyncToken { get; set; }
#nullable restore
#else
        public string CommentSyncToken { get; set; }
#endif
        /// <summary>Add members who can contribute to the RFI response. For more information about who can add co-reviewers and the type of permission level they are assigned, see the `RFIs help BIM360&lt;https://help.autodesk.com/view/BIM360D/ENU/?guid=GUID-FCF34AF9-3A9E-4226-AED7-4538924F70A2&gt;`_ `ACC&lt;https://help.autodesk.com/view/BUILD/ENU/?guid=RFI_Overview&gt;`_ documentation.Note that although you can only add co-reviewers in the UI when the RFI is in open status, you can use the endpoint to also set up co-reviewers in other statuses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CoReviewers { get; set; }
#nullable restore
#else
        public List<string> CoReviewers { get; set; }
#endif
        /// <summary>Add members who can contribute to the RFI response. For more information about who can add co-reviewers and the type of permission level they are assigned, see the `RFIs help BIM360&lt;https://help.autodesk.com/view/BIM360D/ENU/?guid=GUID-FCF34AF9-3A9E-4226-AED7-4538924F70A2&gt;`_ `ACC&lt;https://help.autodesk.com/view/BUILD/ENU/?guid=RFI_Overview&gt;`_ documentation.Note that although you can only add co-reviewers in the UI when the RFI is in open status, you can use the endpoint to also set up co-reviewers in other statuses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CoReviewersCompanies { get; set; }
#nullable restore
#else
        public List<string> CoReviewersCompanies { get; set; }
#endif
        /// <summary>Add members who can contribute to the RFI response. For more information about who can add co-reviewers and the type of permission level they are assigned, see the `RFIs help BIM360&lt;https://help.autodesk.com/view/BIM360D/ENU/?guid=GUID-FCF34AF9-3A9E-4226-AED7-4538924F70A2&gt;`_ `ACC&lt;https://help.autodesk.com/view/BUILD/ENU/?guid=RFI_Overview&gt;`_ documentation.Note that although you can only add co-reviewers in the UI when the RFI is in open status, you can use the endpoint to also set up co-reviewers in other statuses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CoReviewersRoles { get; set; }
#nullable restore
#else
        public List<string> CoReviewersRoles { get; set; }
#endif
        /// <summary>The cost impact status of the RFI. Possible values: ``null``, ``Yes``, ``No``, ``Unknown``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.RFIs.Models.RfiCostImpact? CostImpact { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.RFIs.Models.RfiCostImpact CostImpact { get; set; }
#endif
        /// <summary>Custom attributes values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.RFIs.Models.WithRfi?>? CustomAttributes { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.RFIs.Models.WithRfi?> CustomAttributes { get; set; }
#endif
        /// <summary>The custom identifier of the RFI (required in case that status is set to open).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomIdentifier { get; set; }
#nullable restore
#else
        public string CustomIdentifier { get; set; }
#endif
        /// <summary>The disciplines of the RFI.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.RFIs.Models.WithRfi?>? Discipline { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.RFIs.Models.WithRfi?> Discipline { get; set; }
#endif
        /// <summary>Add members to receive email notifications when the RFI is updated. These members will also be able to contribute to the RFI response.For more information about who can add members to the distribution list and the type of permission level they are assigned, see the `RFIs help documentation` `BIM 360&lt;https://help.autodesk.com/view/BIM360D/ENU/?guid=GUID-E0BD1D73-B070-4DB0-9294-BF9CD0A7B6F3&gt;`_ `ACC&lt;https://help.autodesk.com/view/BUILD/ENU/?guid=RFI_Permissions&gt;`_.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DistributionList { get; set; }
#nullable restore
#else
        public List<string> DistributionList { get; set; }
#endif
        /// <summary>Add members to receive email notifications when the RFI is updated. These members will also be able to contribute to the RFI response.For more information about who can add members to the distribution list and the type of permission level they are assigned, see the `RFIs help documentation` `BIM 360&lt;https://help.autodesk.com/view/BIM360D/ENU/?guid=GUID-E0BD1D73-B070-4DB0-9294-BF9CD0A7B6F3&gt;`_ `ACC&lt;https://help.autodesk.com/view/BUILD/ENU/?guid=RFI_Permissions&gt;`_.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DistributionListCompanies { get; set; }
#nullable restore
#else
        public List<string> DistributionListCompanies { get; set; }
#endif
        /// <summary>Add members to receive email notifications when the RFI is updated. These members will also be able to contribute to the RFI response.For more information about who can add members to the distribution list and the type of permission level they are assigned, see the `RFIs help documentation` `BIM 360&lt;https://help.autodesk.com/view/BIM360D/ENU/?guid=GUID-E0BD1D73-B070-4DB0-9294-BF9CD0A7B6F3&gt;`_ `ACC&lt;https://help.autodesk.com/view/BUILD/ENU/?guid=RFI_Permissions&gt;`_.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DistributionListRoles { get; set; }
#nullable restore
#else
        public List<string> DistributionListRoles { get; set; }
#endif
        /// <summary>The RFI lbs (Location Breakdown Structure) ids.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? LbsIds { get; set; }
#nullable restore
#else
        public List<string> LbsIds { get; set; }
#endif
        /// <summary>The ID (item ID) of the document associated with the RFI.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.RFIs.Models.NullableUrnDefinition? LinkedDocument { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.RFIs.Models.NullableUrnDefinition LinkedDocument { get; set; }
#endif
        /// <summary>The version of the document when the RFI is closed.</summary>
        public int? LinkedDocumentCloseVersion { get; set; }
        /// <summary>The location object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.RFIs.Models.RfiUpdateLocation? Location { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.RFIs.Models.RfiUpdateLocation Location { get; set; }
#endif
        /// <summary>The official response to the RFI.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OfficialResponse { get; set; }
#nullable restore
#else
        public string OfficialResponse { get; set; }
#endif
        /// <summary>The status of the RFI. Note that the possible statuses of the RFI depend on the workflow type assigned to the RFI.For a default workflow with a single reviewer (``US``), you can potentially use the following statuses: ``draft``, ``submitted``, ``open``, ``answered``, ``rejected``, ``closed``, ``void``.For a workflow with an additional reviewer (``EMEA``), you can potentially use the following statuses: ``draft``, ``submitted``, ``openRev1``, ``openRev2``, ``rejectedRev1``, ``rejectedManager``, ``answeredRev1``, ``answeredManager``, ``closed``, ``void``.For more information about different workflows and statuses, see the `RFIs help documentation` `BIM360&lt;https://help.autodesk.com/view/BIM360D/ENU/?guid=GUID-787338BF-1189-4170-8629-7FA240F4BED4&gt;`_ `ACC&lt;https://help.autodesk.com/view/BUILD/ENU/?guid=RFI_Workflow_Setup&gt;`_.To check the workflow type of an RFI, call `GET users/me` `BIM 360&lt;/en/docs/bim360/v1/reference/http/rfis-v2-users-me-GET/&gt;`_ `ACC&lt;/en/docs/acc/v1/reference/http/rfis-v2-users-me-GET/&gt;`_ and check ``workflow.type``.To check which statuses the user can potentially open the RFI with, call `GET rfis/:id` `BIM 360&lt;/en/docs/bim360/v1/reference/http/rfis-v2-rfis-id-GET&gt;`_ `ACC&lt;/en/docs/acc/v1/reference/http/rfis-v2-rfis-id-GET&gt;`_.</summary>
        public global::Autodesk.ACC.RFIs.Models.RfiStatus? OldStatus { get; set; }
        /// <summary>The priority status of the RFI. Possible values: ``null``, ``High``, ``Normal``, ``Low``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.RFIs.Models.RfiPriority? Priority { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.RFIs.Models.RfiPriority Priority { get; set; }
#endif
        /// <summary>BIM360: Data about the pushpin RFI. Only relevant for pushpin RFIs. For more details, see the `RFI pushpin tutorials. &lt;/en/docs/bim360/v1/tutorials/create-pushpin/&gt;`_ACC: Not relevant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.RFIs.Models.UpdateRfiRequest_pushpinAttributes? PushpinAttributes { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.RFIs.Models.UpdateRfiRequest_pushpinAttributes PushpinAttributes { get; set; }
#endif
        /// <summary>An external ID; typically used when the RFI was created in another system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Reference { get; set; }
#nullable restore
#else
        public string Reference { get; set; }
#endif
        /// <summary>The ID of the rfi type.</summary>
        public Guid? RfiTypeId { get; set; }
        /// <summary>The schedule impact status of the RFI. Possible values: ``null``, ``Yes``, ``No``, ``Unknown``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.RFIs.Models.RfiScheduleImpact? ScheduleImpact { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.RFIs.Models.RfiScheduleImpact ScheduleImpact { get; set; }
#endif
        /// <summary>The status of the RFI. Note that the possible statuses of the RFI depend on the workflow type assigned to the RFI.For a default workflow with a single reviewer (``US``), you can potentially use the following statuses: ``draft``, ``submitted``, ``open``, ``answered``, ``rejected``, ``closed``, ``void``.For a workflow with an additional reviewer (``EMEA``), you can potentially use the following statuses: ``draft``, ``submitted``, ``openRev1``, ``openRev2``, ``rejectedRev1``, ``rejectedManager``, ``answeredRev1``, ``answeredManager``, ``closed``, ``void``.For more information about different workflows and statuses, see the `RFIs help documentation` `BIM360&lt;https://help.autodesk.com/view/BIM360D/ENU/?guid=GUID-787338BF-1189-4170-8629-7FA240F4BED4&gt;`_ `ACC&lt;https://help.autodesk.com/view/BUILD/ENU/?guid=RFI_Workflow_Setup&gt;`_.To check the workflow type of an RFI, call `GET users/me` `BIM 360&lt;/en/docs/bim360/v1/reference/http/rfis-v2-users-me-GET/&gt;`_ `ACC&lt;/en/docs/acc/v1/reference/http/rfis-v2-users-me-GET/&gt;`_ and check ``workflow.type``.To check which statuses the user can potentially open the RFI with, call `GET rfis/:id` `BIM 360&lt;/en/docs/bim360/v1/reference/http/rfis-v2-rfis-id-GET&gt;`_ `ACC&lt;/en/docs/acc/v1/reference/http/rfis-v2-rfis-id-GET&gt;`_.</summary>
        public global::Autodesk.ACC.RFIs.Models.RfiStatus? Status { get; set; }
        /// <summary>The suggested answer for the RFI.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SuggestedAnswer { get; set; }
#nullable restore
#else
        public string SuggestedAnswer { get; set; }
#endif
        /// <summary>Mobile user last sync token</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SyncToken { get; set; }
#nullable restore
#else
        public string SyncToken { get; set; }
#endif
        /// <summary>The title of the RFI.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.RFIs.Models.UpdateRfiRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.RFIs.Models.UpdateRfiRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.RFIs.Models.UpdateRfiRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "assignedTo", n => { AssignedTo = n.GetStringValue(); } },
                { "category", n => { Category = n.GetCollectionOfEnumValues<global::Autodesk.ACC.RFIs.Models.WithRfi>()?.AsList(); } },
                { "coReviewers", n => { CoReviewers = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "coReviewersCompanies", n => { CoReviewersCompanies = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "coReviewersRoles", n => { CoReviewersRoles = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "commentSyncToken", n => { CommentSyncToken = n.GetStringValue(); } },
                { "commentsAttributes", n => { CommentsAttributes = n.GetCollectionOfObjectValues<global::Autodesk.ACC.RFIs.Models.UpdateRfiRequest_commentsAttributes>(global::Autodesk.ACC.RFIs.Models.UpdateRfiRequest_commentsAttributes.CreateFromDiscriminatorValue)?.AsList(); } },
                { "costImpact", n => { CostImpact = n.GetObjectValue<global::Autodesk.ACC.RFIs.Models.RfiCostImpact>(global::Autodesk.ACC.RFIs.Models.RfiCostImpact.CreateFromDiscriminatorValue); } },
                { "customAttributes", n => { CustomAttributes = n.GetCollectionOfEnumValues<global::Autodesk.ACC.RFIs.Models.WithRfi>()?.AsList(); } },
                { "customIdentifier", n => { CustomIdentifier = n.GetStringValue(); } },
                { "discipline", n => { Discipline = n.GetCollectionOfEnumValues<global::Autodesk.ACC.RFIs.Models.WithRfi>()?.AsList(); } },
                { "distributionList", n => { DistributionList = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "distributionListCompanies", n => { DistributionListCompanies = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "distributionListRoles", n => { DistributionListRoles = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "lbsIds", n => { LbsIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "linkedDocument", n => { LinkedDocument = n.GetObjectValue<global::Autodesk.ACC.RFIs.Models.NullableUrnDefinition>(global::Autodesk.ACC.RFIs.Models.NullableUrnDefinition.CreateFromDiscriminatorValue); } },
                { "linkedDocumentCloseVersion", n => { LinkedDocumentCloseVersion = n.GetIntValue(); } },
                { "location", n => { Location = n.GetObjectValue<global::Autodesk.ACC.RFIs.Models.RfiUpdateLocation>(global::Autodesk.ACC.RFIs.Models.RfiUpdateLocation.CreateFromDiscriminatorValue); } },
                { "officialResponse", n => { OfficialResponse = n.GetStringValue(); } },
                { "oldStatus", n => { OldStatus = n.GetEnumValue<global::Autodesk.ACC.RFIs.Models.RfiStatus>(); } },
                { "priority", n => { Priority = n.GetObjectValue<global::Autodesk.ACC.RFIs.Models.RfiPriority>(global::Autodesk.ACC.RFIs.Models.RfiPriority.CreateFromDiscriminatorValue); } },
                { "pushpinAttributes", n => { PushpinAttributes = n.GetObjectValue<global::Autodesk.ACC.RFIs.Models.UpdateRfiRequest_pushpinAttributes>(global::Autodesk.ACC.RFIs.Models.UpdateRfiRequest_pushpinAttributes.CreateFromDiscriminatorValue); } },
                { "reference", n => { Reference = n.GetStringValue(); } },
                { "rfiTypeId", n => { RfiTypeId = n.GetGuidValue(); } },
                { "scheduleImpact", n => { ScheduleImpact = n.GetObjectValue<global::Autodesk.ACC.RFIs.Models.RfiScheduleImpact>(global::Autodesk.ACC.RFIs.Models.RfiScheduleImpact.CreateFromDiscriminatorValue); } },
                { "status", n => { Status = n.GetEnumValue<global::Autodesk.ACC.RFIs.Models.RfiStatus>(); } },
                { "suggestedAnswer", n => { SuggestedAnswer = n.GetStringValue(); } },
                { "syncToken", n => { SyncToken = n.GetStringValue(); } },
                { "title", n => { Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("assignedTo", AssignedTo);
            writer.WriteCollectionOfEnumValues<global::Autodesk.ACC.RFIs.Models.WithRfi>("category", Category);
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.RFIs.Models.UpdateRfiRequest_commentsAttributes>("commentsAttributes", CommentsAttributes);
            writer.WriteStringValue("commentSyncToken", CommentSyncToken);
            writer.WriteCollectionOfPrimitiveValues<string>("coReviewers", CoReviewers);
            writer.WriteCollectionOfPrimitiveValues<string>("coReviewersCompanies", CoReviewersCompanies);
            writer.WriteCollectionOfPrimitiveValues<string>("coReviewersRoles", CoReviewersRoles);
            writer.WriteObjectValue<global::Autodesk.ACC.RFIs.Models.RfiCostImpact>("costImpact", CostImpact);
            writer.WriteCollectionOfEnumValues<global::Autodesk.ACC.RFIs.Models.WithRfi>("customAttributes", CustomAttributes);
            writer.WriteStringValue("customIdentifier", CustomIdentifier);
            writer.WriteCollectionOfEnumValues<global::Autodesk.ACC.RFIs.Models.WithRfi>("discipline", Discipline);
            writer.WriteCollectionOfPrimitiveValues<string>("distributionList", DistributionList);
            writer.WriteCollectionOfPrimitiveValues<string>("distributionListCompanies", DistributionListCompanies);
            writer.WriteCollectionOfPrimitiveValues<string>("distributionListRoles", DistributionListRoles);
            writer.WriteCollectionOfPrimitiveValues<string>("lbsIds", LbsIds);
            writer.WriteObjectValue<global::Autodesk.ACC.RFIs.Models.NullableUrnDefinition>("linkedDocument", LinkedDocument);
            writer.WriteIntValue("linkedDocumentCloseVersion", LinkedDocumentCloseVersion);
            writer.WriteObjectValue<global::Autodesk.ACC.RFIs.Models.RfiUpdateLocation>("location", Location);
            writer.WriteStringValue("officialResponse", OfficialResponse);
            writer.WriteEnumValue<global::Autodesk.ACC.RFIs.Models.RfiStatus>("oldStatus", OldStatus);
            writer.WriteObjectValue<global::Autodesk.ACC.RFIs.Models.RfiPriority>("priority", Priority);
            writer.WriteObjectValue<global::Autodesk.ACC.RFIs.Models.UpdateRfiRequest_pushpinAttributes>("pushpinAttributes", PushpinAttributes);
            writer.WriteStringValue("reference", Reference);
            writer.WriteGuidValue("rfiTypeId", RfiTypeId);
            writer.WriteObjectValue<global::Autodesk.ACC.RFIs.Models.RfiScheduleImpact>("scheduleImpact", ScheduleImpact);
            writer.WriteEnumValue<global::Autodesk.ACC.RFIs.Models.RfiStatus>("status", Status);
            writer.WriteStringValue("suggestedAnswer", SuggestedAnswer);
            writer.WriteStringValue("syncToken", SyncToken);
            writer.WriteStringValue("title", Title);
        }
    }
}
