// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.FileManagement.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class CustomAttributeDefinitions_pagination : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The limit property</summary>
        public int? Limit { get; set; }
        /// <summary>The nextUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NextUrl { get; set; }
#nullable restore
#else
        public string NextUrl { get; set; }
#endif
        /// <summary>The offset property</summary>
        public int? Offset { get; set; }
        /// <summary>The previousUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreviousUrl { get; set; }
#nullable restore
#else
        public string PreviousUrl { get; set; }
#endif
        /// <summary>The totalResults property</summary>
        public int? TotalResults { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.FileManagement.Models.CustomAttributeDefinitions_pagination"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.FileManagement.Models.CustomAttributeDefinitions_pagination CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.FileManagement.Models.CustomAttributeDefinitions_pagination();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "limit", n => { Limit = n.GetIntValue(); } },
                { "nextUrl", n => { NextUrl = n.GetStringValue(); } },
                { "offset", n => { Offset = n.GetIntValue(); } },
                { "previousUrl", n => { PreviousUrl = n.GetStringValue(); } },
                { "totalResults", n => { TotalResults = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("limit", Limit);
            writer.WriteStringValue("nextUrl", NextUrl);
            writer.WriteIntValue("offset", Offset);
            writer.WriteStringValue("previousUrl", PreviousUrl);
            writer.WriteIntValue("totalResults", TotalResults);
        }
    }
}
