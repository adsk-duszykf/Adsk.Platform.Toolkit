// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.CostManagement.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ComplianceDefinition : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The type of the compliance requirement is associated. Possible values: ``Contract``,``BudgetPayment``, ``Payment``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssociationType { get; set; }
#nullable restore
#else
        public string AssociationType { get; set; }
#endif
        /// <summary>The ID of the person who lastly changed the compliance definition. This is the ID of a user managed by BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChangedBy { get; set; }
#nullable restore
#else
        public string ChangedBy { get; set; }
#endif
        /// <summary>The createdAt property</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>The user who created the compliance definition. This is the ID of a user managed by BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatorId { get; private set; }
#nullable restore
#else
        public string CreatorId { get; private set; }
#endif
        /// <summary>The description of a compliance definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Unique identifier of a compliance definition.</summary>
        public Guid? Id { get; private set; }
        /// <summary>The name of a compliance definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The position of a compliance definition.</summary>
        public int? Position { get; set; }
        /// <summary>The required when of a compliance definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.CostManagement.Models.ComplianceDefinition_requiredWhen? RequiredWhen { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.CostManagement.Models.ComplianceDefinition_requiredWhen RequiredWhen { get; set; }
#endif
        /// <summary>The scope of a compliance definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.CostManagement.Models.ComplianceDefinition_scope? Scope { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.CostManagement.Models.ComplianceDefinition_scope Scope { get; set; }
#endif
        /// <summary>The status of a compliance definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status { get; set; }
#nullable restore
#else
        public string Status { get; set; }
#endif
        /// <summary>The scope of a compliance definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>The updatedAt property</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.Models.ComplianceDefinition"/> and sets the default values.
        /// </summary>
        public ComplianceDefinition()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.ComplianceDefinition"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.Models.ComplianceDefinition CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.Models.ComplianceDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "associationType", n => { AssociationType = n.GetStringValue(); } },
                { "changedBy", n => { ChangedBy = n.GetStringValue(); } },
                { "createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "creatorId", n => { CreatorId = n.GetStringValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "position", n => { Position = n.GetIntValue(); } },
                { "requiredWhen", n => { RequiredWhen = n.GetObjectValue<global::Autodesk.ACC.CostManagement.Models.ComplianceDefinition_requiredWhen>(global::Autodesk.ACC.CostManagement.Models.ComplianceDefinition_requiredWhen.CreateFromDiscriminatorValue); } },
                { "scope", n => { Scope = n.GetObjectValue<global::Autodesk.ACC.CostManagement.Models.ComplianceDefinition_scope>(global::Autodesk.ACC.CostManagement.Models.ComplianceDefinition_scope.CreateFromDiscriminatorValue); } },
                { "status", n => { Status = n.GetStringValue(); } },
                { "type", n => { Type = n.GetStringValue(); } },
                { "updatedAt", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("associationType", AssociationType);
            writer.WriteStringValue("changedBy", ChangedBy);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("name", Name);
            writer.WriteIntValue("position", Position);
            writer.WriteObjectValue<global::Autodesk.ACC.CostManagement.Models.ComplianceDefinition_requiredWhen>("requiredWhen", RequiredWhen);
            writer.WriteObjectValue<global::Autodesk.ACC.CostManagement.Models.ComplianceDefinition_scope>("scope", Scope);
            writer.WriteStringValue("status", Status);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
