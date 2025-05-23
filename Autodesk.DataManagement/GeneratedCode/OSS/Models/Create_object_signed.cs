// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.DataManagement.OSS.Models
{
    /// <summary>
    /// Object Signed Object json response
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Create_object_signed : IParsable
    {
        /// <summary>IP addresses that can make a request to this URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AllowedIpAddresses { get; set; }
#nullable restore
#else
        public List<string> AllowedIpAddresses { get; set; }
#endif
        /// <summary>Value for expiration in minutes</summary>
        public long? Expiration { get; set; }
        /// <summary>URL created for downloading the object</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SignedUrl { get; set; }
#nullable restore
#else
        public string SignedUrl { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.DataManagement.OSS.Models.Create_object_signed"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.DataManagement.OSS.Models.Create_object_signed CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.DataManagement.OSS.Models.Create_object_signed();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allowedIpAddresses", n => { AllowedIpAddresses = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "expiration", n => { Expiration = n.GetLongValue(); } },
                { "signedUrl", n => { SignedUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("allowedIpAddresses", AllowedIpAddresses);
            writer.WriteLongValue("expiration", Expiration);
            writer.WriteStringValue("signedUrl", SignedUrl);
        }
    }
}
#pragma warning restore CS0618
