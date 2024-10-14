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
    public partial class MarkupSummary : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Amount approved by the owner.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Approved { get; set; }
#nullable restore
#else
        public string Approved { get; set; }
#endif
        /// <summary>Amount committed to the supplier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Committed { get; set; }
#nullable restore
#else
        public string Committed { get; set; }
#endif
        /// <summary>Rough estimate of this item without a quotation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Estimated { get; set; }
#nullable restore
#else
        public string Estimated { get; set; }
#endif
        /// <summary>The markupFormulaId property</summary>
        public Guid? MarkupFormulaId { get; set; }
        /// <summary>The markupFormulaItemId property</summary>
        public Guid? MarkupFormulaItemId { get; set; }
        /// <summary>Quoted cost of the item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Proposed { get; set; }
#nullable restore
#else
        public string Proposed { get; set; }
#endif
        /// <summary>Amount sent to the owner for approval.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Submitted { get; set; }
#nullable restore
#else
        public string Submitted { get; set; }
#endif
        /// <summary>The targetCostItemId property</summary>
        public Guid? TargetCostItemId { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.Models.MarkupSummary"/> and sets the default values.
        /// </summary>
        public MarkupSummary()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.MarkupSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.Models.MarkupSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.Models.MarkupSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "approved", n => { Approved = n.GetStringValue(); } },
                { "committed", n => { Committed = n.GetStringValue(); } },
                { "estimated", n => { Estimated = n.GetStringValue(); } },
                { "markupFormulaId", n => { MarkupFormulaId = n.GetGuidValue(); } },
                { "markupFormulaItemId", n => { MarkupFormulaItemId = n.GetGuidValue(); } },
                { "proposed", n => { Proposed = n.GetStringValue(); } },
                { "submitted", n => { Submitted = n.GetStringValue(); } },
                { "targetCostItemId", n => { TargetCostItemId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("approved", Approved);
            writer.WriteStringValue("committed", Committed);
            writer.WriteStringValue("estimated", Estimated);
            writer.WriteGuidValue("markupFormulaId", MarkupFormulaId);
            writer.WriteGuidValue("markupFormulaItemId", MarkupFormulaItemId);
            writer.WriteStringValue("proposed", Proposed);
            writer.WriteStringValue("submitted", Submitted);
            writer.WriteGuidValue("targetCostItemId", TargetCostItemId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
