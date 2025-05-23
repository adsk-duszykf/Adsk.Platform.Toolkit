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
    public partial class CreateVersion_data_relationships : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The item property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.CreateVersion_data_relationships_item? Item { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.CreateVersion_data_relationships_item Item { get; set; }
#endif
        /// <summary>The refs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.CreateVersion_data_relationships_refs? Refs { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.CreateVersion_data_relationships_refs Refs { get; set; }
#endif
        /// <summary>The storage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.CreateVersion_data_relationships_storage? Storage { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.CreateVersion_data_relationships_storage Storage { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.DataManagement.Models.CreateVersion_data_relationships"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.DataManagement.Models.CreateVersion_data_relationships CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.DataManagement.Models.CreateVersion_data_relationships();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "item", n => { Item = n.GetObjectValue<global::Autodesk.DataManagement.Models.CreateVersion_data_relationships_item>(global::Autodesk.DataManagement.Models.CreateVersion_data_relationships_item.CreateFromDiscriminatorValue); } },
                { "refs", n => { Refs = n.GetObjectValue<global::Autodesk.DataManagement.Models.CreateVersion_data_relationships_refs>(global::Autodesk.DataManagement.Models.CreateVersion_data_relationships_refs.CreateFromDiscriminatorValue); } },
                { "storage", n => { Storage = n.GetObjectValue<global::Autodesk.DataManagement.Models.CreateVersion_data_relationships_storage>(global::Autodesk.DataManagement.Models.CreateVersion_data_relationships_storage.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.CreateVersion_data_relationships_item>("item", Item);
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.CreateVersion_data_relationships_refs>("refs", Refs);
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.CreateVersion_data_relationships_storage>("storage", Storage);
        }
    }
}
#pragma warning restore CS0618
