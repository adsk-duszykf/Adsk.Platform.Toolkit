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
    public partial class Workflow_constraints : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The actionRules property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.CostManagement.Models.Workflow_constraints_actionRules>? ActionRules { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.CostManagement.Models.Workflow_constraints_actionRules> ActionRules { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The attributeRules property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.CostManagement.Models.Workflow_constraints_attributeRules>? AttributeRules { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.CostManagement.Models.Workflow_constraints_attributeRules> AttributeRules { get; set; }
#endif
        /// <summary>The key property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Key { get; set; }
#nullable restore
#else
        public string Key { get; set; }
#endif
        /// <summary>The statusType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StatusType { get; set; }
#nullable restore
#else
        public string StatusType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.Models.Workflow_constraints"/> and sets the default values.
        /// </summary>
        public Workflow_constraints()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.Workflow_constraints"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.Models.Workflow_constraints CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.Models.Workflow_constraints();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "actionRules", n => { ActionRules = n.GetCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.Workflow_constraints_actionRules>(global::Autodesk.ACC.CostManagement.Models.Workflow_constraints_actionRules.CreateFromDiscriminatorValue)?.AsList(); } },
                { "attributeRules", n => { AttributeRules = n.GetCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.Workflow_constraints_attributeRules>(global::Autodesk.ACC.CostManagement.Models.Workflow_constraints_attributeRules.CreateFromDiscriminatorValue)?.AsList(); } },
                { "key", n => { Key = n.GetStringValue(); } },
                { "statusType", n => { StatusType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.Workflow_constraints_actionRules>("actionRules", ActionRules);
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.Workflow_constraints_attributeRules>("attributeRules", AttributeRules);
            writer.WriteStringValue("key", Key);
            writer.WriteStringValue("statusType", StatusType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
