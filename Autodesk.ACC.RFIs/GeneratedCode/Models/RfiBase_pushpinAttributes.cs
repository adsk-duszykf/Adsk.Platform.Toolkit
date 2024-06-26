// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.RFIs.Models {
    /// <summary>
    /// BIM360: Data about the pushpin RFI. Only relevant for pushpin RFIs. For more details, see the  `RFI pushpin tutorials. &lt;/en/docs/bim360/v1/tutorials/create-pushpin/&gt;`_ACC: Not relevant.
    /// </summary>
    public class RfiBase_pushpinAttributes : IParsable 
    {
        /// <summary>timestamp when pushpin created</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>Autodesk ID of the user that created the pushpin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedBy { get; set; }
#nullable restore
#else
        public string CreatedBy { get; set; }
#endif
        /// <summary>doc version when RFI was created on</summary>
        public int? CreatedDocVersion { get; set; }
        /// <summary>The location object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RfiBase_pushpinAttributes_location? Location { get; set; }
#nullable restore
#else
        public RfiBase_pushpinAttributes_location Location { get; set; }
#endif
        /// <summary>The type of pushpin.</summary>
        public RfiBase_pushpinAttributes_type? Type { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RfiBase_pushpinAttributes"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RfiBase_pushpinAttributes CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RfiBase_pushpinAttributes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"createdBy", n => { CreatedBy = n.GetStringValue(); } },
                {"createdDocVersion", n => { CreatedDocVersion = n.GetIntValue(); } },
                {"location", n => { Location = n.GetObjectValue<RfiBase_pushpinAttributes_location>(RfiBase_pushpinAttributes_location.CreateFromDiscriminatorValue); } },
                {"type", n => { Type = n.GetEnumValue<RfiBase_pushpinAttributes_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("createdAt", CreatedAt);
            writer.WriteStringValue("createdBy", CreatedBy);
            writer.WriteIntValue("createdDocVersion", CreatedDocVersion);
            writer.WriteObjectValue<RfiBase_pushpinAttributes_location>("location", Location);
            writer.WriteEnumValue<RfiBase_pushpinAttributes_type>("type", Type);
        }
    }
}
