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
    public partial class SOVCreate : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The amount of budget allocated to this Contract. Not required in SoV.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AllocatedAmount { get; set; }
#nullable restore
#else
        public string AllocatedAmount { get; set; }
#endif
        /// <summary>The amount of the schedule of value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Amount { get; set; }
#nullable restore
#else
        public string Amount { get; set; }
#endif
        /// <summary>ID of the budget to which the schedule of value belongs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BudgetId { get; set; }
#nullable restore
#else
        public string BudgetId { get; set; }
#endif
        /// <summary>The converted quantity of the schedule of value. ``Bulk = Qty / Per``</summary>
        public double? Bulk { get; set; }
        /// <summary>The unit price of the converted quantity. ``Bulk Unit Price = Unit Price * quantityPerBulk``</summary>
        public double? BulkUnitPrice { get; set; }
        /// <summary>The code of the schedule of value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Code { get; set; }
#nullable restore
#else
        public string Code { get; set; }
#endif
        /// <summary>ID of the contract to which the schedule of value belongs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContractId { get; set; }
#nullable restore
#else
        public string ContractId { get; set; }
#endif
        /// <summary>Exchange rate. For example, 1 base currency = 0.7455 foreign currency.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExchangeRate { get; set; }
#nullable restore
#else
        public string ExchangeRate { get; set; }
#endif
        /// <summary>Unique identifier of the schedule of value. If not present, the system will generate one automatically.</summary>
        public Guid? Id { get; set; }
        /// <summary>The name of the schedule of value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>ID of the parent schedule of value. It is required in creating new scedule of value.</summary>
        public Guid? ParentId { get; set; }
        /// <summary>The quantity of the schedule of value.</summary>
        public double? Quantity { get; set; }
        /// <summary>The quantity conversion ratio of the schedule of value. ``Default`` value = 1</summary>
        public double? QuantityPerBulk { get; set; }
        /// <summary>The unit of the schedule of value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Unit { get; set; }
#nullable restore
#else
        public string Unit { get; set; }
#endif
        /// <summary>The unit price of the schedule of value.</summary>
        public double? UnitPrice { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.Models.SOVCreate"/> and sets the default values.
        /// </summary>
        public SOVCreate()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.SOVCreate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.Models.SOVCreate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.Models.SOVCreate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allocatedAmount", n => { AllocatedAmount = n.GetStringValue(); } },
                { "amount", n => { Amount = n.GetStringValue(); } },
                { "budgetId", n => { BudgetId = n.GetStringValue(); } },
                { "bulk", n => { Bulk = n.GetDoubleValue(); } },
                { "bulkUnitPrice", n => { BulkUnitPrice = n.GetDoubleValue(); } },
                { "code", n => { Code = n.GetStringValue(); } },
                { "contractId", n => { ContractId = n.GetStringValue(); } },
                { "exchangeRate", n => { ExchangeRate = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "parentId", n => { ParentId = n.GetGuidValue(); } },
                { "quantity", n => { Quantity = n.GetDoubleValue(); } },
                { "quantityPerBulk", n => { QuantityPerBulk = n.GetDoubleValue(); } },
                { "unit", n => { Unit = n.GetStringValue(); } },
                { "unitPrice", n => { UnitPrice = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("allocatedAmount", AllocatedAmount);
            writer.WriteStringValue("amount", Amount);
            writer.WriteStringValue("budgetId", BudgetId);
            writer.WriteDoubleValue("bulk", Bulk);
            writer.WriteDoubleValue("bulkUnitPrice", BulkUnitPrice);
            writer.WriteStringValue("code", Code);
            writer.WriteStringValue("contractId", ContractId);
            writer.WriteStringValue("exchangeRate", ExchangeRate);
            writer.WriteGuidValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteGuidValue("parentId", ParentId);
            writer.WriteDoubleValue("quantity", Quantity);
            writer.WriteDoubleValue("quantityPerBulk", QuantityPerBulk);
            writer.WriteStringValue("unit", Unit);
            writer.WriteDoubleValue("unitPrice", UnitPrice);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
