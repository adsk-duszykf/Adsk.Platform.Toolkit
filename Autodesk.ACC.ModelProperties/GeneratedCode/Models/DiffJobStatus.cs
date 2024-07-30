// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.ModelProperties.Models
{
    /// <summary>
    /// diff job status
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class DiffJobStatus : IParsable
    {
        /// <summary>Parameters to control content within the Index</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.ModelProperties.Models.IndexContents? Contents { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.ModelProperties.Models.IndexContents Contents { get; set; }
#endif
        /// <summary>list all current versions this index depends upon</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CurVersionUrns { get; set; }
#nullable restore
#else
        public List<string> CurVersionUrns { get; set; }
#endif
        /// <summary>diff id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DiffId { get; set; }
#nullable restore
#else
        public string DiffId { get; set; }
#endif
        /// <summary>errors</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.ModelProperties.Models.ResourceError>? Errors { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.ModelProperties.Models.ResourceError> Errors { get; set; }
#endif
        /// <summary>url for downloading the diff fields</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FieldsUrl { get; set; }
#nullable restore
#else
        public string FieldsUrl { get; set; }
#endif
        /// <summary>url for downloading the diff manifest</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManifestUrl { get; set; }
#nullable restore
#else
        public string ManifestUrl { get; set; }
#endif
        /// <summary>list all previous versions this index depends upon</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? PrevVersionUrns { get; set; }
#nullable restore
#else
        public List<string> PrevVersionUrns { get; set; }
#endif
        /// <summary>project id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProjectId { get; set; }
#nullable restore
#else
        public string ProjectId { get; set; }
#endif
        /// <summary>url for downloading the diff properties</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PropertiesUrl { get; set; }
#nullable restore
#else
        public string PropertiesUrl { get; set; }
#endif
        /// <summary>query id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? QueryId { get; set; }
#nullable restore
#else
        public string QueryId { get; set; }
#endif
        /// <summary>url for downloading the query result</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? QueryResultsUrl { get; set; }
#nullable restore
#else
        public string QueryResultsUrl { get; set; }
#endif
        /// <summary>timestamp</summary>
        public DateTimeOffset? RetryAt { get; set; }
        /// <summary>unique url for this job status</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SelfUrl { get; set; }
#nullable restore
#else
        public string SelfUrl { get; set; }
#endif
        /// <summary>job status</summary>
        public global::Autodesk.ACC.ModelProperties.Models.JobState? State { get; set; }
        /// <summary>some higher level diff statistics</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.ModelProperties.Models.DiffStats? Stats { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.ModelProperties.Models.DiffStats Stats { get; set; }
#endif
        /// <summary>type</summary>
        public global::Autodesk.ACC.ModelProperties.Models.DiffJobStatus_type? Type { get; set; }
        /// <summary>timestamp</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.ModelProperties.Models.DiffJobStatus"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.ModelProperties.Models.DiffJobStatus CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.ModelProperties.Models.DiffJobStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "contents", n => { Contents = n.GetObjectValue<global::Autodesk.ACC.ModelProperties.Models.IndexContents>(global::Autodesk.ACC.ModelProperties.Models.IndexContents.CreateFromDiscriminatorValue); } },
                { "curVersionUrns", n => { CurVersionUrns = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "diffId", n => { DiffId = n.GetStringValue(); } },
                { "errors", n => { Errors = n.GetCollectionOfObjectValues<global::Autodesk.ACC.ModelProperties.Models.ResourceError>(global::Autodesk.ACC.ModelProperties.Models.ResourceError.CreateFromDiscriminatorValue)?.AsList(); } },
                { "fieldsUrl", n => { FieldsUrl = n.GetStringValue(); } },
                { "manifestUrl", n => { ManifestUrl = n.GetStringValue(); } },
                { "prevVersionUrns", n => { PrevVersionUrns = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "projectId", n => { ProjectId = n.GetStringValue(); } },
                { "propertiesUrl", n => { PropertiesUrl = n.GetStringValue(); } },
                { "queryId", n => { QueryId = n.GetStringValue(); } },
                { "queryResultsUrl", n => { QueryResultsUrl = n.GetStringValue(); } },
                { "retryAt", n => { RetryAt = n.GetDateTimeOffsetValue(); } },
                { "selfUrl", n => { SelfUrl = n.GetStringValue(); } },
                { "state", n => { State = n.GetEnumValue<global::Autodesk.ACC.ModelProperties.Models.JobState>(); } },
                { "stats", n => { Stats = n.GetObjectValue<global::Autodesk.ACC.ModelProperties.Models.DiffStats>(global::Autodesk.ACC.ModelProperties.Models.DiffStats.CreateFromDiscriminatorValue); } },
                { "type", n => { Type = n.GetEnumValue<global::Autodesk.ACC.ModelProperties.Models.DiffJobStatus_type>(); } },
                { "updatedAt", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Autodesk.ACC.ModelProperties.Models.IndexContents>("contents", Contents);
            writer.WriteCollectionOfPrimitiveValues<string>("curVersionUrns", CurVersionUrns);
            writer.WriteStringValue("diffId", DiffId);
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.ModelProperties.Models.ResourceError>("errors", Errors);
            writer.WriteStringValue("fieldsUrl", FieldsUrl);
            writer.WriteStringValue("manifestUrl", ManifestUrl);
            writer.WriteCollectionOfPrimitiveValues<string>("prevVersionUrns", PrevVersionUrns);
            writer.WriteStringValue("projectId", ProjectId);
            writer.WriteStringValue("propertiesUrl", PropertiesUrl);
            writer.WriteStringValue("queryId", QueryId);
            writer.WriteStringValue("queryResultsUrl", QueryResultsUrl);
            writer.WriteDateTimeOffsetValue("retryAt", RetryAt);
            writer.WriteStringValue("selfUrl", SelfUrl);
            writer.WriteEnumValue<global::Autodesk.ACC.ModelProperties.Models.JobState>("state", State);
            writer.WriteObjectValue<global::Autodesk.ACC.ModelProperties.Models.DiffStats>("stats", Stats);
            writer.WriteEnumValue<global::Autodesk.ACC.ModelProperties.Models.DiffJobStatus_type>("type", Type);
            writer.WriteDateTimeOffsetValue("updatedAt", UpdatedAt);
        }
    }
}
