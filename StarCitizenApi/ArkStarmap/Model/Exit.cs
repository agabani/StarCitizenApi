using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model
{
    public class Exit
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("star_system_id")]
        public string StarSystemId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("name")]
        public object Name { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("distance")]
        public string Distance { get; set; }
    }
}