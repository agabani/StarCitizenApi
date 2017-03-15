using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects
{
    public class Ring
    {
        [JsonProperty("color1")]
        public string color1 { get; set; }

        [JsonProperty("color2")]
        public string color2 { get; set; }

        [JsonProperty("radius1")]
        public float radius1 { get; set; }

        [JsonProperty("radius2")]
        public int radius2 { get; set; }
    }
}