using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.Shared
{
    public class Subtype
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}