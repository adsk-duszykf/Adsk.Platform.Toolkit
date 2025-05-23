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
    public partial class Buckets_items : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Bucket key</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BucketKey { get; set; }
#nullable restore
#else
        public string BucketKey { get; set; }
#endif
        /// <summary>Timestamp in epoch time</summary>
        public long? CreatedDate { get; set; }
        /// <summary>Policy values: `transient`, `temporary` or `persistent`</summary>
        public global::Autodesk.DataManagement.OSS.Models.Buckets_items_policyKey? PolicyKey { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.DataManagement.OSS.Models.Buckets_items"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.DataManagement.OSS.Models.Buckets_items CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.DataManagement.OSS.Models.Buckets_items();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "bucketKey", n => { BucketKey = n.GetStringValue(); } },
                { "createdDate", n => { CreatedDate = n.GetLongValue(); } },
                { "policyKey", n => { PolicyKey = n.GetEnumValue<global::Autodesk.DataManagement.OSS.Models.Buckets_items_policyKey>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("bucketKey", BucketKey);
            writer.WriteLongValue("createdDate", CreatedDate);
            writer.WriteEnumValue<global::Autodesk.DataManagement.OSS.Models.Buckets_items_policyKey>("policyKey", PolicyKey);
        }
    }
}
#pragma warning restore CS0618
