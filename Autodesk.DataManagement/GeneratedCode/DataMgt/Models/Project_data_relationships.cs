// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.DataManagement.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Project_data_relationships : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The checklists property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.Project_data_relationships_checklists? Checklists { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.Project_data_relationships_checklists Checklists { get; set; }
#endif
        /// <summary>The cost property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.Project_data_relationships_cost? Cost { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.Project_data_relationships_cost Cost { get; set; }
#endif
        /// <summary>The hub property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.Project_data_relationships_hub? Hub { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.Project_data_relationships_hub Hub { get; set; }
#endif
        /// <summary>The issues property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.Project_data_relationships_issues? Issues { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.Project_data_relationships_issues Issues { get; set; }
#endif
        /// <summary>The locations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.Project_data_relationships_locations? Locations { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.Project_data_relationships_locations Locations { get; set; }
#endif
        /// <summary>The markups property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.Project_data_relationships_markups? Markups { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.Project_data_relationships_markups Markups { get; set; }
#endif
        /// <summary>The rfis property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.Project_data_relationships_rfis? Rfis { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.Project_data_relationships_rfis Rfis { get; set; }
#endif
        /// <summary>The rootFolder property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.Project_data_relationships_rootFolder? RootFolder { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.Project_data_relationships_rootFolder RootFolder { get; set; }
#endif
        /// <summary>The submittals property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.Project_data_relationships_submittals? Submittals { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.Project_data_relationships_submittals Submittals { get; set; }
#endif
        /// <summary>The topFolders property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.Project_data_relationships_topFolders? TopFolders { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.Project_data_relationships_topFolders TopFolders { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.DataManagement.Models.Project_data_relationships"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.DataManagement.Models.Project_data_relationships CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.DataManagement.Models.Project_data_relationships();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "checklists", n => { Checklists = n.GetObjectValue<global::Autodesk.DataManagement.Models.Project_data_relationships_checklists>(global::Autodesk.DataManagement.Models.Project_data_relationships_checklists.CreateFromDiscriminatorValue); } },
                { "cost", n => { Cost = n.GetObjectValue<global::Autodesk.DataManagement.Models.Project_data_relationships_cost>(global::Autodesk.DataManagement.Models.Project_data_relationships_cost.CreateFromDiscriminatorValue); } },
                { "hub", n => { Hub = n.GetObjectValue<global::Autodesk.DataManagement.Models.Project_data_relationships_hub>(global::Autodesk.DataManagement.Models.Project_data_relationships_hub.CreateFromDiscriminatorValue); } },
                { "issues", n => { Issues = n.GetObjectValue<global::Autodesk.DataManagement.Models.Project_data_relationships_issues>(global::Autodesk.DataManagement.Models.Project_data_relationships_issues.CreateFromDiscriminatorValue); } },
                { "locations", n => { Locations = n.GetObjectValue<global::Autodesk.DataManagement.Models.Project_data_relationships_locations>(global::Autodesk.DataManagement.Models.Project_data_relationships_locations.CreateFromDiscriminatorValue); } },
                { "markups", n => { Markups = n.GetObjectValue<global::Autodesk.DataManagement.Models.Project_data_relationships_markups>(global::Autodesk.DataManagement.Models.Project_data_relationships_markups.CreateFromDiscriminatorValue); } },
                { "rfis", n => { Rfis = n.GetObjectValue<global::Autodesk.DataManagement.Models.Project_data_relationships_rfis>(global::Autodesk.DataManagement.Models.Project_data_relationships_rfis.CreateFromDiscriminatorValue); } },
                { "rootFolder", n => { RootFolder = n.GetObjectValue<global::Autodesk.DataManagement.Models.Project_data_relationships_rootFolder>(global::Autodesk.DataManagement.Models.Project_data_relationships_rootFolder.CreateFromDiscriminatorValue); } },
                { "submittals", n => { Submittals = n.GetObjectValue<global::Autodesk.DataManagement.Models.Project_data_relationships_submittals>(global::Autodesk.DataManagement.Models.Project_data_relationships_submittals.CreateFromDiscriminatorValue); } },
                { "topFolders", n => { TopFolders = n.GetObjectValue<global::Autodesk.DataManagement.Models.Project_data_relationships_topFolders>(global::Autodesk.DataManagement.Models.Project_data_relationships_topFolders.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.Project_data_relationships_checklists>("checklists", Checklists);
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.Project_data_relationships_cost>("cost", Cost);
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.Project_data_relationships_hub>("hub", Hub);
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.Project_data_relationships_issues>("issues", Issues);
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.Project_data_relationships_locations>("locations", Locations);
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.Project_data_relationships_markups>("markups", Markups);
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.Project_data_relationships_rfis>("rfis", Rfis);
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.Project_data_relationships_rootFolder>("rootFolder", RootFolder);
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.Project_data_relationships_submittals>("submittals", Submittals);
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.Project_data_relationships_topFolders>("topFolders", TopFolders);
        }
    }
}
#pragma warning restore CS0618
