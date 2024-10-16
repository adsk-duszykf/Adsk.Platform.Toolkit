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
    public partial class ExpenseItem : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The aggregate type to budget Pay.</summary>
        public global::Autodesk.ACC.CostManagement.Models.ExpenseItem_aggregateBy? AggregateBy { get; set; }
        /// <summary>The amount of the expense item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Amount { get; set; }
#nullable restore
#else
        public string Amount { get; set; }
#endif
        /// <summary>The ID of the budget to which the expense item belongs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BudgetId { get; set; }
#nullable restore
#else
        public string BudgetId { get; set; }
#endif
        /// <summary>The ID of the contract to which the expense item belongs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContractId { get; private set; }
#nullable restore
#else
        public string ContractId { get; private set; }
#endif
        /// <summary>The timestamp of the date and time the item was created, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>The detail description of the expense item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Exchange rate. Default value is ``1``, if multi-currency is not enabled, it will also be ``1``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExchangeRate { get; set; }
#nullable restore
#else
        public string ExchangeRate { get; set; }
#endif
        /// <summary>The ID of the item in its original external system. You can use this ID to track the source of truth or to look up the data in an integrated system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId { get; set; }
#nullable restore
#else
        public string ExternalId { get; set; }
#endif
        /// <summary>A description about the integration: success, failure or error message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalMessage { get; set; }
#nullable restore
#else
        public string ExternalMessage { get; set; }
#endif
        /// <summary>The name of the external system. You can use this name to track the source of truth or to search in an integrated system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalSystem { get; set; }
#nullable restore
#else
        public string ExternalSystem { get; set; }
#endif
        /// <summary>Unique identifier of the expense item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; private set; }
#nullable restore
#else
        public string Id { get; private set; }
#endif
        /// <summary>The date and time when the item was last updated.</summary>
        public DateTimeOffset? LastSyncTime { get; private set; }
        /// <summary>The name of the expense item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The note of the expense item. Draftjs formatted rich text (https://draftjs.org/)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Note { get; set; }
#nullable restore
#else
        public string Note { get; set; }
#endif
        /// <summary>System-generated sequential number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Number { get; private set; }
#nullable restore
#else
        public string Number { get; private set; }
#endif
        /// <summary>Exchange rate get from contract exchange rate. Default value is ``1``, if multi-currency is not enabled, it will also be ``1``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginalExchangeRate { get; set; }
#nullable restore
#else
        public string OriginalExchangeRate { get; set; }
#endif
        /// <summary>The quantity property</summary>
        public double? Quantity { get; set; }
        /// <summary>amount * exchangeRate / originalExchangeRate - amount</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RealizedGainOrLoss { get; set; }
#nullable restore
#else
        public string RealizedGainOrLoss { get; set; }
#endif
        /// <summary>The expense type of the expense item. Possible values: ``full``, ``partial``.</summary>
        public global::Autodesk.ACC.CostManagement.Models.ExpenseItem_scope? Scope { get; set; }
        /// <summary>The tex of the expense.</summary>
        public double? Tax { get; set; }
        /// <summary>The unit of measures used in the expense item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Unit { get; set; }
#nullable restore
#else
        public string Unit { get; set; }
#endif
        /// <summary>The unit price of the expense item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UnitPrice { get; set; }
#nullable restore
#else
        public string UnitPrice { get; set; }
#endif
        /// <summary>The timestamp of the date and time the item was updated, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.Models.ExpenseItem"/> and sets the default values.
        /// </summary>
        public ExpenseItem()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.ExpenseItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.Models.ExpenseItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.Models.ExpenseItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "aggregateBy", n => { AggregateBy = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.ExpenseItem_aggregateBy>(); } },
                { "amount", n => { Amount = n.GetStringValue(); } },
                { "budgetId", n => { BudgetId = n.GetStringValue(); } },
                { "contractId", n => { ContractId = n.GetStringValue(); } },
                { "createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "exchangeRate", n => { ExchangeRate = n.GetStringValue(); } },
                { "externalId", n => { ExternalId = n.GetStringValue(); } },
                { "externalMessage", n => { ExternalMessage = n.GetStringValue(); } },
                { "externalSystem", n => { ExternalSystem = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "lastSyncTime", n => { LastSyncTime = n.GetDateTimeOffsetValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "note", n => { Note = n.GetStringValue(); } },
                { "number", n => { Number = n.GetStringValue(); } },
                { "originalExchangeRate", n => { OriginalExchangeRate = n.GetStringValue(); } },
                { "quantity", n => { Quantity = n.GetDoubleValue(); } },
                { "realizedGainOrLoss", n => { RealizedGainOrLoss = n.GetStringValue(); } },
                { "scope", n => { Scope = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.ExpenseItem_scope>(); } },
                { "tax", n => { Tax = n.GetDoubleValue(); } },
                { "unit", n => { Unit = n.GetStringValue(); } },
                { "unitPrice", n => { UnitPrice = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.ExpenseItem_aggregateBy>("aggregateBy", AggregateBy);
            writer.WriteStringValue("amount", Amount);
            writer.WriteStringValue("budgetId", BudgetId);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("exchangeRate", ExchangeRate);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteStringValue("externalMessage", ExternalMessage);
            writer.WriteStringValue("externalSystem", ExternalSystem);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("note", Note);
            writer.WriteStringValue("originalExchangeRate", OriginalExchangeRate);
            writer.WriteDoubleValue("quantity", Quantity);
            writer.WriteStringValue("realizedGainOrLoss", RealizedGainOrLoss);
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.ExpenseItem_scope>("scope", Scope);
            writer.WriteDoubleValue("tax", Tax);
            writer.WriteStringValue("unit", Unit);
            writer.WriteStringValue("unitPrice", UnitPrice);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
