using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.StarSystem
{
    public class ShaderData
    {
        [JsonProperty("lightColor")]
        public string LightColor { get; set; }

        [JsonProperty("starfield")]
        public Starfield Starfield { get; set; }

        [JsonProperty("planetsSize")]
        public PlanetsSize PlanetsSize { get; set; }
    }
}