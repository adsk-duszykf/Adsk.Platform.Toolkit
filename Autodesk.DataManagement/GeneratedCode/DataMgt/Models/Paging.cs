// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.DataManagement.Models {
    /// <summary>
    /// Links for multiple pages of data.
    /// </summary>
    public class Paging : IParsable 
    {
        /// <summary>The first property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Paging_first? First { get; set; }
#nullable restore
#else
        public Paging_first First { get; set; }
#endif
        /// <summary>The next property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Paging_next? Next { get; set; }
#nullable restore
#else
        public Paging_next Next { get; set; }
#endif
        /// <summary>The prev property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Paging_prev? Prev { get; set; }
#nullable restore
#else
        public Paging_prev Prev { get; set; }
#endif
        /// <summary>The self property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Paging_self? Self { get; set; }
#nullable restore
#else
        public Paging_self Self { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Paging"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Paging CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Paging();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"first", n => { First = n.GetObjectValue<Paging_first>(Paging_first.CreateFromDiscriminatorValue); } },
                {"next", n => { Next = n.GetObjectValue<Paging_next>(Paging_next.CreateFromDiscriminatorValue); } },
                {"prev", n => { Prev = n.GetObjectValue<Paging_prev>(Paging_prev.CreateFromDiscriminatorValue); } },
                {"self", n => { Self = n.GetObjectValue<Paging_self>(Paging_self.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Paging_first>("first", First);
            writer.WriteObjectValue<Paging_next>("next", Next);
            writer.WriteObjectValue<Paging_prev>("prev", Prev);
            writer.WriteObjectValue<Paging_self>("self", Self);
        }
    }
}
