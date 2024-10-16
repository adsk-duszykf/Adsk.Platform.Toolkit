// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ModelDerivative.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class JobPayloadFormat_advanced : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Specifies how to handle Autodesk material properties.true: Extract properties for Autodesk materials.false: (Default) Do not extract properties for Autodesk materials.</summary>
        public bool? AutodeskMaterialProperties { get; set; }
        /// <summary>Specifies whether basic material properties must be extracted or not.true: Extract properties for basic materials.false: (Default) Do not extract properties for basic materials.</summary>
        public bool? BasicMaterialProperties { get; set; }
        /// <summary>Specifies how storeys are translated. Available options are:- hide - (default) storeys are extracted but not visible by default.- show - storeys are extracted and are visible by default.- skip - storeys are not translated.Note These options are applicable only when conversionMethod is set to modern or v3.</summary>
        public global::Autodesk.ModelDerivative.Models.JobPayloadFormat_advanced_buildingStoreys? BuildingStoreys { get; set; }
        /// <summary>Specifies what IFC loader to use during translation. Available options are:- legacy - Use the Navisworks IFC loader.- modern - Use the Revit IFC loader (recommended over the legacy option).- v3 - Use the newer Revit IFC loader (recommended over the older modern option)If both switchLoader and conversionMethod are specified, Model Derivative uses the conversionMethod parameter. If conversionMethod is not specified, Model Derivative uses the switchLoader parameter.</summary>
        public global::Autodesk.ModelDerivative.Models.JobPayloadFormat_advanced_conversionMethod? ConversionMethod { get; set; }
        /// <summary>Specifies what version of the Revit translator/extractor to use. Possible values:next - Makes the translation job use the newest available version of the translator/extractor. This option is meant to be used by beta testers who wish to test a pre-release version of the translator. If no pre-release version is available, this option makes the translation job use the current official release version.previous - Makes the translation job use the previous official release version of the translator/extractor. This option is meant to be used as a workaround in case of regressions caused by a new official release of the translator/extractor.If this attribute is not specified, the system uses the current official release version.</summary>
        public global::Autodesk.ModelDerivative.Models.JobPayloadFormat_advanced_extractorVersion? ExtractorVersion { get; set; }
        /// <summary>Generates master views when translating from the Revit input format to SVF. This option is ignored for all other input formats. This attribute defaults to false.Master views are 3D views that are generated for each phase of the Revit model. A master view contains all elements (including “room” elements) present in the host model for that phase. The display name of a master view defaults to the name of the phase it is generated from. However, if a view with that name already exists, the Model Derivative service appends a suffix to the default display name.Notes:1. Master views do not contain elements from linked models.2. Enabling this option can increase the time it takes to translate the model.</summary>
        public bool? GenerateMasterViews { get; set; }
        /// <summary>Specifies whether hidden objects must be extracted or not.true: Extract hidden objects from the input file.false: (Default) Do not extract hidden objects from the input file.</summary>
        public bool? HiddenObjects { get; set; }
        /// <summary>Specifies how the hierarchy of items are determined.Classic: (Default) Uses hardcoded rules to set the hierarchy of items.SystemPath: Uses a linked XML or MDB2 properties file to set hierarchy of items. You can use this option to make the organization of items consistent with SmartPlant 3D.Notes:1. The functioning of the SystemPath depends on the default setting of the property SP3D_SystemPath or System Path.2. The pathing delimiter must be \.3. If you want to customize further, import the VUE file to Navisworks. After that, use POST job on the resulting Navisworks (nwc/nwd) file.</summary>
        public global::Autodesk.ModelDerivative.Models.JobPayloadFormat_advanced_hierarchy? Hierarchy { get; set; }
        /// <summary>Specifies the materials to apply to the generated SVF derivatives. Available options are:- auto - (Default) Use the current setting of the default view of the input file.- basic - Use basic materials.- autodesk - Use Autodesk materials.</summary>
        public global::Autodesk.ModelDerivative.Models.JobPayloadFormat_advanced_materialMode? MaterialMode { get; set; }
        /// <summary>An option to be specified when the input file type is IFC.Specifies how openings are translated. Available options are:- hide - (default) openings are translated but are not visible by default.- show - openings are translated and are visible by default.- skip - openings are not translated.Note These options are applicable only when conversionMethod is set to modern or v3.</summary>
        public global::Autodesk.ModelDerivative.Models.JobPayloadFormat_advanced_openingElements? OpeningElements { get; set; }
        /// <summary>An array containing user data linkage IDs of the linkage data to be extracted from the DGN file. Linkage data is not extracted if you do not specify this attribute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? RequestedLinkageIDs { get; set; }
#nullable restore
#else
        public List<int?> RequestedLinkageIDs { get; set; }
#endif
        /// <summary>Specifies how spaces are translated. Available options are:- hide - (default) spaces are translated but are not visible by default.- show - spaces are translated and are visible by default.- skip - spaces are not translated.Note These options are applicable only when conversionMethod is set to modern or v3.</summary>
        public global::Autodesk.ModelDerivative.Models.JobPayloadFormat_advanced_spaces? Spaces { get; set; }
        /// <summary>Specifies whether timeliner properties must be extracted or not.true: Extract timeliner properties.false: (Default) Do not extract timeliner properties.</summary>
        public bool? TimelinerProperties { get; set; }
        /// <summary>The format that 2D views must be rendered to. Available options are:- legacy - (Default) Render to a model derivative specific file format.- pdf - Render to the PDF file format. This option applies only to Revit 2022 files and newer.</summary>
        public global::Autodesk.ModelDerivative.Models.JobPayloadFormat_advanced_Twodviews? Twodviews { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ModelDerivative.Models.JobPayloadFormat_advanced"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ModelDerivative.Models.JobPayloadFormat_advanced CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ModelDerivative.Models.JobPayloadFormat_advanced();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "autodeskMaterialProperties", n => { AutodeskMaterialProperties = n.GetBoolValue(); } },
                { "basicMaterialProperties", n => { BasicMaterialProperties = n.GetBoolValue(); } },
                { "buildingStoreys", n => { BuildingStoreys = n.GetEnumValue<global::Autodesk.ModelDerivative.Models.JobPayloadFormat_advanced_buildingStoreys>(); } },
                { "conversionMethod", n => { ConversionMethod = n.GetEnumValue<global::Autodesk.ModelDerivative.Models.JobPayloadFormat_advanced_conversionMethod>(); } },
                { "extractorVersion", n => { ExtractorVersion = n.GetEnumValue<global::Autodesk.ModelDerivative.Models.JobPayloadFormat_advanced_extractorVersion>(); } },
                { "generateMasterViews", n => { GenerateMasterViews = n.GetBoolValue(); } },
                { "hiddenObjects", n => { HiddenObjects = n.GetBoolValue(); } },
                { "hierarchy", n => { Hierarchy = n.GetEnumValue<global::Autodesk.ModelDerivative.Models.JobPayloadFormat_advanced_hierarchy>(); } },
                { "materialMode", n => { MaterialMode = n.GetEnumValue<global::Autodesk.ModelDerivative.Models.JobPayloadFormat_advanced_materialMode>(); } },
                { "openingElements", n => { OpeningElements = n.GetEnumValue<global::Autodesk.ModelDerivative.Models.JobPayloadFormat_advanced_openingElements>(); } },
                { "requestedLinkageIDs", n => { RequestedLinkageIDs = n.GetCollectionOfPrimitiveValues<int?>()?.AsList(); } },
                { "spaces", n => { Spaces = n.GetEnumValue<global::Autodesk.ModelDerivative.Models.JobPayloadFormat_advanced_spaces>(); } },
                { "timelinerProperties", n => { TimelinerProperties = n.GetBoolValue(); } },
                { "2dviews", n => { Twodviews = n.GetEnumValue<global::Autodesk.ModelDerivative.Models.JobPayloadFormat_advanced_Twodviews>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("autodeskMaterialProperties", AutodeskMaterialProperties);
            writer.WriteBoolValue("basicMaterialProperties", BasicMaterialProperties);
            writer.WriteEnumValue<global::Autodesk.ModelDerivative.Models.JobPayloadFormat_advanced_buildingStoreys>("buildingStoreys", BuildingStoreys);
            writer.WriteEnumValue<global::Autodesk.ModelDerivative.Models.JobPayloadFormat_advanced_conversionMethod>("conversionMethod", ConversionMethod);
            writer.WriteEnumValue<global::Autodesk.ModelDerivative.Models.JobPayloadFormat_advanced_extractorVersion>("extractorVersion", ExtractorVersion);
            writer.WriteBoolValue("generateMasterViews", GenerateMasterViews);
            writer.WriteBoolValue("hiddenObjects", HiddenObjects);
            writer.WriteEnumValue<global::Autodesk.ModelDerivative.Models.JobPayloadFormat_advanced_hierarchy>("hierarchy", Hierarchy);
            writer.WriteEnumValue<global::Autodesk.ModelDerivative.Models.JobPayloadFormat_advanced_materialMode>("materialMode", MaterialMode);
            writer.WriteEnumValue<global::Autodesk.ModelDerivative.Models.JobPayloadFormat_advanced_openingElements>("openingElements", OpeningElements);
            writer.WriteCollectionOfPrimitiveValues<int?>("requestedLinkageIDs", RequestedLinkageIDs);
            writer.WriteEnumValue<global::Autodesk.ModelDerivative.Models.JobPayloadFormat_advanced_spaces>("spaces", Spaces);
            writer.WriteBoolValue("timelinerProperties", TimelinerProperties);
            writer.WriteEnumValue<global::Autodesk.ModelDerivative.Models.JobPayloadFormat_advanced_Twodviews>("2dviews", Twodviews);
        }
    }
}
#pragma warning restore CS0618
