using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.StarSystem.ShaderData
{
    public class PlanetsSize
    {
        [JsonProperty("min")]
        public double Min { get; set; }

        [JsonProperty("max")]
        public double Max { get; set; }

        [JsonProperty("kFactor")]
        public double KFactor { get; set; }
    }
}