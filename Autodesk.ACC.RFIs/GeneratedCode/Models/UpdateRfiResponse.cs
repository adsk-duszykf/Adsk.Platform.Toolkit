// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.RFIs.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class UpdateRfiResponse : global::Autodesk.ACC.RFIs.Models.RfiBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Mobile user last RFI Comment sync token</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommentSyncToken { get; set; }
#nullable restore
#else
        public string CommentSyncToken { get; set; }
#endif
        /// <summary>The list of actions that are permitted for the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.RFIs.Models.UpdateRfiResponse_permittedActions? PermittedActions { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.RFIs.Models.UpdateRfiResponse_permittedActions PermittedActions { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.RFIs.Models.UpdateRfiResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Autodesk.ACC.RFIs.Models.UpdateRfiResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.RFIs.Models.UpdateRfiResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "commentSyncToken", n => { CommentSyncToken = n.GetStringValue(); } },
                { "permittedActions", n => { PermittedActions = n.GetObjectValue<global::Autodesk.ACC.RFIs.Models.UpdateRfiResponse_permittedActions>(global::Autodesk.ACC.RFIs.Models.UpdateRfiResponse_permittedActions.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("commentSyncToken", CommentSyncToken);
            writer.WriteObjectValue<global::Autodesk.ACC.RFIs.Models.UpdateRfiResponse_permittedActions>("permittedActions", PermittedActions);
        }
    }
}
#pragma warning restore CS0618
