using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects
{
    public class DeletableProperties : Properties
    {
        [JsonProperty("delete")]
        public string delete { get; set; }
    }
}