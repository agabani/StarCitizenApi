using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.Route
{
    public class Data
    {
        [JsonProperty("shortest")]
        public Route Shortest { get; set; }

        [JsonProperty("leastjumps")]
        public Route LeastJumps { get; set; }
    }
}