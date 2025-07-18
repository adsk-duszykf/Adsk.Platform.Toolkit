// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.AccountAdmin.Models
{
    /// <summary>
    /// Options related to project template
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ProjectTemplate_options : IParsable
    {
        /// <summary>Project template options specific to classic field</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.AccountAdmin.Models.ProjectTemplate_options_field? Field { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.AccountAdmin.Models.ProjectTemplate_options_field Field { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.AccountAdmin.Models.ProjectTemplate_options"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.AccountAdmin.Models.ProjectTemplate_options CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.AccountAdmin.Models.ProjectTemplate_options();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "field", n => { Field = n.GetObjectValue<global::Autodesk.ACC.AccountAdmin.Models.ProjectTemplate_options_field>(global::Autodesk.ACC.AccountAdmin.Models.ProjectTemplate_options_field.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Autodesk.ACC.AccountAdmin.Models.ProjectTemplate_options_field>("field", Field);
        }
    }
}
#pragma warning restore CS0618
