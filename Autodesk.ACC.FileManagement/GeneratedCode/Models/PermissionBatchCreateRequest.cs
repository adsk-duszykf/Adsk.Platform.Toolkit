// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.FileManagement.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class PermissionBatchCreateRequest : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Permitted actions for the user, role, or company. The permission action group is different in BIM 360 Document Management and ACC Build File</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.FileManagement.Models.PermissionsBatchUpdate?>? Actions { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.FileManagement.Models.PermissionsBatchUpdate?> Actions { get; set; }
#endif
        /// <summary>The Autodesk ID of the user, role or company.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AutodeskId { get; set; }
#nullable restore
#else
        public string AutodeskId { get; set; }
#endif
        /// <summary>The unique identifier of the subject (user or group).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubjectId { get; set; }
#nullable restore
#else
        public string SubjectId { get; set; }
#endif
        /// <summary>The type of subject. Possible value</summary>
        public global::Autodesk.ACC.FileManagement.Models.SubjectType? SubjectType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.FileManagement.Models.PermissionBatchCreateRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.FileManagement.Models.PermissionBatchCreateRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.FileManagement.Models.PermissionBatchCreateRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "actions", n => { Actions = n.GetCollectionOfEnumValues<global::Autodesk.ACC.FileManagement.Models.PermissionsBatchUpdate>()?.AsList(); } },
                { "autodeskId", n => { AutodeskId = n.GetStringValue(); } },
                { "subjectId", n => { SubjectId = n.GetStringValue(); } },
                { "subjectType", n => { SubjectType = n.GetEnumValue<global::Autodesk.ACC.FileManagement.Models.SubjectType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfEnumValues<global::Autodesk.ACC.FileManagement.Models.PermissionsBatchUpdate>("actions", Actions);
            writer.WriteStringValue("autodeskId", AutodeskId);
            writer.WriteStringValue("subjectId", SubjectId);
            writer.WriteEnumValue<global::Autodesk.ACC.FileManagement.Models.SubjectType>("subjectType", SubjectType);
        }
    }
}
#pragma warning restore CS0618
