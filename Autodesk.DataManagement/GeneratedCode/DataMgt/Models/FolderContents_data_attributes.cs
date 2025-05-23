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
    public partial class FolderContents_data_attributes : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The createTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreateTime { get; set; }
#nullable restore
#else
        public string CreateTime { get; set; }
#endif
        /// <summary>The createUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreateUserId { get; set; }
#nullable restore
#else
        public string CreateUserId { get; set; }
#endif
        /// <summary>The createUserName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreateUserName { get; set; }
#nullable restore
#else
        public string CreateUserName { get; set; }
#endif
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The extension property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.FolderContents_data_attributes_extension? Extension { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.FolderContents_data_attributes_extension Extension { get; set; }
#endif
        /// <summary>The hidden property</summary>
        public bool? Hidden { get; set; }
        /// <summary>The lastModifiedTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastModifiedTime { get; set; }
#nullable restore
#else
        public string LastModifiedTime { get; set; }
#endif
        /// <summary>The lastModifiedTimeRollup property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastModifiedTimeRollup { get; set; }
#nullable restore
#else
        public string LastModifiedTimeRollup { get; set; }
#endif
        /// <summary>The lastModifiedUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastModifiedUserId { get; set; }
#nullable restore
#else
        public string LastModifiedUserId { get; set; }
#endif
        /// <summary>The lastModifiedUserName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastModifiedUserName { get; set; }
#nullable restore
#else
        public string LastModifiedUserName { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The objectCount property</summary>
        public double? ObjectCount { get; set; }
        /// <summary>The path property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Path { get; set; }
#nullable restore
#else
        public string Path { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.DataManagement.Models.FolderContents_data_attributes"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.DataManagement.Models.FolderContents_data_attributes CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.DataManagement.Models.FolderContents_data_attributes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "createTime", n => { CreateTime = n.GetStringValue(); } },
                { "createUserId", n => { CreateUserId = n.GetStringValue(); } },
                { "createUserName", n => { CreateUserName = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "extension", n => { Extension = n.GetObjectValue<global::Autodesk.DataManagement.Models.FolderContents_data_attributes_extension>(global::Autodesk.DataManagement.Models.FolderContents_data_attributes_extension.CreateFromDiscriminatorValue); } },
                { "hidden", n => { Hidden = n.GetBoolValue(); } },
                { "lastModifiedTime", n => { LastModifiedTime = n.GetStringValue(); } },
                { "lastModifiedTimeRollup", n => { LastModifiedTimeRollup = n.GetStringValue(); } },
                { "lastModifiedUserId", n => { LastModifiedUserId = n.GetStringValue(); } },
                { "lastModifiedUserName", n => { LastModifiedUserName = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "objectCount", n => { ObjectCount = n.GetDoubleValue(); } },
                { "path", n => { Path = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("createTime", CreateTime);
            writer.WriteStringValue("createUserId", CreateUserId);
            writer.WriteStringValue("createUserName", CreateUserName);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.FolderContents_data_attributes_extension>("extension", Extension);
            writer.WriteBoolValue("hidden", Hidden);
            writer.WriteStringValue("lastModifiedTime", LastModifiedTime);
            writer.WriteStringValue("lastModifiedTimeRollup", LastModifiedTimeRollup);
            writer.WriteStringValue("lastModifiedUserId", LastModifiedUserId);
            writer.WriteStringValue("lastModifiedUserName", LastModifiedUserName);
            writer.WriteStringValue("name", Name);
            writer.WriteDoubleValue("objectCount", ObjectCount);
            writer.WriteStringValue("path", Path);
        }
    }
}
#pragma warning restore CS0618
