using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects.Assets
{
    public class Texture
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("images")]
        public TextureImages Images { get; set; }
    }
}