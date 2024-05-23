// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.RFIs.Models {
    /// <summary>
    /// The attachment object.
    /// </summary>
    public class Attachment : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The type of attachment.</summary>
        public Attachment_attachmentType? AttachmentType { get; set; }
        /// <summary>The timestamp of the date and time the attachment was created, in the following format: ``YYYY-MM-DDThh:mm:ss.sz``.</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The Autodesk ID of the user who added the attachment. To check the name of the user, call `GET projects/users` `BIM 360&lt;/en/docs/bim360/v1/reference/http/admin-v1-projects-projectId-users-GET&gt;`_ `ACC&lt;/en/docs/acc/v1/reference/http/admin-v1-projects-projectId-users-GET&gt;`_.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedBy { get; set; }
#nullable restore
#else
        public string CreatedBy { get; set; }
#endif
        /// <summary>The timestamp of the date and time the attachment was deleted, in the following format: ``YYYY-MM-DDThh:mm:ss.sz``. This is only relevant for deleted attachments.</summary>
        public DateTimeOffset? DeletedAt { get; set; }
        /// <summary>The Autodesk ID of the user who deleted the attachment. To check the name of the user, call `GET projects/users` `BIM 360&lt;/en/docs/bim360/v1/reference/http/admin-v1-projects-projectId-users-GET&gt;`_ `ACC&lt;/en/docs/acc/v1/reference/http/admin-v1-projects-projectId-users-GET&gt;`_. This is only relevant for deleted attachments.&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeletedBy { get; set; }
#nullable restore
#else
        public string DeletedBy { get; set; }
#endif
        /// <summary>The ID of the attachment.</summary>
        public Guid? Id { get; private set; }
        /// <summary>The name of the attachment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>A list of actions that are permitted for the current user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Attachment_permittedActions? PermittedActions { get; set; }
#nullable restore
#else
        public Attachment_permittedActions PermittedActions { get; set; }
#endif
        /// <summary>The ID of the RFI associated with the attachment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RfiId { get; set; }
#nullable restore
#else
        public string RfiId { get; set; }
#endif
        /// <summary>The last date and time the attachment attributes were updated, in the following format: ``YYYY-MM-DDThh:mm:ss.sz``.</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>The URL of the storage location for the attachment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>The ID (item ID) of the document associated with the RFI. For more details, see the `Upload Attachment tutorial` `BIM 360&lt;/en/docs/bim360/v1/reference/tutorials/attach-BIM-360-files-to-rfi/&gt;`_ `ACC&lt;/en/docs/acc/v1/reference/tutorials/attach-BIM-360-files-to-rfi/&gt;`_.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Urn { get; set; }
#nullable restore
#else
        public string Urn { get; set; }
#endif
        /// <summary>The type of attachment URN. Possible values:``dm`` - for a BIM 360 Document Management file``oss`` - for a local file</summary>
        public Attachment_urnType? UrnType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="Attachment"/> and sets the default values.
        /// </summary>
        public Attachment()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Attachment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Attachment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Attachment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"attachmentType", n => { AttachmentType = n.GetEnumValue<Attachment_attachmentType>(); } },
                {"createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"createdBy", n => { CreatedBy = n.GetStringValue(); } },
                {"deletedAt", n => { DeletedAt = n.GetDateTimeOffsetValue(); } },
                {"deletedBy", n => { DeletedBy = n.GetStringValue(); } },
                {"id", n => { Id = n.GetGuidValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"permittedActions", n => { PermittedActions = n.GetObjectValue<Attachment_permittedActions>(Attachment_permittedActions.CreateFromDiscriminatorValue); } },
                {"rfiId", n => { RfiId = n.GetStringValue(); } },
                {"updatedAt", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
                {"urn", n => { Urn = n.GetStringValue(); } },
                {"urnType", n => { UrnType = n.GetEnumValue<Attachment_urnType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Attachment_attachmentType>("attachmentType", AttachmentType);
            writer.WriteDateTimeOffsetValue("createdAt", CreatedAt);
            writer.WriteStringValue("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("deletedAt", DeletedAt);
            writer.WriteStringValue("deletedBy", DeletedBy);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<Attachment_permittedActions>("permittedActions", PermittedActions);
            writer.WriteStringValue("rfiId", RfiId);
            writer.WriteDateTimeOffsetValue("updatedAt", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteStringValue("urn", Urn);
            writer.WriteEnumValue<Attachment_urnType>("urnType", UrnType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}