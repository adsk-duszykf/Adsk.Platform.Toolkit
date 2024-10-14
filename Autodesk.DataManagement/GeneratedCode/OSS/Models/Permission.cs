// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.DataManagement.OSS.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Permission : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The authentication access type</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Access { get; set; }
#nullable restore
#else
        public string Access { get; set; }
#endif
        /// <summary>The authentication ID</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AuthId { get; set; }
#nullable restore
#else
        public string AuthId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.DataManagement.OSS.Models.Permission"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.DataManagement.OSS.Models.Permission CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.DataManagement.OSS.Models.Permission();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "access", n => { Access = n.GetStringValue(); } },
                { "authId", n => { AuthId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("access", Access);
            writer.WriteStringValue("authId", AuthId);
        }
    }
}
#pragma warning restore CS0618
