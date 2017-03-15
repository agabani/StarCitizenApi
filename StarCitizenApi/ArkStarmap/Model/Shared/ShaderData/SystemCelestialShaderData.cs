using Newtonsoft.Json;
using StarCitizenApi.ArkStarmap.Model.StarSystem.ShaderData;

namespace StarCitizenApi.ArkStarmap.Model.Shared.ShaderData
{
    public class SystemCelestialShaderData : CelestialShaderData
    {
        [JsonProperty("sun")]
        public Sun Sun { get; set; }

        [JsonProperty("radius")]
        public double Radius { get; set; }

        [JsonProperty("ring")]
        public new SystemRing Ring { get; set; }

        [JsonProperty("fullturn")]
        public double Fullturn { get; set; }
    }
}