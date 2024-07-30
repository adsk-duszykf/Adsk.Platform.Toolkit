// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.RFIs.Models
{
    /// <summary>
    /// The list of attributes and statuses available  for the user.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class UpdateRfiResponse_permittedActions_updateRfi : IParsable
    {
        /// <summary>The list of statuses the user is permitted to transition an RFI to, without the wfType distinction (us + emea).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.RFIs.Models.UpdateRfiResponse_permittedActions_updateRfi_allPermittedStatuses? AllPermittedStatuses { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.RFIs.Models.UpdateRfiResponse_permittedActions_updateRfi_allPermittedStatuses AllPermittedStatuses { get; set; }
#endif
        /// <summary>The list of attributes that are required when creating an RFI.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.RFIs.Models.PermittedRfiAttribute>? PermittedAttributes { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.RFIs.Models.PermittedRfiAttribute> PermittedAttributes { get; set; }
#endif
        /// <summary>The list of statuses the user is permitted to transition the RFI to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.RFIs.Models.PermittedRfiStatus>? PermittedStatuses { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.RFIs.Models.PermittedRfiStatus> PermittedStatuses { get; set; }
#endif
        /// <summary>whether or not the user may fill custom attributes in the new rfi</summary>
        public bool? UseCustomAttributes { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.RFIs.Models.UpdateRfiResponse_permittedActions_updateRfi"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.RFIs.Models.UpdateRfiResponse_permittedActions_updateRfi CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.RFIs.Models.UpdateRfiResponse_permittedActions_updateRfi();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allPermittedStatuses", n => { AllPermittedStatuses = n.GetObjectValue<global::Autodesk.ACC.RFIs.Models.UpdateRfiResponse_permittedActions_updateRfi_allPermittedStatuses>(global::Autodesk.ACC.RFIs.Models.UpdateRfiResponse_permittedActions_updateRfi_allPermittedStatuses.CreateFromDiscriminatorValue); } },
                { "permittedAttributes", n => { PermittedAttributes = n.GetCollectionOfObjectValues<global::Autodesk.ACC.RFIs.Models.PermittedRfiAttribute>(global::Autodesk.ACC.RFIs.Models.PermittedRfiAttribute.CreateFromDiscriminatorValue)?.AsList(); } },
                { "permittedStatuses", n => { PermittedStatuses = n.GetCollectionOfObjectValues<global::Autodesk.ACC.RFIs.Models.PermittedRfiStatus>(global::Autodesk.ACC.RFIs.Models.PermittedRfiStatus.CreateFromDiscriminatorValue)?.AsList(); } },
                { "useCustomAttributes", n => { UseCustomAttributes = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Autodesk.ACC.RFIs.Models.UpdateRfiResponse_permittedActions_updateRfi_allPermittedStatuses>("allPermittedStatuses", AllPermittedStatuses);
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.RFIs.Models.PermittedRfiAttribute>("permittedAttributes", PermittedAttributes);
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.RFIs.Models.PermittedRfiStatus>("permittedStatuses", PermittedStatuses);
            writer.WriteBoolValue("useCustomAttributes", UseCustomAttributes);
        }
    }
}
