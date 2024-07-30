// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.RFIs.Models
{
    /// <summary>
    /// The list of actions that are permitted for the user.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class UsersMeResponse_permittedActions : IParsable
    {
        /// <summary>The list of attributes available for the user.Note that the appearance of this attribute in the response indicates that the user can create RFIs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.RFIs.Models.UsersMeResponse_permittedActions_createRfi? CreateRfi { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.RFIs.Models.UsersMeResponse_permittedActions_createRfi CreateRfi { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.RFIs.Models.UsersMeResponse_permittedActions"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.RFIs.Models.UsersMeResponse_permittedActions CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.RFIs.Models.UsersMeResponse_permittedActions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "createRfi", n => { CreateRfi = n.GetObjectValue<global::Autodesk.ACC.RFIs.Models.UsersMeResponse_permittedActions_createRfi>(global::Autodesk.ACC.RFIs.Models.UsersMeResponse_permittedActions_createRfi.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Autodesk.ACC.RFIs.Models.UsersMeResponse_permittedActions_createRfi>("createRfi", CreateRfi);
        }
    }
}
