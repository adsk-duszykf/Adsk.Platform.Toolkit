using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Autodesk.ModelDerivative.Helpers.Models;

public class ParsedSpecificProperties
{

    [JsonPropertyName("type")]
    [AllowNull]
    public string Type { get; set; }

    [JsonPropertyName("collection")]
    public List<ObjectCollection> Collections { get; set; } = [];

    public partial class ObjectCollection
    {
        [JsonPropertyName("objectid")]
        public int ObjectId { get; set; }

        [JsonPropertyName("name")]
        [AllowNull]
        public string Name { get; set; }

        [JsonPropertyName("externalId")]
        [AllowNull]
        public string ExternalId { get; set; }

        [JsonPropertyName("properties")]
        [AllowNull]
        public JsonNode Properties { get; set; }
    }
}
