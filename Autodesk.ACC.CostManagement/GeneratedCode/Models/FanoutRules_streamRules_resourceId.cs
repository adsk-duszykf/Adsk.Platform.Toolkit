// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.CostManagement.Models {
    public class FanoutRules_streamRules_resourceId : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The delimiter property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Delimiter { get; set; }
#nullable restore
#else
        public string Delimiter { get; set; }
#endif
        /// <summary>The resourcePositions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<FanoutRules_streamRules_resourceId_resourcePositions>? ResourcePositions { get; set; }
#nullable restore
#else
        public List<FanoutRules_streamRules_resourceId_resourcePositions> ResourcePositions { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="FanoutRules_streamRules_resourceId"/> and sets the default values.
        /// </summary>
        public FanoutRules_streamRules_resourceId()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="FanoutRules_streamRules_resourceId"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static FanoutRules_streamRules_resourceId CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FanoutRules_streamRules_resourceId();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"delimiter", n => { Delimiter = n.GetStringValue(); } },
                {"resourcePositions", n => { ResourcePositions = n.GetCollectionOfObjectValues<FanoutRules_streamRules_resourceId_resourcePositions>(FanoutRules_streamRules_resourceId_resourcePositions.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("delimiter", Delimiter);
            writer.WriteCollectionOfObjectValues<FanoutRules_streamRules_resourceId_resourcePositions>("resourcePositions", ResourcePositions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
