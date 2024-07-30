// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.RFIs.Models
{
    /// <summary>
    /// The RFIs workflow data object for the user
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class UsersMeResponse_workflow : IParsable
    {
        /// <summary>A list of workflow roles assigned to the user.``projectSC`` corresponds to the creator workflow role``projectGC`` corresponds to the manager workflow role``projectCM`` corresponds to the reviewer 1 workflow role (only available in an ``EU`` workflow)``projectArch`` corresponds to the reveiwer 1 workflow role in a ``US`` workflow, or to the reveiwer 2 workflow role in an ``EU`` workflowFor information about workflow roles, see the `RFIs help documentation` `BIM 360&lt;https://help.autodesk.com/view/BIM360D/ENU/?guid=GUID-EB858EFA-DFEB-47EF-B9B3-1CE75BBE48F3&gt;`_ `ACC&lt;https://help.autodesk.com/view/BUILD/ENU/?guid=RFI_Statuses&gt;`_.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.RFIs.Models.UsersMeResponse_workflow_roles?>? Roles { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.RFIs.Models.UsersMeResponse_workflow_roles?> Roles { get; set; }
#endif
        /// <summary>The type of RFI workflow for the project. Possible values: ``US``, ``EU``.``US`` corresponds to the RFI workflow with one reviewer.``EU`` corresponds to the RFI workflow with two reviewers.Note that currently you cannot use the RFIs API to select an RFI workflow. For information about selecting an RFI workflow for a project, see the `RFIs help documentation` `BIM360&lt;https://help.autodesk.com/view/BIM360D/ENU/?guid=GUID-787338BF-1189-4170-8629-7FA240F4BED4&gt;`_ `ACC&lt;https://help.autodesk.com/view/BUILD/ENU/?guid=RFI_Workflow_Setup&gt;`_.</summary>
        public global::Autodesk.ACC.RFIs.Models.UsersMeResponse_workflow_type? Type { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.RFIs.Models.UsersMeResponse_workflow"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.RFIs.Models.UsersMeResponse_workflow CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.RFIs.Models.UsersMeResponse_workflow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "roles", n => { Roles = n.GetCollectionOfEnumValues<global::Autodesk.ACC.RFIs.Models.UsersMeResponse_workflow_roles>()?.AsList(); } },
                { "type", n => { Type = n.GetEnumValue<global::Autodesk.ACC.RFIs.Models.UsersMeResponse_workflow_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfEnumValues<global::Autodesk.ACC.RFIs.Models.UsersMeResponse_workflow_roles>("roles", Roles);
            writer.WriteEnumValue<global::Autodesk.ACC.RFIs.Models.UsersMeResponse_workflow_type>("type", Type);
        }
    }
}
