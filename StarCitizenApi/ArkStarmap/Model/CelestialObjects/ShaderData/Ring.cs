using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects.ShaderData
{
    public class Ring
    {
        [JsonProperty("color1")]
        public string Color1 { get; set; }

        [JsonProperty("color2")]
        public string Color2 { get; set; }

        [JsonProperty("radius1")]
        public double Radius1 { get; set; }

        [JsonProperty("radius2")]
        public double Radius2 { get; set; }
    }
}