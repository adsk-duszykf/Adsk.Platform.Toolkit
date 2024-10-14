// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.DataManagement.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Refs_data_attributes_extension : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.Refs_data_attributes_extension_data? Data { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.Refs_data_attributes_extension_data Data { get; set; }
#endif
        /// <summary>The schema property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.Refs_data_attributes_extension_schema? Schema { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.Refs_data_attributes_extension_schema Schema { get; set; }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>The version property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version { get; set; }
#nullable restore
#else
        public string Version { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.DataManagement.Models.Refs_data_attributes_extension"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.DataManagement.Models.Refs_data_attributes_extension CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.DataManagement.Models.Refs_data_attributes_extension();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "data", n => { Data = n.GetObjectValue<global::Autodesk.DataManagement.Models.Refs_data_attributes_extension_data>(global::Autodesk.DataManagement.Models.Refs_data_attributes_extension_data.CreateFromDiscriminatorValue); } },
                { "schema", n => { Schema = n.GetObjectValue<global::Autodesk.DataManagement.Models.Refs_data_attributes_extension_schema>(global::Autodesk.DataManagement.Models.Refs_data_attributes_extension_schema.CreateFromDiscriminatorValue); } },
                { "type", n => { Type = n.GetStringValue(); } },
                { "version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.Refs_data_attributes_extension_data>("data", Data);
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.Refs_data_attributes_extension_schema>("schema", Schema);
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("version", Version);
        }
    }
}
#pragma warning restore CS0618
