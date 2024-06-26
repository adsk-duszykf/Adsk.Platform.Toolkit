// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.DataManagement.Models {
    /// <summary>
    /// Successful retrieval of a specific version.
    /// </summary>
    public class VersionObject : IParsable 
    {
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Version_data? Data { get; set; }
#nullable restore
#else
        public Version_data Data { get; set; }
#endif
        /// <summary>The jsonapi property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Version_jsonapi? Jsonapi { get; set; }
#nullable restore
#else
        public Version_jsonapi Jsonapi { get; set; }
#endif
        /// <summary>The links property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Version_links? Links { get; set; }
#nullable restore
#else
        public Version_links Links { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="VersionObject"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static VersionObject CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VersionObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"data", n => { Data = n.GetObjectValue<Version_data>(Version_data.CreateFromDiscriminatorValue); } },
                {"jsonapi", n => { Jsonapi = n.GetObjectValue<Version_jsonapi>(Version_jsonapi.CreateFromDiscriminatorValue); } },
                {"links", n => { Links = n.GetObjectValue<Version_links>(Version_links.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Version_data>("data", Data);
            writer.WriteObjectValue<Version_jsonapi>("jsonapi", Jsonapi);
            writer.WriteObjectValue<Version_links>("links", Links);
        }
    }
}
