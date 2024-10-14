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
    /// Object json response
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ObjectDetails : IParsable
    {
        /// <summary>Bucket key</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BucketKey { get; set; }
#nullable restore
#else
        public string BucketKey { get; set; }
#endif
        /// <summary>Object content-type</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentType { get; set; }
#nullable restore
#else
        public string ContentType { get; set; }
#endif
        /// <summary>URL to download the object</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Location { get; set; }
#nullable restore
#else
        public string Location { get; set; }
#endif
        /// <summary>Object URN</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ObjectId { get; set; }
#nullable restore
#else
        public string ObjectId { get; set; }
#endif
        /// <summary>Object name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ObjectKey { get; set; }
#nullable restore
#else
        public string ObjectKey { get; set; }
#endif
        /// <summary>Object SHA1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sha1 { get; set; }
#nullable restore
#else
        public string Sha1 { get; set; }
#endif
        /// <summary>Object size</summary>
        public int? Size { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.DataManagement.OSS.Models.ObjectDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.DataManagement.OSS.Models.ObjectDetails CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.DataManagement.OSS.Models.ObjectDetails();
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
                { "contentType", n => { ContentType = n.GetStringValue(); } },
                { "location", n => { Location = n.GetStringValue(); } },
                { "objectId", n => { ObjectId = n.GetStringValue(); } },
                { "objectKey", n => { ObjectKey = n.GetStringValue(); } },
                { "sha1", n => { Sha1 = n.GetStringValue(); } },
                { "size", n => { Size = n.GetIntValue(); } },
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
            writer.WriteStringValue("contentType", ContentType);
            writer.WriteStringValue("location", Location);
            writer.WriteStringValue("objectId", ObjectId);
            writer.WriteStringValue("objectKey", ObjectKey);
            writer.WriteStringValue("sha1", Sha1);
            writer.WriteIntValue("size", Size);
        }
    }
}
#pragma warning restore CS0618
