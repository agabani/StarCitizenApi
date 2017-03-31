using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects.Assets
{
    public class DeletableProperties<THeight> : Properties<THeight>
    {
        [JsonProperty("delete")]
        public string Delete { get; set; }
    }
}