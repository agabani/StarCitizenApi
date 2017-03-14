using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model
{
    [JsonObject]
    public class ShaderData
    {
        [JsonProperty(PropertyName = "lightColor")]
        public string LightColor { get; set; }

        [JsonProperty(PropertyName = "starfield")]
        public Starfield Starfield { get; set; }

        [JsonProperty(PropertyName = "planetsSize")]
        public PlanetsSize PlanetsSize { get; set; }

        [JsonProperty(PropertyName = "orbitalMin")]
        public double OrbitalMin { get; set; }

        [JsonProperty(PropertyName = "orbitalMax")]
        public double OrbitalMax { get; set; }

        [JsonProperty(PropertyName = "orbitalFactor")]
        public double OrbitalFactor { get; set; }

        [JsonProperty(PropertyName = "sun")]
        public Sun Sun { get; set; }

        [JsonProperty(PropertyName = "radius")]
        public double Radius { get; set; }
    }
}