// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.CostManagement.Models {
    public class Distribution : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ID of budget to distribute.</summary>
        public Guid? BudgetId { get; set; }
        /// <summary>The timestamp of the date and time the item was created, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>The user who created the project milestone. This is the ID of a user managed by BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatorId { get; private set; }
#nullable restore
#else
        public string CreatorId { get; private set; }
#endif
        /// <summary>The planned end day of distribution.</summary>
        public Date? EndDate { get; set; }
        /// <summary>Unique identifier of the distribution.</summary>
        public Guid? Id { get; set; }
        /// <summary>The time period of distribution. Possible values are ``monthly``, ``weekly``, ``bi-monthly``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Interval { get; set; }
#nullable restore
#else
        public string Interval { get; set; }
#endif
        /// <summary>Define the latest version if the value is ``true``.</summary>
        public bool? IsCurrent { get; set; }
        /// <summary>The planned start day of distribution.</summary>
        public Date? StartDate { get; set; }
        /// <summary>The timestamp of the date and time the item was updated, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>The user who last update the project milestone. This is the ID of a user managed by BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UpdatedBy { get; private set; }
#nullable restore
#else
        public string UpdatedBy { get; private set; }
#endif
        /// <summary>Distribution version.</summary>
        public double? Version { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="Distribution"/> and sets the default values.
        /// </summary>
        public Distribution()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Distribution"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Distribution CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Distribution();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"budgetId", n => { BudgetId = n.GetGuidValue(); } },
                {"createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"creatorId", n => { CreatorId = n.GetStringValue(); } },
                {"endDate", n => { EndDate = n.GetDateValue(); } },
                {"id", n => { Id = n.GetGuidValue(); } },
                {"interval", n => { Interval = n.GetStringValue(); } },
                {"isCurrent", n => { IsCurrent = n.GetBoolValue(); } },
                {"startDate", n => { StartDate = n.GetDateValue(); } },
                {"updatedAt", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                {"updatedBy", n => { UpdatedBy = n.GetStringValue(); } },
                {"version", n => { Version = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteGuidValue("budgetId", BudgetId);
            writer.WriteDateValue("endDate", EndDate);
            writer.WriteGuidValue("id", Id);
            writer.WriteStringValue("interval", Interval);
            writer.WriteBoolValue("isCurrent", IsCurrent);
            writer.WriteDateValue("startDate", StartDate);
            writer.WriteDoubleValue("version", Version);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
