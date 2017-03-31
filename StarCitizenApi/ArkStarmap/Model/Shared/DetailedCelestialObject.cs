using Newtonsoft.Json;
using StarCitizenApi.ArkStarmap.Model.Shared.Assests;

namespace StarCitizenApi.ArkStarmap.Model.Shared
{
    public class DetailedCelestialObject : CelestialObject
    {
        [JsonProperty("model")]
        public object Models { get; set; }

        [JsonProperty("texture")]
        public Texture Texture { get; set; }

        [JsonProperty("thumbnail")]
        public Thumbnail<Images> Thumbnail { get; set; }
    }
}