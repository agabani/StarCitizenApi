using Newtonsoft.Json;
using StarCitizenApi.ArkStarmap.Model.Shared.Assests;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects
{
    public class ParentCelestialObject : CelestialObject
    {
        [JsonProperty("children")]
        public ChildCelestialObject[] Children { get; set; }

        [JsonProperty("model")]
        public object Models { get; set; }

        [JsonProperty("texture")]
        public Texture Texture { get; set; }

        [JsonProperty("thumbnail")]
        public Thumbnail<ThumbnailImage> Thumbnail { get; set; }
    }
}