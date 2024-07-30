// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.DataManagement.OSS.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class Completes3upload_response_200 : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The key of the bucket into which the object has been uploaded.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BucketKey { get; set; }
#nullable restore
#else
        public string BucketKey { get; set; }
#endif
        /// <summary>The Content-Type of the object, specified in the request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentType { get; set; }
#nullable restore
#else
        public string ContentType { get; set; }
#endif
        /// <summary>The URL at which to download the object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Location { get; set; }
#nullable restore
#else
        public string Location { get; set; }
#endif
        /// <summary>The full OSS URN of the object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ObjectId { get; set; }
#nullable restore
#else
        public string ObjectId { get; set; }
#endif
        /// <summary>The name of the object provided by the client.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ObjectKey { get; set; }
#nullable restore
#else
        public string ObjectKey { get; set; }
#endif
        /// <summary>The size of the object in bytes.</summary>
        public long? Size { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.DataManagement.OSS.Models.Completes3upload_response_200"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.DataManagement.OSS.Models.Completes3upload_response_200 CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.DataManagement.OSS.Models.Completes3upload_response_200();
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
                { "size", n => { Size = n.GetLongValue(); } },
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
            writer.WriteLongValue("size", Size);
        }
    }
}
