using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects.ShaderData
{
    public class CelestialShaderData
    {
        [JsonProperty("orbitalMin")]
        public double OrbitalMin { get; set; }

        [JsonProperty("orbitalMax")]
        public double OrbitalMax { get; set; }

        [JsonProperty("orbitalFactor")]
        public double OrbitalFactor { get; set; }

        [JsonProperty("ring")]
        public Ring Ring { get; set; }

        [JsonProperty("highlight")]
        public Highlight Highlight { get; set; }

        [JsonProperty("orbitalColor")]
        public string OrbitalColor { get; set; }

        [JsonProperty("orbitalHighlightColor")]
        public string OrbitalHighlightColor { get; set; }
    }
}