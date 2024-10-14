// <auto-generated/>
#pragma warning disable CS0618
using Autodesk.ACC.CostManagement.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.ComplianceDefinitions
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ComplianceDefinitionsGetResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Pagination information when data must be returned page by page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.CostManagement.Models.Pagination? Pagination { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.CostManagement.Models.Pagination Pagination { get; set; }
#endif
        /// <summary>The results property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.CostManagement.Models.ComplianceDefinition>? Results { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.CostManagement.Models.ComplianceDefinition> Results { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.ComplianceDefinitions.ComplianceDefinitionsGetResponse"/> and sets the default values.
        /// </summary>
        public ComplianceDefinitionsGetResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.V1.Projects.Item.ComplianceDefinitions.ComplianceDefinitionsGetResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.V1.Projects.Item.ComplianceDefinitions.ComplianceDefinitionsGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.V1.Projects.Item.ComplianceDefinitions.ComplianceDefinitionsGetResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "pagination", n => { Pagination = n.GetObjectValue<global::Autodesk.ACC.CostManagement.Models.Pagination>(global::Autodesk.ACC.CostManagement.Models.Pagination.CreateFromDiscriminatorValue); } },
                { "results", n => { Results = n.GetCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.ComplianceDefinition>(global::Autodesk.ACC.CostManagement.Models.ComplianceDefinition.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Autodesk.ACC.CostManagement.Models.Pagination>("pagination", Pagination);
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.ComplianceDefinition>("results", Results);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
