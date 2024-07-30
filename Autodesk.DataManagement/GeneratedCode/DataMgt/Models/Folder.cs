// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.DataManagement.Models
{
    /// <summary>
    /// Successful retrieval of a specific folder.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class Folder : IParsable
    {
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.Folder_data? Data { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.Folder_data Data { get; set; }
#endif
        /// <summary>The jsonapi property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.Folder_jsonapi? Jsonapi { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.Folder_jsonapi Jsonapi { get; set; }
#endif
        /// <summary>The links property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.Folder_links? Links { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.Folder_links Links { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.DataManagement.Models.Folder"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.DataManagement.Models.Folder CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.DataManagement.Models.Folder();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "data", n => { Data = n.GetObjectValue<global::Autodesk.DataManagement.Models.Folder_data>(global::Autodesk.DataManagement.Models.Folder_data.CreateFromDiscriminatorValue); } },
                { "jsonapi", n => { Jsonapi = n.GetObjectValue<global::Autodesk.DataManagement.Models.Folder_jsonapi>(global::Autodesk.DataManagement.Models.Folder_jsonapi.CreateFromDiscriminatorValue); } },
                { "links", n => { Links = n.GetObjectValue<global::Autodesk.DataManagement.Models.Folder_links>(global::Autodesk.DataManagement.Models.Folder_links.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.Folder_data>("data", Data);
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.Folder_jsonapi>("jsonapi", Jsonapi);
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.Folder_links>("links", Links);
        }
    }
}
