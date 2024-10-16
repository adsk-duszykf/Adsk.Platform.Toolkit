// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.CostManagement.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class DocumentPackageItem : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Object version URN of the attachment in the Autodesk Data Management service. Valid for Upload, DocsFile and Attachment type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AttachmentUrn { get; set; }
#nullable restore
#else
        public string AttachmentUrn { get; set; }
#endif
        /// <summary>The timestamp of the date and time the item was created, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>Unique auto-generated identifier of the document package.</summary>
        public Guid? DocumentPacakgeId { get; private set; }
        /// <summary>The version URN of the document package item in docx format in the Autodesk Data Management service. Valid for Document type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DocxUrn { get; set; }
#nullable restore
#else
        public string DocxUrn { get; set; }
#endif
        /// <summary>Error information if this document package item failed to be generated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.CostManagement.Models.DocumentPackageItem_errorInfo? ErrorInfo { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.CostManagement.Models.DocumentPackageItem_errorInfo ErrorInfo { get; set; }
#endif
        /// <summary>Folder ID retrieved from the attachment’s containing folder /attachment-folder. Valid for Upload type.</summary>
        public Guid? FolderId { get; set; }
        /// <summary>Unique auto-generated identifier of the document package item.</summary>
        public Guid? Id { get; private set; }
        /// <summary>Name of the item generated in document package.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The order of the itme in the document package.</summary>
        public double? Position { get; set; }
        /// <summary>The source file name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceFileName { get; set; }
#nullable restore
#else
        public string SourceFileName { get; set; }
#endif
        /// <summary>Current status of the document. Possible values: ``Pending``, ``InProgress``, ``Complete``, ``Fail``, ``PendingSign``, ``Signed``.</summary>
        public global::Autodesk.ACC.CostManagement.Models.DocumentPackageItem_status? Status { get; set; }
        /// <summary>UUID of the document template. Valid for Document type.</summary>
        public Guid? TemplateId { get; set; }
        /// <summary>Document: a document generated from a DocumentTemplate; Upload: upload from a local file; DocsFile: a file attached from BIM 360 Docs; Attachment: move an attachment from Attachments to Document Pacakge</summary>
        public global::Autodesk.ACC.CostManagement.Models.DocumentPackageItem_type? Type { get; set; }
        /// <summary>The timestamp of the date and time the item was updated, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>The version URN of the document package item in the Autodesk Data Management service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Urn { get; set; }
#nullable restore
#else
        public string Urn { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.Models.DocumentPackageItem"/> and sets the default values.
        /// </summary>
        public DocumentPackageItem()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.DocumentPackageItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.Models.DocumentPackageItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.Models.DocumentPackageItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "attachmentUrn", n => { AttachmentUrn = n.GetStringValue(); } },
                { "createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "documentPacakgeId", n => { DocumentPacakgeId = n.GetGuidValue(); } },
                { "docxUrn", n => { DocxUrn = n.GetStringValue(); } },
                { "errorInfo", n => { ErrorInfo = n.GetObjectValue<global::Autodesk.ACC.CostManagement.Models.DocumentPackageItem_errorInfo>(global::Autodesk.ACC.CostManagement.Models.DocumentPackageItem_errorInfo.CreateFromDiscriminatorValue); } },
                { "folderId", n => { FolderId = n.GetGuidValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "position", n => { Position = n.GetDoubleValue(); } },
                { "sourceFileName", n => { SourceFileName = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.DocumentPackageItem_status>(); } },
                { "templateId", n => { TemplateId = n.GetGuidValue(); } },
                { "type", n => { Type = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.DocumentPackageItem_type>(); } },
                { "updatedAt", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                { "urn", n => { Urn = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("attachmentUrn", AttachmentUrn);
            writer.WriteStringValue("docxUrn", DocxUrn);
            writer.WriteObjectValue<global::Autodesk.ACC.CostManagement.Models.DocumentPackageItem_errorInfo>("errorInfo", ErrorInfo);
            writer.WriteGuidValue("folderId", FolderId);
            writer.WriteStringValue("name", Name);
            writer.WriteDoubleValue("position", Position);
            writer.WriteStringValue("sourceFileName", SourceFileName);
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.DocumentPackageItem_status>("status", Status);
            writer.WriteGuidValue("templateId", TemplateId);
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.DocumentPackageItem_type>("type", Type);
            writer.WriteStringValue("urn", Urn);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
