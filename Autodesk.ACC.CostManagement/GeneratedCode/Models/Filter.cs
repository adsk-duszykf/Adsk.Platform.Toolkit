// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Autodesk.ACC.CostManagement.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Filter : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The columnsState property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.CostManagement.Models.ColumnState>? ColumnsState { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.CostManagement.Models.ColumnState> ColumnsState { get; set; }
#endif
        /// <summary>The timestamp of the date and time the item was created, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>The creatorId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatorId { get; set; }
#nullable restore
#else
        public string CreatorId { get; set; }
#endif
        /// <summary>The filters property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Autodesk.ACC.CostManagement.Models.FilterExpression>? Filters { get; set; }
#nullable restore
#else
        public List<global::Autodesk.ACC.CostManagement.Models.FilterExpression> Filters { get; set; }
#endif
        /// <summary>The id property</summary>
        public Guid? Id { get; private set; }
        /// <summary>The default saved view .</summary>
        public bool? IsDefault { get; set; }
        /// <summary>The flag of saved view .</summary>
        public bool? IsPredefined { get; set; }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The scope of filter to query.</summary>
        public global::Autodesk.ACC.CostManagement.Models.Filter_scope? Scope { get; set; }
        /// <summary>The type property</summary>
        public global::Autodesk.ACC.CostManagement.Models.Filter_type? Type { get; set; }
        /// <summary>The timestamp of the date and time the item was updated, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>The view state.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Autodesk.ACC.CostManagement.Models.Filter_viewState? ViewState { get; set; }
#nullable restore
#else
        public global::Autodesk.ACC.CostManagement.Models.Filter_viewState ViewState { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Autodesk.ACC.CostManagement.Models.Filter"/> and sets the default values.
        /// </summary>
        public Filter()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Autodesk.ACC.CostManagement.Models.Filter"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Autodesk.ACC.CostManagement.Models.Filter CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Autodesk.ACC.CostManagement.Models.Filter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "columnsState", n => { ColumnsState = n.GetCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.ColumnState>(global::Autodesk.ACC.CostManagement.Models.ColumnState.CreateFromDiscriminatorValue)?.AsList(); } },
                { "createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "creatorId", n => { CreatorId = n.GetStringValue(); } },
                { "filters", n => { Filters = n.GetCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.FilterExpression>(global::Autodesk.ACC.CostManagement.Models.FilterExpression.CreateFromDiscriminatorValue)?.AsList(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "isDefault", n => { IsDefault = n.GetBoolValue(); } },
                { "isPredefined", n => { IsPredefined = n.GetBoolValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "scope", n => { Scope = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.Filter_scope>(); } },
                { "type", n => { Type = n.GetEnumValue<global::Autodesk.ACC.CostManagement.Models.Filter_type>(); } },
                { "updatedAt", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                { "viewState", n => { ViewState = n.GetObjectValue<global::Autodesk.ACC.CostManagement.Models.Filter_viewState>(global::Autodesk.ACC.CostManagement.Models.Filter_viewState.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.ColumnState>("columnsState", ColumnsState);
            writer.WriteStringValue("creatorId", CreatorId);
            writer.WriteCollectionOfObjectValues<global::Autodesk.ACC.CostManagement.Models.FilterExpression>("filters", Filters);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteBoolValue("isPredefined", IsPredefined);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.Filter_scope>("scope", Scope);
            writer.WriteEnumValue<global::Autodesk.ACC.CostManagement.Models.Filter_type>("type", Type);
            writer.WriteObjectValue<global::Autodesk.ACC.CostManagement.Models.Filter_viewState>("viewState", ViewState);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
