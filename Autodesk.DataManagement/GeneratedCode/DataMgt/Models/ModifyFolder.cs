// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.DataManagement.Models
{
    /// <summary>
    /// Modifies folder names
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ModifyFolder : IParsable
    {
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.ModifyFolder_data? Data { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.ModifyFolder_data Data { get; set; }
#endif
        /// <summary>The jsonapi property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.ModifyFolder_jsonapi? Jsonapi { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.ModifyFolder_jsonapi Jsonapi { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.DataManagement.Models.ModifyFolder"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.DataManagement.Models.ModifyFolder CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.DataManagement.Models.ModifyFolder();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "data", n => { Data = n.GetObjectValue<global::Autodesk.DataManagement.Models.ModifyFolder_data>(global::Autodesk.DataManagement.Models.ModifyFolder_data.CreateFromDiscriminatorValue); } },
                { "jsonapi", n => { Jsonapi = n.GetObjectValue<global::Autodesk.DataManagement.Models.ModifyFolder_jsonapi>(global::Autodesk.DataManagement.Models.ModifyFolder_jsonapi.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.ModifyFolder_data>("data", Data);
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.ModifyFolder_jsonapi>("jsonapi", Jsonapi);
        }
    }
}
#pragma warning restore CS0618
