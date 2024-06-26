// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.AccountAdmin.Models {
    public class Project_services : IParsable {
        /// <summary>The display name for the service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; private set; }
#nullable restore
#else
        public string DisplayName { get; private set; }
#endif
        /// <summary>The language for the project.  Only valid on the `field` service.</summary>
        public Project_services_language? Language { get; set; }
        /// <summary>Indicates if a service can be deactivated.</summary>
        public bool? Removable { get; private set; }
        /// <summary>The url of the icon related to this service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceIcon { get; private set; }
#nullable restore
#else
        public string ServiceIcon { get; private set; }
#endif
        /// <summary>The name of the service. Valid values are `projectAdministration`, `documentManagement`, `quantification`, `projectManagement`, `costManagement`, `designCollaboration`, `fieldManagement`, `assets`, `workshopxr`, `insight`, `modelCoordination`, `field`, `glue` and `plan`.</summary>
        public Project_services_serviceName? ServiceName { get; set; }
        /// <summary>The status of the service in the project.  Valid values are `active`, `activating`, `available`,`inactive`, `deactivating`, `activationFailed` and `deactivationFailed`.</summary>
        public Project_services_status? Status { get; private set; }
        /// <summary>
        /// Instantiates a new project_services and sets the default values.
        /// </summary>
        public Project_services() {
            Language = Project_services_language.En;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Project_services CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Project_services();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"language", n => { Language = n.GetEnumValue<Project_services_language>(); } },
                {"removable", n => { Removable = n.GetBoolValue(); } },
                {"serviceIcon", n => { ServiceIcon = n.GetStringValue(); } },
                {"serviceName", n => { ServiceName = n.GetEnumValue<Project_services_serviceName>(); } },
                {"status", n => { Status = n.GetEnumValue<Project_services_status>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Project_services_language>("language", Language);
            writer.WriteEnumValue<Project_services_serviceName>("serviceName", ServiceName);
        }
    }
}
