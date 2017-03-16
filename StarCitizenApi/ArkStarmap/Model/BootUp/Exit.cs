using Newtonsoft.Json;
using StarCitizenApi.ArkStarmap.Model.Shared;

namespace StarCitizenApi.ArkStarmap.Model.BootUp
{
    public class Exit : Entity
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("star_system_id")]
        public string StarSystemId { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("distance")]
        public string Distance { get; set; }
    }
}