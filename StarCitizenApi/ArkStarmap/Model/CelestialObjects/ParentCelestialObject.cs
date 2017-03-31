using Newtonsoft.Json;
using StarCitizenApi.ArkStarmap.Model.Shared;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects
{
    public class ParentCelestialObject : DetailedCelestialObject
    {
        [JsonProperty("children")]
        public ChildCelestialObject[] Children { get; set; }
    }
}