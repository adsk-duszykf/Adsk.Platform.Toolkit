// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.RFIs.Models
{
    /// <summary>
    /// The list of statuses the user is permitted to transition an RFI to, without the wfType distinction (us + emea).
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UpdateRfiResponse_permittedActions_updateRfi_allPermittedStatuses : IParsable
    {
        /// <summary>The wfEU property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.RFIs.Models.PermittedRfiStatus>? WfEU { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.RFIs.Models.PermittedRfiStatus> WfEU { get; set; }
#endif
        /// <summary>The wfUS property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.RFIs.Models.PermittedRfiStatus>? WfUS { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.RFIs.Models.PermittedRfiStatus> WfUS { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.RFIs.Models.UpdateRfiResponse_permittedActions_updateRfi_allPermittedStatuses"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.RFIs.Models.UpdateRfiResponse_permittedActions_updateRfi_allPermittedStatuses CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.RFIs.Models.UpdateRfiResponse_permittedActions_updateRfi_allPermittedStatuses();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "wfEU", n => { WfEU = n.GetCollectionOfObjectValues<global::Autodesk.ACC.RFIs.Models.PermittedRfiStatus>(global::Autodesk.ACC.RFIs.Models.PermittedRfiStatus.CreateFromDiscriminatorValue)?.AsList(); } },
                { "wfUS", n => { WfUS = n.GetCollectionOfObjectValues<global::Autodesk.ACC.RFIs.Models.PermittedRfiStatus>(global::Autodesk.ACC.RFIs.Models.PermittedRfiStatus.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.RFIs.Models.PermittedRfiStatus>("wfEU", WfEU);
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.RFIs.Models.PermittedRfiStatus>("wfUS", WfUS);
        }
    }
}
#pragma warning restore CS0618
