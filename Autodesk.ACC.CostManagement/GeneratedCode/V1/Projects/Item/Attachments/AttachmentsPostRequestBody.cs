// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.Attachments
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class AttachmentsPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The object ID of the item with which the actions are associated—a budget, contract, or cost item for example.</summary>
        public Guid? AssociationId { get; set; }
        /// <summary>The type of the item is associated to. For example, ``Budget``, ``Contract``, ``CostItem``, ``FormInstance``, and ``Payment``, ``MainContract``, ``BudgetPayment``, ``Expense``, ``ExpenseItem``, ``OCO``, ``SCO`` in the coming release.</summary>
        public global::Autodesk.ACC.CostManagement.V1.Projects.Item.Attachments.AttachmentsPostRequestBody_associationType? AssociationType { get; set; }
        /// <summary>Folder ID retrieved from ``attachment-folder``</summary>
        public Guid? FolderId { get; set; }
        /// <summary>Name of the attachment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Version URN from BIM 360 Docs after the attachment is uploaded.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Urn { get; set; }
#nullable restore
#else
        public string Urn { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.Attachments.AttachmentsPostRequestBody"/> and sets the default values.
        /// </summary>
        public AttachmentsPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.Attachments.AttachmentsPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.V1.Projects.Item.Attachments.AttachmentsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.V1.Projects.Item.Attachments.AttachmentsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "associationId", n => { AssociationId = n.GetGuidValue(); } },
                { "associationType", n => { AssociationType = n.GetEnumValue<global::Autodesk.ACC.CostManagement.V1.Projects.Item.Attachments.AttachmentsPostRequestBody_associationType>(); } },
                { "folderId", n => { FolderId = n.GetGuidValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
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
            writer.WriteGuidValue("associationId", AssociationId);
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.V1.Projects.Item.Attachments.AttachmentsPostRequestBody_associationType>("associationType", AssociationType);
            writer.WriteGuidValue("folderId", FolderId);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("urn", Urn);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
