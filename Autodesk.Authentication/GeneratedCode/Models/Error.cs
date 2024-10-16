// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.Authentication.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Error : ApiException, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A short explanation, typically meant to assist diagnose the cause of the error</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeveloperMessage { get; set; }
#nullable restore
#else
        public string DeveloperMessage { get; set; }
#endif
        /// <summary>The errorCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ErrorCode { get; set; }
#nullable restore
#else
        public string ErrorCode { get; set; }
#endif
        /// <summary>The primary error message.</summary>
        public override string Message { get => base.Message; }
        /// <summary>The moreInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MoreInfo { get; set; }
#nullable restore
#else
        public string MoreInfo { get; set; }
#endif
        /// <summary>A short, generic description of the error, meant for an end-user audience.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserMessage { get; set; }
#nullable restore
#else
        public string UserMessage { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.Authentication.Models.Error"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.Authentication.Models.Error CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.Authentication.Models.Error();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "developerMessage", n => { DeveloperMessage = n.GetStringValue(); } },
                { "errorCode", n => { ErrorCode = n.GetStringValue(); } },
                { "more info", n => { MoreInfo = n.GetStringValue(); } },
                { "userMessage", n => { UserMessage = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("developerMessage", DeveloperMessage);
            writer.WriteStringValue("errorCode", ErrorCode);
            writer.WriteStringValue("more info", MoreInfo);
            writer.WriteStringValue("userMessage", UserMessage);
        }
    }
}
#pragma warning restore CS0618
