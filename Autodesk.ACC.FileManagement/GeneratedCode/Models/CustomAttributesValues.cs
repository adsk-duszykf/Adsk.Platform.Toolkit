// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.FileManagement.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class CustomAttributesValues : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The errors property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.FileManagement.Models.CustomAttributesValues_errors>? Errors { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.FileManagement.Models.CustomAttributesValues_errors> Errors { get; set; }
#endif
        /// <summary>The results property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.FileManagement.Models.CustomAttributesValues_results>? Results { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.FileManagement.Models.CustomAttributesValues_results> Results { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.FileManagement.Models.CustomAttributesValues"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.FileManagement.Models.CustomAttributesValues CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.FileManagement.Models.CustomAttributesValues();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "errors", n => { Errors = n.GetCollectionOfObjectValues<global::Autodesk.ACC.FileManagement.Models.CustomAttributesValues_errors>(global::Autodesk.ACC.FileManagement.Models.CustomAttributesValues_errors.CreateFromDiscriminatorValue)?.AsList(); } },
                { "results", n => { Results = n.GetCollectionOfObjectValues<global::Autodesk.ACC.FileManagement.Models.CustomAttributesValues_results>(global::Autodesk.ACC.FileManagement.Models.CustomAttributesValues_results.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.FileManagement.Models.CustomAttributesValues_errors>("errors", Errors);
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.FileManagement.Models.CustomAttributesValues_results>("results", Results);
        }
    }
}
#pragma warning restore CS0618
