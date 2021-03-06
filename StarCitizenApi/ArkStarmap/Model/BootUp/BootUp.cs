using Newtonsoft.Json;
using StarCitizenApi.ArkStarmap.Model.Shared;

namespace StarCitizenApi.ArkStarmap.Model.BootUp
{
    public class BootUp
    {
        [JsonProperty("config")]
        public Config Config { get; set; }

        [JsonProperty("systems")]
        public Paged<Shared.StarSystem> Systems { get; set; }

        [JsonProperty("tunnels")]
        public Paged<Tunnel> Tunnels { get; set; }

        [JsonProperty("species")]
        public Paged<Specie> Species { get; set; }

        [JsonProperty("affiliations")]
        public Paged<Affiliation> Affiliations { get; set; }
    }
}