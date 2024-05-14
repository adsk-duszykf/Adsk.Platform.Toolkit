// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.FileManagement.Projects.Item.Versions.Item.CustomAttributesBatchUpdate {
    public class CustomAttributesBatchUpdate : IParsable 
    {
        /// <summary>The ID of the custom attribute. To find the ID, call GET custom-attribute-definitions.</summary>
        public int? Id { get; set; }
        /// <summary>The value of the custom attribute. If you are assigning a value to a drop-list attribute, call GET custom-attribute-definitions to retrieve a list of possible values. If you are clearing a custom attribute value, assign a null value to the attribute.  - For text field (string) attributes, the max length is 255.  - Date attributes need to be compliant with ISO8601. Milliseconds are discarded.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Value { get; set; }
#nullable restore
#else
        public string Value { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CustomAttributesBatchUpdate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CustomAttributesBatchUpdate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomAttributesBatchUpdate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"id", n => { Id = n.GetIntValue(); } },
                {"value", n => { Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("value", Value);
        }
    }
}