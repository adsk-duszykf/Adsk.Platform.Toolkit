// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.RFIs.Models {
    public class CreateRfiRequest : IParsable 
    {
        /// <summary>The assignedTo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignedTo { get; set; }
#nullable restore
#else
        public string AssignedTo { get; set; }
#endif
        /// <summary>The attachmentsAttributes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CreateAttachmentRequestDefinition>? AttachmentsAttributes { get; set; }
#nullable restore
#else
        public List<CreateAttachmentRequestDefinition> AttachmentsAttributes { get; set; }
#endif
        /// <summary>The categories of the RFI.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Rfis?>? Category { get; set; }
#nullable restore
#else
        public List<Rfis?> Category { get; set; }
#endif
        /// <summary>Comments to add while doing the RFI update</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CreateRfiRequest_commentsAttributes>? CommentsAttributes { get; set; }
#nullable restore
#else
        public List<CreateRfiRequest_commentsAttributes> CommentsAttributes { get; set; }
#endif
        /// <summary>Add members who can contribute to the RFI response. For more information about who can add co-reviewers and the type of permission level they are assigned, see the `RFIs help BIM360&lt;https://help.autodesk.com/view/BIM360D/ENU/?guid=GUID-FCF34AF9-3A9E-4226-AED7-4538924F70A2&gt;`_ `ACC&lt;https://help.autodesk.com/view/BUILD/ENU/?guid=RFI_Permissions&gt;`_ documentation.Note that although you can only add co-reviewers in the UI when the RFI is in open status, you can use the endpoint to also set up co-reviewers in other statuses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CoReviewers { get; set; }
#nullable restore
#else
        public List<string> CoReviewers { get; set; }
#endif
        /// <summary>Add members who can contribute to the RFI response. For more information about who can add co-reviewers and the type of permission level they are assigned, see the `RFIs help BIM360&lt;https://help.autodesk.com/view/BIM360D/ENU/?guid=GUID-FCF34AF9-3A9E-4226-AED7-4538924F70A2&gt;`_ `ACC&lt;https://help.autodesk.com/view/BUILD/ENU/?guid=RFI_Permissions&gt;`_ documentation.Note that although you can only add co-reviewers in the UI when the RFI is in open status, you can use the endpoint to also set up co-reviewers in other statuses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CoReviewersCompanies { get; set; }
#nullable restore
#else
        public List<string> CoReviewersCompanies { get; set; }
#endif
        /// <summary>Add members who can contribute to the RFI response. For more information about who can add co-reviewers and the type of permission level they are assigned, see the `RFIs help BIM360&lt;https://help.autodesk.com/view/BIM360D/ENU/?guid=GUID-FCF34AF9-3A9E-4226-AED7-4538924F70A2&gt;`_ `ACC&lt;https://help.autodesk.com/view/BUILD/ENU/?guid=RFI_Permissions&gt;`_ documentation.Note that although you can only add co-reviewers in the UI when the RFI is in open status, you can use the endpoint to also set up co-reviewers in other statuses.</summary>
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
        public RfiCostImpact? CostImpact { get; set; }
#nullable restore
#else
        public RfiCostImpact CostImpact { get; set; }
#endif
        /// <summary>Custom attributes values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Rfis?>? CustomAttributes { get; set; }
#nullable restore
#else
        public List<Rfis?> CustomAttributes { get; set; }
#endif
        /// <summary>The custom identifier of the RFI (required in case that status is set to open).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RfiCustomIdentifier? CustomIdentifier { get; set; }
#nullable restore
#else
        public RfiCustomIdentifier CustomIdentifier { get; set; }
#endif
        /// <summary>The disciplines of the RFI.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Rfis?>? Discipline { get; set; }
#nullable restore
#else
        public List<Rfis?> Discipline { get; set; }
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
        /// <summary>Optional. Used where the API client needs to set the RFI ID in advance.</summary>
        public Guid? Id { get; set; }
        /// <summary>The RFI lbs (Location Breakdown Structure) ids.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? LbsIds { get; set; }
#nullable restore
#else
        public List<string> LbsIds { get; set; }
#endif
        /// <summary>The ID (item ID) of the document associated with the RFI. For more details, see the `Upload Attachment tutorial` `BIM 360&lt;/en/docs/bim360/v1/reference/tutorials/attach-BIM-360-files-to-rfi/&gt;`_ `ACC&lt;/en/docs/acc/v1/reference/tutorials/attach-BIM-360-files-to-rfi/&gt;`_.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LinkedDocument { get; set; }
#nullable restore
#else
        public string LinkedDocument { get; set; }
#endif
        /// <summary>The version number of the document associated with the RFI. Only relevant for pushpin RFIs.</summary>
        public int? LinkedDocumentVersion { get; set; }
        /// <summary>The location object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RfiLocation? Location { get; set; }
#nullable restore
#else
        public RfiLocation Location { get; set; }
#endif
        /// <summary>The priority status of the RFI. Possible values: ``null``, ``High``, ``Normal``, ``Low``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RfiPriority? Priority { get; set; }
#nullable restore
#else
        public RfiPriority Priority { get; set; }
#endif
        /// <summary>BIM360: Data about the RFI pushpin. Only relevant for pushpin RFIs. For more details, see the pushpin tutorials. `&lt;/en/docs/bim360/v1/tutorials/create-pushpin/&gt;`_ACC: Not relevant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CreateRfiRequest_pushpinAttributes? PushpinAttributes { get; set; }
#nullable restore
#else
        public CreateRfiRequest_pushpinAttributes PushpinAttributes { get; set; }
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
        public RfiScheduleImpact? ScheduleImpact { get; set; }
#nullable restore
#else
        public RfiScheduleImpact ScheduleImpact { get; set; }
#endif
        /// <summary>BIM 360: Data about the document associated with the RFI. Only relevant for pushpin RFIs. For more information, see the `RFI pushpin tutorials. &lt;/en/docs/bim360/v1/tutorials/create-pushpin/&gt;`_ACC: Not relevant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CreateRfiRequest_sheetMetadata? SheetMetadata { get; set; }
#nullable restore
#else
        public CreateRfiRequest_sheetMetadata SheetMetadata { get; set; }
#endif
        /// <summary>The status of the RFI. Note that the possible statuses of the RFI depend on the workflow type assigned to the RFI.For a default workflow with a single reviewer (``US``), you can potentially use the following statuses: ``draft``, ``submitted``, ``open``, ``answered``, ``rejected``, ``closed``, ``void``.For a workflow with an additional reviewer (``EMEA``), you can potentially use the following statuses: ``draft``, ``submitted``, ``openRev1``, ``openRev2``, ``rejectedRev1``, ``rejectedManager``, ``answeredRev1``, ``answeredManager``, ``closed``, ``void``.For more information about different workflows and statuses, see the `RFIs help documentation` `BIM360&lt;https://help.autodesk.com/view/BIM360D/ENU/?guid=GUID-787338BF-1189-4170-8629-7FA240F4BED4&gt;`_ `ACC&lt;https://help.autodesk.com/view/BUILD/ENU/?guid=RFI_Workflow_Setup&gt;`_.To check the workflow type of an RFI, call `GET users/me` `BIM 360&lt;/en/docs/bim360/v1/reference/http/rfis-v2-users-me-GET/&gt;`_ `ACC&lt;/en/docs/acc/v1/reference/http/rfis-v2-users-me-GET/&gt;`_ and check ``workflow.type``.To check which statuses the user can potentially open the RFI with, call `GET rfis/:id` `BIM 360&lt;/en/docs/bim360/v1/reference/http/rfis-v2-rfis-id-GET&gt;`_ `ACC&lt;/en/docs/acc/v1/reference/http/rfis-v2-rfis-id-GET&gt;`_.</summary>
        public RfiStatus? Status { get; set; }
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
        /// <summary>Optional, Used when the client creates the RFI virtual folder before the RFI itself.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VirtualFolderUrn { get; set; }
#nullable restore
#else
        public string VirtualFolderUrn { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CreateRfiRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CreateRfiRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateRfiRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"assignedTo", n => { AssignedTo = n.GetStringValue(); } },
                {"attachmentsAttributes", n => { AttachmentsAttributes = n.GetCollectionOfObjectValues<CreateAttachmentRequestDefinition>(CreateAttachmentRequestDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"category", n => { Category = n.GetCollectionOfEnumValues<Rfis>()?.ToList(); } },
                {"coReviewers", n => { CoReviewers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"coReviewersCompanies", n => { CoReviewersCompanies = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"coReviewersRoles", n => { CoReviewersRoles = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"commentsAttributes", n => { CommentsAttributes = n.GetCollectionOfObjectValues<CreateRfiRequest_commentsAttributes>(CreateRfiRequest_commentsAttributes.CreateFromDiscriminatorValue)?.ToList(); } },
                {"costImpact", n => { CostImpact = n.GetObjectValue<RfiCostImpact>(RfiCostImpact.CreateFromDiscriminatorValue); } },
                {"customAttributes", n => { CustomAttributes = n.GetCollectionOfEnumValues<Rfis>()?.ToList(); } },
                {"customIdentifier", n => { CustomIdentifier = n.GetObjectValue<RfiCustomIdentifier>(RfiCustomIdentifier.CreateFromDiscriminatorValue); } },
                {"discipline", n => { Discipline = n.GetCollectionOfEnumValues<Rfis>()?.ToList(); } },
                {"distributionList", n => { DistributionList = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"distributionListCompanies", n => { DistributionListCompanies = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"distributionListRoles", n => { DistributionListRoles = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"id", n => { Id = n.GetGuidValue(); } },
                {"lbsIds", n => { LbsIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"linkedDocument", n => { LinkedDocument = n.GetStringValue(); } },
                {"linkedDocumentVersion", n => { LinkedDocumentVersion = n.GetIntValue(); } },
                {"location", n => { Location = n.GetObjectValue<RfiLocation>(RfiLocation.CreateFromDiscriminatorValue); } },
                {"priority", n => { Priority = n.GetObjectValue<RfiPriority>(RfiPriority.CreateFromDiscriminatorValue); } },
                {"pushpinAttributes", n => { PushpinAttributes = n.GetObjectValue<CreateRfiRequest_pushpinAttributes>(CreateRfiRequest_pushpinAttributes.CreateFromDiscriminatorValue); } },
                {"reference", n => { Reference = n.GetStringValue(); } },
                {"rfiTypeId", n => { RfiTypeId = n.GetGuidValue(); } },
                {"scheduleImpact", n => { ScheduleImpact = n.GetObjectValue<RfiScheduleImpact>(RfiScheduleImpact.CreateFromDiscriminatorValue); } },
                {"sheetMetadata", n => { SheetMetadata = n.GetObjectValue<CreateRfiRequest_sheetMetadata>(CreateRfiRequest_sheetMetadata.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetEnumValue<RfiStatus>(); } },
                {"suggestedAnswer", n => { SuggestedAnswer = n.GetStringValue(); } },
                {"syncToken", n => { SyncToken = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"virtualFolderUrn", n => { VirtualFolderUrn = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<CreateAttachmentRequestDefinition>("attachmentsAttributes", AttachmentsAttributes);
            writer.WriteCollectionOfEnumValues<Rfis>("category", Category);
            writer.WriteCollectionOfObjectValues<CreateRfiRequest_commentsAttributes>("commentsAttributes", CommentsAttributes);
            writer.WriteCollectionOfPrimitiveValues<string>("coReviewers", CoReviewers);
            writer.WriteCollectionOfPrimitiveValues<string>("coReviewersCompanies", CoReviewersCompanies);
            writer.WriteCollectionOfPrimitiveValues<string>("coReviewersRoles", CoReviewersRoles);
            writer.WriteObjectValue<RfiCostImpact>("costImpact", CostImpact);
            writer.WriteCollectionOfEnumValues<Rfis>("customAttributes", CustomAttributes);
            writer.WriteObjectValue<RfiCustomIdentifier>("customIdentifier", CustomIdentifier);
            writer.WriteCollectionOfEnumValues<Rfis>("discipline", Discipline);
            writer.WriteCollectionOfPrimitiveValues<string>("distributionList", DistributionList);
            writer.WriteCollectionOfPrimitiveValues<string>("distributionListCompanies", DistributionListCompanies);
            writer.WriteCollectionOfPrimitiveValues<string>("distributionListRoles", DistributionListRoles);
            writer.WriteGuidValue("id", Id);
            writer.WriteCollectionOfPrimitiveValues<string>("lbsIds", LbsIds);
            writer.WriteStringValue("linkedDocument", LinkedDocument);
            writer.WriteIntValue("linkedDocumentVersion", LinkedDocumentVersion);
            writer.WriteObjectValue<RfiLocation>("location", Location);
            writer.WriteObjectValue<RfiPriority>("priority", Priority);
            writer.WriteObjectValue<CreateRfiRequest_pushpinAttributes>("pushpinAttributes", PushpinAttributes);
            writer.WriteStringValue("reference", Reference);
            writer.WriteGuidValue("rfiTypeId", RfiTypeId);
            writer.WriteObjectValue<RfiScheduleImpact>("scheduleImpact", ScheduleImpact);
            writer.WriteObjectValue<CreateRfiRequest_sheetMetadata>("sheetMetadata", SheetMetadata);
            writer.WriteEnumValue<RfiStatus>("status", Status);
            writer.WriteStringValue("suggestedAnswer", SuggestedAnswer);
            writer.WriteStringValue("syncToken", SyncToken);
            writer.WriteStringValue("title", Title);
            writer.WriteStringValue("virtualFolderUrn", VirtualFolderUrn);
        }
    }
}
