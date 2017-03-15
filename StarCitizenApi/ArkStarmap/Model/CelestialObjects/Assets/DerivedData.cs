using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects.Assets
{
    public class DerivedData
    {
        [JsonProperty("sizes")]
        public Sizes Sizes { get; set; }
    }
}