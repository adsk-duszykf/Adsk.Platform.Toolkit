// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.CostManagement.Models
{
    /// <summary>
    /// Budget code template and budget segment codes used in the budget. Not applicable for sub-budget.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class BudgetSync_current_data_budgetCode : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The segments of the budget code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.CostManagement.Models.BudgetCodeSegment>? BudgetCodeSegments { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.CostManagement.Models.BudgetCodeSegment> BudgetCodeSegments { get; set; }
#endif
        /// <summary>Unique identifier of the budget code template used by the budget.</summary>
        public Guid? BudgetCodeTemplateId { get; set; }
        /// <summary>Unique identifier of the budget code.</summary>
        public Guid? Id { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.Models.BudgetSync_current_data_budgetCode"/> and sets the default values.
        /// </summary>
        public BudgetSync_current_data_budgetCode()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.BudgetSync_current_data_budgetCode"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.Models.BudgetSync_current_data_budgetCode CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.Models.BudgetSync_current_data_budgetCode();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "budgetCodeSegments", n => { BudgetCodeSegments = n.GetCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.BudgetCodeSegment>(global::Autodesk.ACC.CostManagement.Models.BudgetCodeSegment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "budgetCodeTemplateId", n => { BudgetCodeTemplateId = n.GetGuidValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.BudgetCodeSegment>("budgetCodeSegments", BudgetCodeSegments);
            writer.WriteGuidValue("budgetCodeTemplateId", BudgetCodeTemplateId);
            writer.WriteGuidValue("id", Id);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
