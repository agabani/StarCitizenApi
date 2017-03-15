using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects
{
    public class Derived_Data
    {
        [JsonProperty("sizes")]
        public Sizes sizes { get; set; }
    }
}