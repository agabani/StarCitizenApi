using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.Find
{
    public class Object : Entity
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("star_system_id")]
        public string StarSystemId { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("star_system")]
        public Entity StarSystem { get; set; }
    }
}