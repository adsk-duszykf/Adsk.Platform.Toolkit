// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ModelDerivative.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class AllProperties_data_collection : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The externalId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId { get; set; }
#nullable restore
#else
        public string ExternalId { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The objectid property</summary>
        public double? Objectid { get; set; }
        /// <summary>The properties property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ModelDerivative.Models.AllProperties_data_collection_properties? Properties { get; set; }
#nullable restore
#else
        public global::Autodesk.ModelDerivative.Models.AllProperties_data_collection_properties Properties { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ModelDerivative.Models.AllProperties_data_collection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ModelDerivative.Models.AllProperties_data_collection CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ModelDerivative.Models.AllProperties_data_collection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "externalId", n => { ExternalId = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "objectid", n => { Objectid = n.GetDoubleValue(); } },
                { "properties", n => { Properties = n.GetObjectValue<global::Autodesk.ModelDerivative.Models.AllProperties_data_collection_properties>(global::Autodesk.ModelDerivative.Models.AllProperties_data_collection_properties.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteStringValue("name", Name);
            writer.WriteDoubleValue("objectid", Objectid);
            writer.WriteObjectValue<global::Autodesk.ModelDerivative.Models.AllProperties_data_collection_properties>("properties", Properties);
        }
    }
}
#pragma warning restore CS0618
