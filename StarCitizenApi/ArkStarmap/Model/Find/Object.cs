using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.Find
{
    public class Object : System
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("star_system_id")]
        public string StarSystemId { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("star_system")]
        public StarSystem StarSystem { get; set; }
    }
}