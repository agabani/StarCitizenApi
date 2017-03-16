using Newtonsoft.Json;
using StarCitizenApi.ArkStarmap.Model.Shared.Assests;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects
{
    public class CelestialObject : CObject
    {
        [JsonProperty("children")]
        public Child[] Children { get; set; }

        [JsonProperty("model")]
        public object Models { get; set; }

        [JsonProperty("texture")]
        public Texture Texture { get; set; }

        [JsonProperty("thumbnail")]
        public Thumbnail<ThumbnailImage> Thumbnail { get; set; }
    }
}