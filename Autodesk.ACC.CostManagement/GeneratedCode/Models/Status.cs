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
    public partial class Status : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ID of the change order type when association type is FormDefinition and empty UUID (&apos;00000000-0000-0000-0000-000000000000&apos;) for other association types (Budget, Contract, MainContract, BudgetPayment...)</summary>
        public Guid? AssociationId { get; set; }
        /// <summary>The type of the item is associated to. For example, ``Budget``, ``Contract``, ``CostItem``, ``FormDefinition``, and ``Payment``, ``MainContract``, ``BudgetPayment``, ``Expense``, ``ExpenseItem``, ``OCO``, ``SCO`` in the coming release.</summary>
        public global::Autodesk.ACC.CostManagement.Models.Status_associationType? AssociationType { get; set; }
        /// <summary>A unique code for a module.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Code { get; set; }
#nullable restore
#else
        public string Code { get; set; }
#endif
        /// <summary>The color to indicate the status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Color { get; set; }
#nullable restore
#else
        public string Color { get; set; }
#endif
        /// <summary>The timestamp of the date and time the item was created, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>The id property</summary>
        public Guid? Id { get; private set; }
        /// <summary>Display name of the status</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>For modules like ``PCO``/``Cost Item`` that has 2 statuses.</summary>
        public global::Autodesk.ACC.CostManagement.Models.Status_type? Type { get; set; }
        /// <summary>The timestamp of the date and time the item was updated, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.Models.Status"/> and sets the default values.
        /// </summary>
        public Status()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.Status"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.Models.Status CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.Models.Status();
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
                { "associationType", n => { AssociationType = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.Status_associationType>(); } },
                { "code", n => { Code = n.GetStringValue(); } },
                { "color", n => { Color = n.GetStringValue(); } },
                { "createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "type", n => { Type = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.Status_type>(); } },
                { "updatedAt", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.Status_associationType>("associationType", AssociationType);
            writer.WriteStringValue("code", Code);
            writer.WriteStringValue("color", Color);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.Status_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
