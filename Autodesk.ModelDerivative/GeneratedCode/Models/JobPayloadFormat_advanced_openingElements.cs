// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Autodesk.ModelDerivative.Models
{
    /// <summary>An option to be specified when the input file type is IFC.Specifies how openings are translated. Available options are:- hide - (default) openings are translated but are not visible by default.- show - openings are translated and are visible by default.- skip - openings are not translated.Note These options are applicable only when conversionMethod is set to modern or v3.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum JobPayloadFormat_advanced_openingElements
    {
        [EnumMember(Value = "hide")]
        #pragma warning disable CS1591
        Hide,
        #pragma warning restore CS1591
        [EnumMember(Value = "show")]
        #pragma warning disable CS1591
        Show,
        #pragma warning restore CS1591
        [EnumMember(Value = "skip")]
        #pragma warning disable CS1591
        Skip,
        #pragma warning restore CS1591
    }
}
