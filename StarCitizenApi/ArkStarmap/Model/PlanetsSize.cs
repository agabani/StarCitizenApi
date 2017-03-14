using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model
{
    [JsonObject]
    public class PlanetsSize
    {
        [JsonProperty(PropertyName = "min")]
        public double Min { get; set; }

        [JsonProperty(PropertyName = "max")]
        public double Max { get; set; }

        [JsonProperty(PropertyName = "kFactor")]
        public double KFactor { get; set; }
    }
}