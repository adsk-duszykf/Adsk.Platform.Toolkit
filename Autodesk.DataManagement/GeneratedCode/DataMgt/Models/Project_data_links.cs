// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.DataManagement.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class Project_data_links : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The self property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.Project_data_links_self? Self { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.Project_data_links_self Self { get; set; }
#endif
        /// <summary>The webView property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.DataManagement.Models.Project_data_links_webView? WebView { get; set; }
#nullable restore
#else
        public global::Autodesk.DataManagement.Models.Project_data_links_webView WebView { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.DataManagement.Models.Project_data_links"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.DataManagement.Models.Project_data_links CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.DataManagement.Models.Project_data_links();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "self", n => { Self = n.GetObjectValue<global::Autodesk.DataManagement.Models.Project_data_links_self>(global::Autodesk.DataManagement.Models.Project_data_links_self.CreateFromDiscriminatorValue); } },
                { "webView", n => { WebView = n.GetObjectValue<global::Autodesk.DataManagement.Models.Project_data_links_webView>(global::Autodesk.DataManagement.Models.Project_data_links_webView.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.Project_data_links_self>("self", Self);
            writer.WriteObjectValue<global::Autodesk.DataManagement.Models.Project_data_links_webView>("webView", WebView);
        }
    }
}
