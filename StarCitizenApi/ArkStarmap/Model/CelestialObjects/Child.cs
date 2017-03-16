using Newtonsoft.Json;
using StarCitizenApi.ArkStarmap.Model.CelestialObjects.Assets;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects
{
    public class Child : CObject
    {
        [JsonProperty("media")]
        public Media[] Media { get; set; }
    }
}