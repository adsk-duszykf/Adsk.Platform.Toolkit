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
    public partial class Refs_data_attributes_extension_data : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The conformingStatus property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConformingStatus { get; set; }
#nullable restore
#else
        public string ConformingStatus { get; set; }
#endif
        /// <summary>The properties property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.Refs_data_attributes_extension_data_properties? Properties { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.Refs_data_attributes_extension_data_properties Properties { get; set; }
#endif
        /// <summary>The storageType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StorageType { get; set; }
#nullable restore
#else
        public string StorageType { get; set; }
#endif
        /// <summary>The storageUrn property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StorageUrn { get; set; }
#nullable restore
#else
        public string StorageUrn { get; set; }
#endif
        /// <summary>The tempUrn property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TempUrn { get; set; }
#nullable restore
#else
        public string TempUrn { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.DataManagement.Models.Refs_data_attributes_extension_data"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.DataManagement.Models.Refs_data_attributes_extension_data CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.DataManagement.Models.Refs_data_attributes_extension_data();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "conformingStatus", n => { ConformingStatus = n.GetStringValue(); } },
                { "properties", n => { Properties = n.GetObjectValue<global::Autodesk.DataManagement.Models.Refs_data_attributes_extension_data_properties>(global::Autodesk.DataManagement.Models.Refs_data_attributes_extension_data_properties.CreateFromDiscriminatorValue); } },
                { "storageType", n => { StorageType = n.GetStringValue(); } },
                { "storageUrn", n => { StorageUrn = n.GetStringValue(); } },
                { "tempUrn", n => { TempUrn = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("conformingStatus", ConformingStatus);
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.Refs_data_attributes_extension_data_properties>("properties", Properties);
            writer.WriteStringValue("storageType", StorageType);
            writer.WriteStringValue("storageUrn", StorageUrn);
            writer.WriteStringValue("tempUrn", TempUrn);
        }
    }
}
#pragma warning restore CS0618
