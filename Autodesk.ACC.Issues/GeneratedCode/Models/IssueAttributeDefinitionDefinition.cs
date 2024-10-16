// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.Issues.Models
{
    /// <summary>
    /// The results object.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class IssueAttributeDefinitionDefinition : IParsable
    {
        /// <summary>The containerId property</summary>
        public Guid? ContainerId { get; private set; }
        /// <summary>The date and time the custom attribute was created, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>The Autodesk ID of the user who created the custom attribute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedBy { get; private set; }
#nullable restore
#else
        public string CreatedBy { get; private set; }
#endif
        /// <summary>The type of custom attribute. Possible values: ``list``, ``text``, ``paragraph``, ``numeric``.</summary>
        public global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition_dataType? DataType { get; set; }
        /// <summary>The date and time the custom attribute was deleted, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? DeletedAt { get; private set; }
        /// <summary>The Autodesk ID of the user who deleted the custom attribute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeletedBy { get; private set; }
#nullable restore
#else
        public string DeletedBy { get; private set; }
#endif
        /// <summary>The description of the custom attribute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The ID of the custom attribute.</summary>
        public Guid? Id { get; private set; }
        /// <summary>The metadata object; only relevant for ``list`` custom attributes.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition_metadata? Metadata { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition_metadata Metadata { get; set; }
#endif
        /// <summary>Not applicable.A list of actions that are permitted for the custom attribute for the current user.Possible Values: ``edit``, ``delete``, ``paragraph``, ``numeric``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition_permittedActions?>? PermittedActions { get; private set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition_permittedActions?> PermittedActions { get; private set; }
#endif
        /// <summary>Not applicable.A list of custom attribute attributes that can be modified by the current user.Possible Values: ``title``, ``description``, ``metadata``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition_permittedAttributes?>? PermittedAttributes { get; private set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition_permittedAttributes?> PermittedAttributes { get; private set; }
#endif
        /// <summary>The title of the custom attribute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>The last date and time the custom attribute was updated, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>The Autodesk ID of the user who last updated the custom attribute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UpdatedBy { get; private set; }
#nullable restore
#else
        public string UpdatedBy { get; private set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "containerId", n => { ContainerId = n.GetGuidValue(); } },
                { "createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "createdBy", n => { CreatedBy = n.GetStringValue(); } },
                { "dataType", n => { DataType = n.GetEnumValue<global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition_dataType>(); } },
                { "deletedAt", n => { DeletedAt = n.GetDateTimeOffsetValue(); } },
                { "deletedBy", n => { DeletedBy = n.GetStringValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "metadata", n => { Metadata = n.GetObjectValue<global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition_metadata>(global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition_metadata.CreateFromDiscriminatorValue); } },
                { "permittedActions", n => { PermittedActions = n.GetCollectionOfEnumValues<global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition_permittedActions>()?.AsList(); } },
                { "permittedAttributes", n => { PermittedAttributes = n.GetCollectionOfEnumValues<global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition_permittedAttributes>()?.AsList(); } },
                { "title", n => { Title = n.GetStringValue(); } },
                { "updatedAt", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                { "updatedBy", n => { UpdatedBy = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition_dataType>("dataType", DataType);
            writer.WriteStringValue("description", Description);
            writer.WriteObjectValue<global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition_metadata>("metadata", Metadata);
            writer.WriteStringValue("title", Title);
        }
    }
}
#pragma warning restore CS0618
