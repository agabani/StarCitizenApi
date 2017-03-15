using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model
{
    public class SpecieResultSet
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }
}