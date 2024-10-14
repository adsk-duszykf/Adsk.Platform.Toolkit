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
    public partial class ForecastAdjustment : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The amount of the forecast adjustment.</summary>
        public double? Amount { get; set; }
        /// <summary>The ID of the Budget to which the forecast adjustment belongs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BudgetId { get; set; }
#nullable restore
#else
        public string BudgetId { get; set; }
#endif
        /// <summary>The ID of the contract to which the forecast adjustment belongs.</summary>
        public Guid? ContractId { get; set; }
        /// <summary>The timestamp of the date and time the item was created, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>Description of the forecast adjustment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
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
        /// <summary>The ID of the forecast adjustment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Lock state used by ERP integration, default value is ``null``.</summary>
        public global::Autodesk.ACC.CostManagement.Models.ForecastAdjustment_integrationState? IntegrationState { get; set; }
        /// <summary>The date and time last locked this item.</summary>
        public DateTimeOffset? IntegrationStateChangedAt { get; set; }
        /// <summary>The user who last locked this item. This is the ID of a user managed by BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IntegrationStateChangedBy { get; set; }
#nullable restore
#else
        public string IntegrationStateChangedBy { get; set; }
#endif
        /// <summary>The date and time when the item was last updated.</summary>
        public DateTimeOffset? LastSyncTime { get; private set; }
        /// <summary>Quantity of labor, material,... planned for a forecast adjustment.</summary>
        public double? Quantity { get; set; }
        /// <summary>Unit of measures used in the forecast adjustment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Unit { get; set; }
#nullable restore
#else
        public string Unit { get; set; }
#endif
        /// <summary>Unit price of a forecast adjustment.</summary>
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
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.Models.ForecastAdjustment"/> and sets the default values.
        /// </summary>
        public ForecastAdjustment()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.ForecastAdjustment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.Models.ForecastAdjustment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.Models.ForecastAdjustment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "amount", n => { Amount = n.GetDoubleValue(); } },
                { "budgetId", n => { BudgetId = n.GetStringValue(); } },
                { "contractId", n => { ContractId = n.GetGuidValue(); } },
                { "createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "externalId", n => { ExternalId = n.GetStringValue(); } },
                { "externalMessage", n => { ExternalMessage = n.GetStringValue(); } },
                { "externalSystem", n => { ExternalSystem = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "integrationState", n => { IntegrationState = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.ForecastAdjustment_integrationState>(); } },
                { "integrationStateChangedAt", n => { IntegrationStateChangedAt = n.GetDateTimeOffsetValue(); } },
                { "integrationStateChangedBy", n => { IntegrationStateChangedBy = n.GetStringValue(); } },
                { "lastSyncTime", n => { LastSyncTime = n.GetDateTimeOffsetValue(); } },
                { "quantity", n => { Quantity = n.GetDoubleValue(); } },
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
            writer.WriteDoubleValue("amount", Amount);
            writer.WriteStringValue("budgetId", BudgetId);
            writer.WriteGuidValue("contractId", ContractId);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteStringValue("externalMessage", ExternalMessage);
            writer.WriteStringValue("externalSystem", ExternalSystem);
            writer.WriteStringValue("id", Id);
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.ForecastAdjustment_integrationState>("integrationState", IntegrationState);
            writer.WriteDateTimeOffsetValue("integrationStateChangedAt", IntegrationStateChangedAt);
            writer.WriteStringValue("integrationStateChangedBy", IntegrationStateChangedBy);
            writer.WriteDoubleValue("quantity", Quantity);
            writer.WriteStringValue("unit", Unit);
            writer.WriteStringValue("unitPrice", UnitPrice);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
