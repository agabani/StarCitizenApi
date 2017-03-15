using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.Find
{
    public class Resultset1
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("star_system_id")]
        public string StarSystemId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("star_system")]
        public StarSystem StarSystem { get; set; }
    }
}