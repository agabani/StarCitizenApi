using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects
{
    public class DeletableProperties<THeight> : Properties<THeight>
    {
        [JsonProperty("delete")]
        public string delete { get; set; }
    }
}