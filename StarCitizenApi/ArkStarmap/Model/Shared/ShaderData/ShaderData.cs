using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.Shared.ShaderData
{
    public class ShaderData
    {
        [JsonProperty("orbitalMin")]
        public double OrbitalMin { get; set; }

        [JsonProperty("orbitalMax")]
        public double OrbitalMax { get; set; }

        [JsonProperty("orbitalFactor")]
        public double OrbitalFactor { get; set; }

        [JsonProperty("highlight")]
        public Highlight Highlight { get; set; }
    }
}