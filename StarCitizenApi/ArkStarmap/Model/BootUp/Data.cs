using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.BootUp
{
    public class Data
    {
        [JsonProperty("config")]
        public Config Config { get; set; }

        [JsonProperty("systems")]
        public Systems Systems { get; set; }

        [JsonProperty("tunnels")]
        public Tunnels Tunnels { get; set; }

        [JsonProperty("species")]
        public Species Species { get; set; }

        [JsonProperty("affiliations")]
        public Affiliations Affiliations { get; set; }
    }
}