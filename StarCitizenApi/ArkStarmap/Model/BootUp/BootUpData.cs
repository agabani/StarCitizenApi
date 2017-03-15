using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.BootUp
{
    public class BootUpData
    {
        [JsonProperty("config")]
        public Config Config { get; set; }

        [JsonProperty("systems")]
        public Paged<System> Systems { get; set; }

        [JsonProperty("tunnels")]
        public Paged<Tunnel> Tunnels { get; set; }

        [JsonProperty("species")]
        public Paged<Specie> Species { get; set; }

        [JsonProperty("affiliations")]
        public Paged<Affiliation> Affiliations { get; set; }
    }
}