using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.Shared.ShaderData
{
    public class ShaderData
    {
        [JsonProperty("ring")]
        public SystemRing Ring { get; set; }

        [JsonProperty("sun")]
        public Sun Sun { get; set; }

        [JsonProperty("blackhole")]
        public SystemBlackhole Blackhole { get; set; }

        [JsonProperty("orbitalMin")]
        public double OrbitalMin { get; set; }

        [JsonProperty("orbitalMax")]
        public double OrbitalMax { get; set; }

        [JsonProperty("orbitalFactor")]
        public double OrbitalFactor { get; set; }

        [JsonProperty("highlight")]
        public Highlight Highlight { get; set; }

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