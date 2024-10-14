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
    public partial class DocumentPackageResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The object ID of the item with which the actions are associated—a budget, contract, or cost item for example.</summary>
        public Guid? AssociationId { get; set; }
        /// <summary>The type of the item is associated to. For example, ``Budget``, ``Contract``, ``CostItem``, ``FormInstance``, and ``Payment``, ``MainContract``, ``BudgetPayment``, ``Expense``, ``ExpenseItem``, ``OCO``, ``SCO`` in the coming release.</summary>
        public global::Autodesk.ACC.CostManagement.Models.DocumentPackageResponse_associationType? AssociationType { get; set; }
        /// <summary>The timestamp of the date and time the item was created, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>Error information if this document package failed to be generated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.CostManagement.Models.DocumentPackageResponse_errorInfo? ErrorInfo { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.CostManagement.Models.DocumentPackageResponse_errorInfo ErrorInfo { get; set; }
#endif
        /// <summary>Unique auto-generated identifier of the generated document package.</summary>
        public Guid? Id { get; private set; }
        /// <summary>List of document package items in the document package.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.CostManagement.Models.DocumentPackageItem>? Items { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.CostManagement.Models.DocumentPackageItem> Items { get; set; }
#endif
        /// <summary>name of the document package</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Autodesk ID of the recipient, who is a project user inside BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecipientId { get; set; }
#nullable restore
#else
        public string RecipientId { get; set; }
#endif
        /// <summary>Current status of the document. Possible values: ``Pending``, ``InProgress``, ``Complete``, ``Fail``, ``PendingSign``, ``Signed``.</summary>
        public global::Autodesk.ACC.CostManagement.Models.DocumentPackageResponse_status? Status { get; set; }
        /// <summary>The timestamp of the date and time the item was updated, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>The version URN of the document package in the Autodesk Data Management service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Urn { get; set; }
#nullable restore
#else
        public string Urn { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.Models.DocumentPackageResponse"/> and sets the default values.
        /// </summary>
        public DocumentPackageResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.DocumentPackageResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.Models.DocumentPackageResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.Models.DocumentPackageResponse();
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
                { "associationType", n => { AssociationType = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.DocumentPackageResponse_associationType>(); } },
                { "createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "errorInfo", n => { ErrorInfo = n.GetObjectValue<global::Autodesk.ACC.CostManagement.Models.DocumentPackageResponse_errorInfo>(global::Autodesk.ACC.CostManagement.Models.DocumentPackageResponse_errorInfo.CreateFromDiscriminatorValue); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "items", n => { Items = n.GetCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.DocumentPackageItem>(global::Autodesk.ACC.CostManagement.Models.DocumentPackageItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "recipientId", n => { RecipientId = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.DocumentPackageResponse_status>(); } },
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
            writer.WriteGuidValue("associationId", AssociationId);
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.DocumentPackageResponse_associationType>("associationType", AssociationType);
            writer.WriteObjectValue<global::Autodesk.ACC.CostManagement.Models.DocumentPackageResponse_errorInfo>("errorInfo", ErrorInfo);
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.DocumentPackageItem>("items", Items);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("recipientId", RecipientId);
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.DocumentPackageResponse_status>("status", Status);
            writer.WriteStringValue("urn", Urn);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
