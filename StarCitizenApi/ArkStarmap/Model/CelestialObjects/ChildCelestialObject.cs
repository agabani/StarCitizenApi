using Newtonsoft.Json;
using StarCitizenApi.ArkStarmap.Model.CelestialObjects.Assets;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects
{
    public class ChildCelestialObject : CelestialObject
    {
        [JsonProperty("media")]
        public Media[] Media { get; set; }
    }
}