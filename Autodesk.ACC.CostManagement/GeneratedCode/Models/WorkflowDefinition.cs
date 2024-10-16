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
    public partial class WorkflowDefinition : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The type of the associated module.</summary>
        public global::Autodesk.ACC.CostManagement.Models.WorkflowDefinition_associationType? AssociationType { get; set; }
        /// <summary>Unique identifier of the bpmn container.</summary>
        public Guid? BpmnContainerId { get; set; }
        /// <summary>Unique identifier of the bpmn definition.</summary>
        public Guid? BpmnDefinitionId { get; set; }
        /// <summary>The last updator of this workflow definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChangedBy { get; set; }
#nullable restore
#else
        public string ChangedBy { get; set; }
#endif
        /// <summary>The timestamp of the date and time the item was created, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>The creator of this workflow definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatorId { get; set; }
#nullable restore
#else
        public string CreatorId { get; set; }
#endif
        /// <summary>Unique identifier of the workflow definition.</summary>
        public Guid? Id { get; private set; }
        /// <summary>The steps of this workflow definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.CostManagement.Models.WorkflowStep>? Steps { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.CostManagement.Models.WorkflowStep> Steps { get; set; }
#endif
        /// <summary>The title of this workflow definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>The type of this workflow definition.</summary>
        public global::Autodesk.ACC.CostManagement.Models.WorkflowDefinition_type? Type { get; set; }
        /// <summary>The timestamp of the date and time the item was updated, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>Unique identifier of the workflow template.</summary>
        public Guid? WorkflowTemplateId { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.Models.WorkflowDefinition"/> and sets the default values.
        /// </summary>
        public WorkflowDefinition()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.WorkflowDefinition"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.Models.WorkflowDefinition CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.Models.WorkflowDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "associationType", n => { AssociationType = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.WorkflowDefinition_associationType>(); } },
                { "bpmnContainerId", n => { BpmnContainerId = n.GetGuidValue(); } },
                { "bpmnDefinitionId", n => { BpmnDefinitionId = n.GetGuidValue(); } },
                { "changedBy", n => { ChangedBy = n.GetStringValue(); } },
                { "createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "creatorId", n => { CreatorId = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "steps", n => { Steps = n.GetCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.WorkflowStep>(global::Autodesk.ACC.CostManagement.Models.WorkflowStep.CreateFromDiscriminatorValue)?.AsList(); } },
                { "title", n => { Title = n.GetStringValue(); } },
                { "type", n => { Type = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.WorkflowDefinition_type>(); } },
                { "updatedAt", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                { "workflowTemplateId", n => { WorkflowTemplateId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.WorkflowDefinition_associationType>("associationType", AssociationType);
            writer.WriteGuidValue("bpmnContainerId", BpmnContainerId);
            writer.WriteGuidValue("bpmnDefinitionId", BpmnDefinitionId);
            writer.WriteStringValue("changedBy", ChangedBy);
            writer.WriteStringValue("creatorId", CreatorId);
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.WorkflowStep>("steps", Steps);
            writer.WriteStringValue("title", Title);
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.WorkflowDefinition_type>("type", Type);
            writer.WriteGuidValue("workflowTemplateId", WorkflowTemplateId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
