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
    public partial class Search_included_relationships : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The links property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.Search_included_relationships_links? Links { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.Search_included_relationships_links Links { get; set; }
#endif
        /// <summary>The parent property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.Search_included_relationships_parent? Parent { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.Search_included_relationships_parent Parent { get; set; }
#endif
        /// <summary>The refs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.Search_included_relationships_refs? Refs { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.Search_included_relationships_refs Refs { get; set; }
#endif
        /// <summary>The tip property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.Search_included_relationships_tip? Tip { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.Search_included_relationships_tip Tip { get; set; }
#endif
        /// <summary>The versions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.Search_included_relationships_versions? Versions { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.Search_included_relationships_versions Versions { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.DataManagement.Models.Search_included_relationships"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.DataManagement.Models.Search_included_relationships CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.DataManagement.Models.Search_included_relationships();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "links", n => { Links = n.GetObjectValue<global::Autodesk.DataManagement.Models.Search_included_relationships_links>(global::Autodesk.DataManagement.Models.Search_included_relationships_links.CreateFromDiscriminatorValue); } },
                { "parent", n => { Parent = n.GetObjectValue<global::Autodesk.DataManagement.Models.Search_included_relationships_parent>(global::Autodesk.DataManagement.Models.Search_included_relationships_parent.CreateFromDiscriminatorValue); } },
                { "refs", n => { Refs = n.GetObjectValue<global::Autodesk.DataManagement.Models.Search_included_relationships_refs>(global::Autodesk.DataManagement.Models.Search_included_relationships_refs.CreateFromDiscriminatorValue); } },
                { "tip", n => { Tip = n.GetObjectValue<global::Autodesk.DataManagement.Models.Search_included_relationships_tip>(global::Autodesk.DataManagement.Models.Search_included_relationships_tip.CreateFromDiscriminatorValue); } },
                { "versions", n => { Versions = n.GetObjectValue<global::Autodesk.DataManagement.Models.Search_included_relationships_versions>(global::Autodesk.DataManagement.Models.Search_included_relationships_versions.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.Search_included_relationships_links>("links", Links);
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.Search_included_relationships_parent>("parent", Parent);
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.Search_included_relationships_refs>("refs", Refs);
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.Search_included_relationships_tip>("tip", Tip);
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.Search_included_relationships_versions>("versions", Versions);
        }
    }
}
#pragma warning restore CS0618
