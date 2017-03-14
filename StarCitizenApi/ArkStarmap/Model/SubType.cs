using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model
{
    [JsonObject]
    public class SubType
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
}
