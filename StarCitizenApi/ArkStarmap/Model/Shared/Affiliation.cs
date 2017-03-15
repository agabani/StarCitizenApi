using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.Shared
{
    public class Affiliation
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }
}