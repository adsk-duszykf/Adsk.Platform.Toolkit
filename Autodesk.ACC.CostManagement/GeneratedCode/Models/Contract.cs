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
    public partial class Contract : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Total amount of actual cost of the contract.</summary>
        public double? ActualCost { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The date and time when the contract is approved.</summary>
        public DateTimeOffset? ApprovedAt { get; set; }
        /// <summary>Total amount of the changes committed to the supplier.</summary>
        public double? ApprovedChangeOrders { get; set; }
        /// <summary>Total amount of in-scope changes committed to the supplier.</summary>
        public double? ApprovedInScopeChangeOrders { get; set; }
        /// <summary>Total amount of the changes approved by the owner.</summary>
        public double? ApprovedOwnerChanges { get; set; }
        /// <summary>Amount of the original Contract</summary>
        public double? Awarded { get; set; }
        /// <summary>The date and time when the contract is awarded.</summary>
        public DateTimeOffset? AwardedAt { get; set; }
        /// <summary>Budgets that are linked to this contract.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.CostManagement.Models.Contract_budgets>? Budgets { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.CostManagement.Models.Contract_budgets> Budgets { get; set; }
#endif
        /// <summary>The user who made the last change to the contract. This is the ID of a user managed by BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChangedBy { get; private set; }
#nullable restore
#else
        public string ChangedBy { get; private set; }
#endif
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
        /// <summary>Calculated values based on contract customized columns.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.CostManagement.Models.Contract_compounded? Compounded { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.CostManagement.Models.Contract_compounded Compounded { get; set; }
#endif
        /// <summary>Default contact of the supplier. This is the ID of a user managed by BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContactId { get; set; }
#nullable restore
#else
        public string ContactId { get; set; }
#endif
        /// <summary>The timestamp of the date and time the item was created, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>The user who created the contract. This is the ID of a user managed by BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatorId { get; private set; }
#nullable restore
#else
        public string CreatorId { get; private set; }
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
        /// <summary>The date and time when the contract document is generated.</summary>
        public DateTimeOffset? DocumentGeneratedAt { get; private set; }
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
        /// <summary>Total amount of the forecast cost to complete, equals to ``forecastFinalCost`` - ``actualCost``.</summary>
        public double? ForecastCostComplete { get; set; }
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
        /// <summary>Total amount of the project cost including forecast adjustments, equals to ``projectedCost`` + ``adjustmentsTotal``.</summary>
        public double? ForecastFinalCost { get; set; }
        /// <summary>Total amount of the forecast variance, equals to ``projectedBudget`` - ``forecastFinalCost``.</summary>
        public double? ForecastVariance { get; set; }
        /// <summary>Unique identifier of a contract.</summary>
        public Guid? Id { get; private set; }
        /// <summary>Lock state used by ERP integration, default value is ``null``.</summary>
        public global::Autodesk.ACC.CostManagement.Models.Contract_integrationState? IntegrationState { get; set; }
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
        /// <summary>Total amount of internal transfers of budgets associated to this Contract.</summary>
        public double? InternalAdjustment { get; set; }
        /// <summary>The date and time when the item was last updated.</summary>
        public DateTimeOffset? LastSyncTime { get; private set; }
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
        /// <summary>Note to the contract. This is a Draftjs formatted rich text (https://draftjs.org/)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Note { get; set; }
#nullable restore
#else
        public string Note { get; set; }
#endif
        /// <summary>The date and time when the supplier completes the job.</summary>
        public DateTimeOffset? OffsiteAt { get; set; }
        /// <summary>The date and time when the Supplier on-site to the job.</summary>
        public DateTimeOffset? OnsiteAt { get; set; }
        /// <summary>Total amount of original amount of budgets associated to this Contract.</summary>
        public double? OriginalBudget { get; set; }
        /// <summary>The user who is responsible the purchase. This is the ID of a user managed by BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OwnerId { get; set; }
#nullable restore
#else
        public string OwnerId { get; set; }
#endif
        /// <summary>The payment due days of the contract.</summary>
        public int? PaymentDue { get; set; }
        /// <summary>The payment due days relative to date of the contract.</summary>
        public global::Autodesk.ACC.CostManagement.Models.Contract_paymentDueType? PaymentDueType { get; set; }
        /// <summary>Total amount of the changes not committed to the supplier.</summary>
        public double? PendingChangeOrders { get; set; }
        /// <summary>Total amount of the changes pending approval by the owner.</summary>
        public double? PendingOwnerChanges { get; set; }
        /// <summary>The date and time of purchased. This is designed for Purchase Order contract.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProcuredAt { get; set; }
#nullable restore
#else
        public string ProcuredAt { get; set; }
#endif
        /// <summary>Total amount of the project budget including pending changes, equals to ``revised`` + ``pendingOwnerChanges``.</summary>
        public double? ProjectedBudget { get; set; }
        /// <summary>Total amount of the project cost. For a budget, it is equal to ``originalCommitment`` + ``approvedChangeOrders`` + ``pendingChangeOrders`` + ``reserves``. For a contract , it is equal to ``awarded`` + ``approvedChangeOrders`` + ``pendingChangeOrders`` + ``reserves``.</summary>
        public double? ProjectedCost { get; set; }
        /// <summary>Total amount of the changes under estimating.</summary>
        public double? Reserves { get; set; }
        /// <summary>The date and time when the supplier responds.</summary>
        public DateTimeOffset? RespondedAt { get; set; }
        /// <summary>The date and time when the supplier responds.</summary>
        public DateTimeOffset? ResponseDue { get; set; }
        /// <summary>Total retention percentage of the contract amount.</summary>
        public double? RetentionCap { get; set; }
        /// <summary>The date and time when the contract is signed and returned.</summary>
        public DateTimeOffset? ReturnedAt { get; set; }
        /// <summary>Total amount of the approved budget from the owner, equals to ``originalAmount`` + ``internalAdjustment`` + ``approvedOwnerChanges``.</summary>
        public double? Revised { get; set; }
        /// <summary>Schedule of values of the contract.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.CostManagement.Models.SOV>? ScheduleOfValues { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.CostManagement.Models.SOV> ScheduleOfValues { get; set; }
#endif
        /// <summary>Scope signed by all parties of the contract. This is a Draftjs formatted rich text (https://draftjs.org/).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScopeOfWork { get; set; }
#nullable restore
#else
        public string ScopeOfWork { get; set; }
#endif
        /// <summary>The date and time when the contract is sent to the supplier.</summary>
        public DateTimeOffset? SentAt { get; set; }
        /// <summary>The user who signed the contract. This is the ID of a user managed by BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SignedBy { get; set; }
#nullable restore
#else
        public string SignedBy { get; set; }
#endif
        /// <summary>The status of this contract.</summary>
        public global::Autodesk.ACC.CostManagement.Models.Contract_status? Status { get; set; }
        /// <summary>The last time when the status is updated.</summary>
        public DateTimeOffset? StatusChangedAt { get; private set; }
        /// <summary>Type of the contract. For example, consultant or purchase order. Type is customizable by the project admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>The amount that has been approved by owner but not committed to the supplier: equals to ``approvedOwnerChanges`` - (``approvedChangeOrders`` - ``approvedInScopeChangeOrders``).</summary>
        public double? Uncommitted { get; set; }
        /// <summary>The timestamp of the date and time the item was updated, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>Total amount of the variance of a budget, equals to ``projectedBudget`` - ``projectedCost``.</summary>
        public double? VarianceTotal { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.Models.Contract"/> and sets the default values.
        /// </summary>
        public Contract()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.Contract"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.Models.Contract CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.Models.Contract();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "actualCost", n => { ActualCost = n.GetDoubleValue(); } },
                { "approvedAt", n => { ApprovedAt = n.GetDateTimeOffsetValue(); } },
                { "approvedChangeOrders", n => { ApprovedChangeOrders = n.GetDoubleValue(); } },
                { "approvedInScopeChangeOrders", n => { ApprovedInScopeChangeOrders = n.GetDoubleValue(); } },
                { "approvedOwnerChanges", n => { ApprovedOwnerChanges = n.GetDoubleValue(); } },
                { "awarded", n => { Awarded = n.GetDoubleValue(); } },
                { "awardedAt", n => { AwardedAt = n.GetDateTimeOffsetValue(); } },
                { "budgets", n => { Budgets = n.GetCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.Contract_budgets>(global::Autodesk.ACC.CostManagement.Models.Contract_budgets.CreateFromDiscriminatorValue)?.AsList(); } },
                { "changedBy", n => { ChangedBy = n.GetStringValue(); } },
                { "code", n => { Code = n.GetStringValue(); } },
                { "companyId", n => { CompanyId = n.GetStringValue(); } },
                { "compounded", n => { Compounded = n.GetObjectValue<global::Autodesk.ACC.CostManagement.Models.Contract_compounded>(global::Autodesk.ACC.CostManagement.Models.Contract_compounded.CreateFromDiscriminatorValue); } },
                { "contactId", n => { ContactId = n.GetStringValue(); } },
                { "createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "creatorId", n => { CreatorId = n.GetStringValue(); } },
                { "currency", n => { Currency = n.GetStringValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "documentGeneratedAt", n => { DocumentGeneratedAt = n.GetDateTimeOffsetValue(); } },
                { "exchangeRate", n => { ExchangeRate = n.GetStringValue(); } },
                { "externalId", n => { ExternalId = n.GetStringValue(); } },
                { "externalMessage", n => { ExternalMessage = n.GetStringValue(); } },
                { "externalSystem", n => { ExternalSystem = n.GetStringValue(); } },
                { "forecastCostComplete", n => { ForecastCostComplete = n.GetDoubleValue(); } },
                { "forecastExchanageRate", n => { ForecastExchanageRate = n.GetStringValue(); } },
                { "forecastExchangeRateUpdatedAt", n => { ForecastExchangeRateUpdatedAt = n.GetDateTimeOffsetValue(); } },
                { "forecastFinalCost", n => { ForecastFinalCost = n.GetDoubleValue(); } },
                { "forecastVariance", n => { ForecastVariance = n.GetDoubleValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "integrationState", n => { IntegrationState = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.Contract_integrationState>(); } },
                { "integrationStateChangedAt", n => { IntegrationStateChangedAt = n.GetDateTimeOffsetValue(); } },
                { "integrationStateChangedBy", n => { IntegrationStateChangedBy = n.GetStringValue(); } },
                { "internalAdjustment", n => { InternalAdjustment = n.GetDoubleValue(); } },
                { "lastSyncTime", n => { LastSyncTime = n.GetDateTimeOffsetValue(); } },
                { "mainContractId", n => { MainContractId = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "note", n => { Note = n.GetStringValue(); } },
                { "offsiteAt", n => { OffsiteAt = n.GetDateTimeOffsetValue(); } },
                { "onsiteAt", n => { OnsiteAt = n.GetDateTimeOffsetValue(); } },
                { "originalBudget", n => { OriginalBudget = n.GetDoubleValue(); } },
                { "ownerId", n => { OwnerId = n.GetStringValue(); } },
                { "paymentDue", n => { PaymentDue = n.GetIntValue(); } },
                { "paymentDueType", n => { PaymentDueType = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.Contract_paymentDueType>(); } },
                { "pendingChangeOrders", n => { PendingChangeOrders = n.GetDoubleValue(); } },
                { "pendingOwnerChanges", n => { PendingOwnerChanges = n.GetDoubleValue(); } },
                { "procuredAt", n => { ProcuredAt = n.GetStringValue(); } },
                { "projectedBudget", n => { ProjectedBudget = n.GetDoubleValue(); } },
                { "projectedCost", n => { ProjectedCost = n.GetDoubleValue(); } },
                { "reserves", n => { Reserves = n.GetDoubleValue(); } },
                { "respondedAt", n => { RespondedAt = n.GetDateTimeOffsetValue(); } },
                { "responseDue", n => { ResponseDue = n.GetDateTimeOffsetValue(); } },
                { "retentionCap", n => { RetentionCap = n.GetDoubleValue(); } },
                { "returnedAt", n => { ReturnedAt = n.GetDateTimeOffsetValue(); } },
                { "revised", n => { Revised = n.GetDoubleValue(); } },
                { "scheduleOfValues", n => { ScheduleOfValues = n.GetCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.SOV>(global::Autodesk.ACC.CostManagement.Models.SOV.CreateFromDiscriminatorValue)?.AsList(); } },
                { "scopeOfWork", n => { ScopeOfWork = n.GetStringValue(); } },
                { "sentAt", n => { SentAt = n.GetDateTimeOffsetValue(); } },
                { "signedBy", n => { SignedBy = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.Contract_status>(); } },
                { "statusChangedAt", n => { StatusChangedAt = n.GetDateTimeOffsetValue(); } },
                { "type", n => { Type = n.GetStringValue(); } },
                { "uncommitted", n => { Uncommitted = n.GetDoubleValue(); } },
                { "updatedAt", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                { "varianceTotal", n => { VarianceTotal = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("actualCost", ActualCost);
            writer.WriteDateTimeOffsetValue("approvedAt", ApprovedAt);
            writer.WriteDoubleValue("approvedChangeOrders", ApprovedChangeOrders);
            writer.WriteDoubleValue("approvedInScopeChangeOrders", ApprovedInScopeChangeOrders);
            writer.WriteDoubleValue("approvedOwnerChanges", ApprovedOwnerChanges);
            writer.WriteDoubleValue("awarded", Awarded);
            writer.WriteDateTimeOffsetValue("awardedAt", AwardedAt);
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.Contract_budgets>("budgets", Budgets);
            writer.WriteStringValue("code", Code);
            writer.WriteStringValue("companyId", CompanyId);
            writer.WriteObjectValue<global::Autodesk.ACC.CostManagement.Models.Contract_compounded>("compounded", Compounded);
            writer.WriteStringValue("contactId", ContactId);
            writer.WriteStringValue("currency", Currency);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("exchangeRate", ExchangeRate);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteStringValue("externalMessage", ExternalMessage);
            writer.WriteStringValue("externalSystem", ExternalSystem);
            writer.WriteDoubleValue("forecastCostComplete", ForecastCostComplete);
            writer.WriteStringValue("forecastExchanageRate", ForecastExchanageRate);
            writer.WriteDateTimeOffsetValue("forecastExchangeRateUpdatedAt", ForecastExchangeRateUpdatedAt);
            writer.WriteDoubleValue("forecastFinalCost", ForecastFinalCost);
            writer.WriteDoubleValue("forecastVariance", ForecastVariance);
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.Contract_integrationState>("integrationState", IntegrationState);
            writer.WriteDateTimeOffsetValue("integrationStateChangedAt", IntegrationStateChangedAt);
            writer.WriteStringValue("integrationStateChangedBy", IntegrationStateChangedBy);
            writer.WriteDoubleValue("internalAdjustment", InternalAdjustment);
            writer.WriteStringValue("mainContractId", MainContractId);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("note", Note);
            writer.WriteDateTimeOffsetValue("offsiteAt", OffsiteAt);
            writer.WriteDateTimeOffsetValue("onsiteAt", OnsiteAt);
            writer.WriteDoubleValue("originalBudget", OriginalBudget);
            writer.WriteStringValue("ownerId", OwnerId);
            writer.WriteIntValue("paymentDue", PaymentDue);
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.Contract_paymentDueType>("paymentDueType", PaymentDueType);
            writer.WriteDoubleValue("pendingChangeOrders", PendingChangeOrders);
            writer.WriteDoubleValue("pendingOwnerChanges", PendingOwnerChanges);
            writer.WriteStringValue("procuredAt", ProcuredAt);
            writer.WriteDoubleValue("projectedBudget", ProjectedBudget);
            writer.WriteDoubleValue("projectedCost", ProjectedCost);
            writer.WriteDoubleValue("reserves", Reserves);
            writer.WriteDateTimeOffsetValue("respondedAt", RespondedAt);
            writer.WriteDateTimeOffsetValue("responseDue", ResponseDue);
            writer.WriteDoubleValue("retentionCap", RetentionCap);
            writer.WriteDateTimeOffsetValue("returnedAt", ReturnedAt);
            writer.WriteDoubleValue("revised", Revised);
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.SOV>("scheduleOfValues", ScheduleOfValues);
            writer.WriteStringValue("scopeOfWork", ScopeOfWork);
            writer.WriteDateTimeOffsetValue("sentAt", SentAt);
            writer.WriteStringValue("signedBy", SignedBy);
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.Contract_status>("status", Status);
            writer.WriteStringValue("type", Type);
            writer.WriteDoubleValue("uncommitted", Uncommitted);
            writer.WriteDoubleValue("varianceTotal", VarianceTotal);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
