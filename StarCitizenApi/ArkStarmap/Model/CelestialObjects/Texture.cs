using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects
{
    public class Texture
    {
        [JsonProperty("slug")]
        public string slug { get; set; }

        [JsonProperty("source")]
        public string source { get; set; }

        [JsonProperty("images")]
        public Images images { get; set; }
    }
}