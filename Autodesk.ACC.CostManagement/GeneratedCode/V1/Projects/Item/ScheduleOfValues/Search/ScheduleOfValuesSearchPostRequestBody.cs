// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.ScheduleOfValues.Search {
    public class ScheduleOfValuesSearchPostRequestBody : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The conditions to query against items, such as ``id=0`` or (``id&gt;2`` and ``id&lt;4``). This parameter is deprecated in favor of the ``filter[]`` based syntax.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ScheduleOfValuesSearchPostRequestBody_q>? Q { get; set; }
#nullable restore
#else
        public List<ScheduleOfValuesSearchPostRequestBody_q> Q { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ScheduleOfValuesSearchPostRequestBody"/> and sets the default values.
        /// </summary>
        public ScheduleOfValuesSearchPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ScheduleOfValuesSearchPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ScheduleOfValuesSearchPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ScheduleOfValuesSearchPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"q", n => { Q = n.GetCollectionOfObjectValues<ScheduleOfValuesSearchPostRequestBody_q>(ScheduleOfValuesSearchPostRequestBody_q.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ScheduleOfValuesSearchPostRequestBody_q>("q", Q);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
