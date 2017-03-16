using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.Shared.ShaderData
{
    public class CelestialShaderData : ShaderData
    {
        [JsonProperty("ring")]
        public SystemRing Ring { get; set; }

        [JsonProperty("sun")]
        public Sun Sun { get; set; }

        [JsonProperty("orbitalColor")]
        public string OrbitalColor { get; set; }

        [JsonProperty("orbitalHighlightColor")]
        public string OrbitalHighlightColor { get; set; }

        [JsonProperty("radius")]
        public double Radius { get; set; }

        [JsonProperty("fullturn")]
        public double FullTurn { get; set; }
    }
}