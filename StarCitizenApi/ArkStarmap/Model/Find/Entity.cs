using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.Find
{
    public class Entity
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }
}