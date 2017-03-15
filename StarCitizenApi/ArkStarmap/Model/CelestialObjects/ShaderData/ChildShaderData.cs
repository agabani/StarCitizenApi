using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects.ShaderData
{
    public class ChildShaderData
    {
        [JsonProperty("orbitalMin")]
        public double OrbitalMin { get; set; }

        [JsonProperty("orbitalMax")]
        public double OrbitalMax { get; set; }

        [JsonProperty("orbitalFactor")]
        public double OrbitalFactor { get; set; }

        [JsonProperty("highlight")]
        public Highlight Highlight { get; set; }

        [JsonProperty("radius")]
        public double Radius { get; set; }
    }
}