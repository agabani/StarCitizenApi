using Newtonsoft.Json;
using StarCitizenApi.ArkStarmap.Model.Shared.ShaderData;

namespace StarCitizenApi.ArkStarmap.Model.StarSystem.ShaderData
{
    public class CelestialShaderData
    {
        [JsonProperty("orbitalMin")]
        public double OrbitalMin { get; set; }

        [JsonProperty("orbitalMax")]
        public double OrbitalMax { get; set; }

        [JsonProperty("orbitalFactor")]
        public double OrbitalFactor { get; set; }

        [JsonProperty("sun")]
        public Sun Sun { get; set; }

        [JsonProperty("radius")]
        public double Radius { get; set; }

        [JsonProperty("ring")]
        public PhysicsRing Ring { get; set; }

        [JsonProperty("highlight")]
        public Highlight Highlight { get; set; }

        [JsonProperty("orbitalColor")]
        public string OrbitalColor { get; set; }

        [JsonProperty("orbitalHighlightColor")]
        public string OrbitalHighlightColor { get; set; }

        [JsonProperty("fullturn")]
        public double Fullturn { get; set; }
    }
}