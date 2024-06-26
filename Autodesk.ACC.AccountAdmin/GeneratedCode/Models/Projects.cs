// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.AccountAdmin.Models {
    public class Projects : IParsable {
        /// <summary>The url of the icon related to this service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Icon { get; set; }
#nullable restore
#else
        public string Icon { get; set; }
#endif
        /// <summary>The key of the product. Valid values are `assets`, `autoSpecs`, `build`, `capitalPlanning`, `cost`, `costManagement`, `designCollaboration`, `docs`, `documentManagement`, `field`, `fieldManagement`, `financials`, `glue`, `workshopxr`, `insight`, `modelCoordination`, `plan`, `projectAdministration`, `projectHome`, `projectManagement`, `quantification`, `takeoff`.</summary>
        public Projects_key? Key { get; set; }
        /// <summary>The language for the project. Only valid on the `field` service.</summary>
        public Projects_language? Language { get; set; }
        /// <summary>The name for the product.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The status of the product in the project. Valid values are `activating`, `activationFailed`, `active`, `available`, `deactivating`, `deactivationFailed` and `inactive`.</summary>
        public Projects_status? Status { get; set; }
        /// <summary>
        /// Instantiates a new projects and sets the default values.
        /// </summary>
        public Projects() {
            Language = Projects_language.En;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Projects CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Projects();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"icon", n => { Icon = n.GetStringValue(); } },
                {"key", n => { Key = n.GetEnumValue<Projects_key>(); } },
                {"language", n => { Language = n.GetEnumValue<Projects_language>(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<Projects_status>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("icon", Icon);
            writer.WriteEnumValue<Projects_key>("key", Key);
            writer.WriteEnumValue<Projects_language>("language", Language);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<Projects_status>("status", Status);
        }
    }
}
