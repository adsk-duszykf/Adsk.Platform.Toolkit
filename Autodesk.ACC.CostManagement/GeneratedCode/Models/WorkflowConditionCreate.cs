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
    public partial class WorkflowConditionCreate : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The type of the associated module.</summary>
        public global::Autodesk.ACC.CostManagement.Models.WorkflowConditionCreate_associationType? AssociationType { get; set; }
        /// <summary>The rules of this workflow condition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.CostManagement.Models.WorkflowConditionRule>? Rules { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.CostManagement.Models.WorkflowConditionRule> Rules { get; set; }
#endif
        /// <summary>Unique identifier of the workflow definition.</summary>
        public Guid? WorkflowDefinitionId { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.Models.WorkflowConditionCreate"/> and sets the default values.
        /// </summary>
        public WorkflowConditionCreate()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.WorkflowConditionCreate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.Models.WorkflowConditionCreate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.Models.WorkflowConditionCreate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "associationType", n => { AssociationType = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.WorkflowConditionCreate_associationType>(); } },
                { "rules", n => { Rules = n.GetCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.WorkflowConditionRule>(global::Autodesk.ACC.CostManagement.Models.WorkflowConditionRule.CreateFromDiscriminatorValue)?.AsList(); } },
                { "workflowDefinitionId", n => { WorkflowDefinitionId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.WorkflowConditionCreate_associationType>("associationType", AssociationType);
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.WorkflowConditionRule>("rules", Rules);
            writer.WriteGuidValue("workflowDefinitionId", WorkflowDefinitionId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
