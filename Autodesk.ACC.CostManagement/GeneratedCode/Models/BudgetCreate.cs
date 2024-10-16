// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.CostManagement.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class BudgetCreate : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The planned start day of the item.</summary>
        public Date? ActualEndDate { get; set; }
        /// <summary>The actual start day of the item.</summary>
        public Date? ActualStartDate { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Unique code compliant with the budget code template defined by the project admin. Ignored if ``segmentCodeMap`` is defined.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Code { get; set; }
#nullable restore
#else
        public string Code { get; set; }
#endif
        /// <summary>Detail description of the budget.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The duration days of the item.</summary>
        public double? DurationDays { get; set; }
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
        /// <summary>Uniq identifier of the budget to create.</summary>
        public Guid? Id { get; set; }
        /// <summary>Input quantity planned for the budget.</summary>
        public double? InputQuantity { get; set; }
        /// <summary>Lock state used by ERP integration, default value is ``null``.</summary>
        public global::Autodesk.ACC.CostManagement.Models.BudgetCreate_integrationState? IntegrationState { get; set; }
        /// <summary>The IDs of the locations have been selected and parents of selected.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Guid?>? LocationPaths { get; set; }
#nullable restore
#else
        public List<Guid?> LocationPaths { get; set; }
#endif
        /// <summary>The IDs of the locations have been selected.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Guid?>? Locations { get; set; }
#nullable restore
#else
        public List<Guid?> Locations { get; set; }
#endif
        /// <summary>The ID of the milestone that the budget is linked to.</summary>
        public Guid? MilestoneId { get; set; }
        /// <summary>Name of the budget.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>ID of the parent budget, used only when creating sub budgets.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParentId { get; set; }
#nullable restore
#else
        public string ParentId { get; set; }
#endif
        /// <summary>The planned end day of the item.</summary>
        public Date? PlannedEndDate { get; set; }
        /// <summary>The planned start day of the item.</summary>
        public Date? PlannedStartDate { get; set; }
        /// <summary>Quantity of labor, material,... planned for a budget.</summary>
        public double? Quantity { get; set; }
        /// <summary>Map of budget code segments to be used in the budget code, required when updating root budget code with variable length segment. Key is the budget code segment ID, value is the code for the segment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.CostManagement.Models.BudgetCreate_segmentCodeMap? SegmentCodeMap { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.CostManagement.Models.BudgetCreate_segmentCodeMap SegmentCodeMap { get; set; }
#endif
        /// <summary>Unit of measures used in the budget.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Unit { get; set; }
#nullable restore
#else
        public string Unit { get; set; }
#endif
        /// <summary>Unit price of a budget.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UnitPrice { get; set; }
#nullable restore
#else
        public string UnitPrice { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.Models.BudgetCreate"/> and sets the default values.
        /// </summary>
        public BudgetCreate()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.BudgetCreate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.Models.BudgetCreate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.Models.BudgetCreate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "actualEndDate", n => { ActualEndDate = n.GetDateValue(); } },
                { "actualStartDate", n => { ActualStartDate = n.GetDateValue(); } },
                { "code", n => { Code = n.GetStringValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "durationDays", n => { DurationDays = n.GetDoubleValue(); } },
                { "externalId", n => { ExternalId = n.GetStringValue(); } },
                { "externalMessage", n => { ExternalMessage = n.GetStringValue(); } },
                { "externalSystem", n => { ExternalSystem = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "inputQuantity", n => { InputQuantity = n.GetDoubleValue(); } },
                { "integrationState", n => { IntegrationState = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.BudgetCreate_integrationState>(); } },
                { "locationPaths", n => { LocationPaths = n.GetCollectionOfPrimitiveValues<Guid?>()?.AsList(); } },
                { "locations", n => { Locations = n.GetCollectionOfPrimitiveValues<Guid?>()?.AsList(); } },
                { "milestoneId", n => { MilestoneId = n.GetGuidValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "parentId", n => { ParentId = n.GetStringValue(); } },
                { "plannedEndDate", n => { PlannedEndDate = n.GetDateValue(); } },
                { "plannedStartDate", n => { PlannedStartDate = n.GetDateValue(); } },
                { "quantity", n => { Quantity = n.GetDoubleValue(); } },
                { "segmentCodeMap", n => { SegmentCodeMap = n.GetObjectValue<global::Autodesk.ACC.CostManagement.Models.BudgetCreate_segmentCodeMap>(global::Autodesk.ACC.CostManagement.Models.BudgetCreate_segmentCodeMap.CreateFromDiscriminatorValue); } },
                { "unit", n => { Unit = n.GetStringValue(); } },
                { "unitPrice", n => { UnitPrice = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateValue("actualEndDate", ActualEndDate);
            writer.WriteDateValue("actualStartDate", ActualStartDate);
            writer.WriteStringValue("code", Code);
            writer.WriteStringValue("description", Description);
            writer.WriteDoubleValue("durationDays", DurationDays);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteStringValue("externalMessage", ExternalMessage);
            writer.WriteStringValue("externalSystem", ExternalSystem);
            writer.WriteGuidValue("id", Id);
            writer.WriteDoubleValue("inputQuantity", InputQuantity);
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.BudgetCreate_integrationState>("integrationState", IntegrationState);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("locationPaths", LocationPaths);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("locations", Locations);
            writer.WriteGuidValue("milestoneId", MilestoneId);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("parentId", ParentId);
            writer.WriteDateValue("plannedEndDate", PlannedEndDate);
            writer.WriteDateValue("plannedStartDate", PlannedStartDate);
            writer.WriteDoubleValue("quantity", Quantity);
            writer.WriteObjectValue<global::Autodesk.ACC.CostManagement.Models.BudgetCreate_segmentCodeMap>("segmentCodeMap", SegmentCodeMap);
            writer.WriteStringValue("unit", Unit);
            writer.WriteStringValue("unitPrice", UnitPrice);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
