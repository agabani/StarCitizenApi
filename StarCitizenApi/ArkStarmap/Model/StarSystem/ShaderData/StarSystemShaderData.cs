using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.StarSystem.ShaderData
{
    public class StarSystemShaderData
    {
        [JsonProperty("lightColor")]
        public string LightColor { get; set; }

        [JsonProperty("starfield")]
        public Starfield Starfield { get; set; }

        [JsonProperty("planetsSize")]
        public PlanetsSize PlanetsSize { get; set; }
    }
}