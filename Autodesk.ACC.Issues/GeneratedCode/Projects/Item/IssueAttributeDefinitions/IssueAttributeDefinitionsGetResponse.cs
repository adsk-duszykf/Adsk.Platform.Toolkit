// <auto-generated/>
#pragma warning disable CS0618
using Autodesk.ACC.Issues.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.Issues.Projects.Item.IssueAttributeDefinitions
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class IssueAttributeDefinitionsGetResponse : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The pagination object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.Issues.Models.PaginationMetaDefinition? Pagination { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.Issues.Models.PaginationMetaDefinition Pagination { get; set; }
#endif
        /// <summary>A list of issue attribute definitions (custom fields).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition>? Results { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition> Results { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.Issues.Projects.Item.IssueAttributeDefinitions.IssueAttributeDefinitionsGetResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.Issues.Projects.Item.IssueAttributeDefinitions.IssueAttributeDefinitionsGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.Issues.Projects.Item.IssueAttributeDefinitions.IssueAttributeDefinitionsGetResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "pagination", n => { Pagination = n.GetObjectValue<global::Autodesk.ACC.Issues.Models.PaginationMetaDefinition>(global::Autodesk.ACC.Issues.Models.PaginationMetaDefinition.CreateFromDiscriminatorValue); } },
                { "results", n => { Results = n.GetCollectionOfObjectValues<global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition>(global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Autodesk.ACC.Issues.Models.PaginationMetaDefinition>("pagination", Pagination);
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.Issues.Models.IssueAttributeDefinitionDefinition>("results", Results);
        }
    }
}
#pragma warning restore CS0618
