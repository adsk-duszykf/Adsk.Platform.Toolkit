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
    public partial class CustomColumn_settings : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The column name of a column formula setting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ColumnName { get; set; }
#nullable restore
#else
        public string ColumnName { get; set; }
#endif
        /// <summary>The custom name of a column formula setting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomName { get; set; }
#nullable restore
#else
        public string CustomName { get; set; }
#endif
        /// <summary>The expression of a column formula setting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Expression { get; set; }
#nullable restore
#else
        public string Expression { get; set; }
#endif
        /// <summary>The format of a column formula setting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Format { get; set; }
#nullable restore
#else
        public string Format { get; set; }
#endif
        /// <summary>The custom of a column formula setting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Group { get; set; }
#nullable restore
#else
        public string Group { get; set; }
#endif
        /// <summary>Whether a sys column formula setting.</summary>
        public bool? IsCustom { get; set; }
        /// <summary>The visibility of a column formula setting.</summary>
        public bool? IsVisible { get; set; }
        /// <summary>The unique identifier of a column formula setting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Label { get; set; }
#nullable restore
#else
        public string Label { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.Models.CustomColumn_settings"/> and sets the default values.
        /// </summary>
        public CustomColumn_settings()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.CustomColumn_settings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.Models.CustomColumn_settings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.Models.CustomColumn_settings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "columnName", n => { ColumnName = n.GetStringValue(); } },
                { "customName", n => { CustomName = n.GetStringValue(); } },
                { "expression", n => { Expression = n.GetStringValue(); } },
                { "format", n => { Format = n.GetStringValue(); } },
                { "group", n => { Group = n.GetStringValue(); } },
                { "isCustom", n => { IsCustom = n.GetBoolValue(); } },
                { "isVisible", n => { IsVisible = n.GetBoolValue(); } },
                { "label", n => { Label = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("columnName", ColumnName);
            writer.WriteStringValue("customName", CustomName);
            writer.WriteStringValue("expression", Expression);
            writer.WriteStringValue("format", Format);
            writer.WriteStringValue("group", Group);
            writer.WriteBoolValue("isCustom", IsCustom);
            writer.WriteBoolValue("isVisible", IsVisible);
            writer.WriteStringValue("label", Label);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
