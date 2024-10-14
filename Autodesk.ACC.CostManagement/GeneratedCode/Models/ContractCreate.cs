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
    public partial class ContractCreate : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Code of the contract.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Code { get; set; }
#nullable restore
#else
        public string Code { get; set; }
#endif
        /// <summary>The ID of a supplier company. This is the ID of a company managed by BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyId { get; set; }
#nullable restore
#else
        public string CompanyId { get; set; }
#endif
        /// <summary>Default contact of the supplier. This is the ID of a user managed by BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContactId { get; set; }
#nullable restore
#else
        public string ContactId { get; set; }
#endif
        /// <summary>Currency setting of the contract.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Currency { get; set; }
#nullable restore
#else
        public string Currency { get; set; }
#endif
        /// <summary>Detailed description of a contract.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Exchange rate. For example, 1 base currency = 0.7455 foreign currency.</summary>
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
        /// <summary>A message that explains the sync status of the ERP integration with the BIM 360 Cost module.</summary>
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
        /// <summary>Forecast exchange rate. Default value is ``null``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ForecastExchanageRate { get; set; }
#nullable restore
#else
        public string ForecastExchanageRate { get; set; }
#endif
        /// <summary>Last time to update forecast exchange rate.</summary>
        public DateTimeOffset? ForecastExchangeRateUpdatedAt { get; set; }
        /// <summary>Lock state used by ERP integration, default value is ``null``.</summary>
        public global::Autodesk.ACC.CostManagement.Models.ContractCreate_integrationState? IntegrationState { get; set; }
        /// <summary>The ID of the main contract the contract belongs to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MainContractId { get; set; }
#nullable restore
#else
        public string MainContractId { get; set; }
#endif
        /// <summary>Name of the contract.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The user who is responsible the purchase. This is the ID of a user managed by BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OwnerId { get; set; }
#nullable restore
#else
        public string OwnerId { get; set; }
#endif
        /// <summary>Total retention percentage of the contract amount.</summary>
        public double? RetentionCap { get; set; }
        /// <summary>The user who signed the contract. This is the ID of a user managed by BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SignedBy { get; set; }
#nullable restore
#else
        public string SignedBy { get; set; }
#endif
        /// <summary>The status of this contract.</summary>
        public global::Autodesk.ACC.CostManagement.Models.ContractCreate_status? Status { get; set; }
        /// <summary>Type of the contract. For example, consultant or purchase order. Type is customizable by the project admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.Models.ContractCreate"/> and sets the default values.
        /// </summary>
        public ContractCreate()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.ContractCreate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.Models.ContractCreate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.Models.ContractCreate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "code", n => { Code = n.GetStringValue(); } },
                { "companyId", n => { CompanyId = n.GetStringValue(); } },
                { "contactId", n => { ContactId = n.GetStringValue(); } },
                { "currency", n => { Currency = n.GetStringValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "exchangeRate", n => { ExchangeRate = n.GetStringValue(); } },
                { "externalId", n => { ExternalId = n.GetStringValue(); } },
                { "externalMessage", n => { ExternalMessage = n.GetStringValue(); } },
                { "externalSystem", n => { ExternalSystem = n.GetStringValue(); } },
                { "forecastExchanageRate", n => { ForecastExchanageRate = n.GetStringValue(); } },
                { "forecastExchangeRateUpdatedAt", n => { ForecastExchangeRateUpdatedAt = n.GetDateTimeOffsetValue(); } },
                { "integrationState", n => { IntegrationState = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.ContractCreate_integrationState>(); } },
                { "mainContractId", n => { MainContractId = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "ownerId", n => { OwnerId = n.GetStringValue(); } },
                { "retentionCap", n => { RetentionCap = n.GetDoubleValue(); } },
                { "signedBy", n => { SignedBy = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.ContractCreate_status>(); } },
                { "type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("code", Code);
            writer.WriteStringValue("companyId", CompanyId);
            writer.WriteStringValue("contactId", ContactId);
            writer.WriteStringValue("currency", Currency);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("exchangeRate", ExchangeRate);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteStringValue("externalMessage", ExternalMessage);
            writer.WriteStringValue("externalSystem", ExternalSystem);
            writer.WriteStringValue("forecastExchanageRate", ForecastExchanageRate);
            writer.WriteDateTimeOffsetValue("forecastExchangeRateUpdatedAt", ForecastExchangeRateUpdatedAt);
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.ContractCreate_integrationState>("integrationState", IntegrationState);
            writer.WriteStringValue("mainContractId", MainContractId);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("ownerId", OwnerId);
            writer.WriteDoubleValue("retentionCap", RetentionCap);
            writer.WriteStringValue("signedBy", SignedBy);
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.ContractCreate_status>("status", Status);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
