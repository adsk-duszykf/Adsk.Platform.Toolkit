using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Autodesk.ModelDerivative.Helpers.Models;

public class ParsedSpecificProperties
{

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("collection")]
    public List<ObjectCollection> Collections { get; set; } = [];

    public partial class ObjectCollection
    {
        [JsonPropertyName("objectid")]
        public int ObjectId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("externalId")]
        public string ExternalId { get; set; }

        [JsonPropertyName("properties")]
        public JsonNode Properties { get; set; }
    }
}
