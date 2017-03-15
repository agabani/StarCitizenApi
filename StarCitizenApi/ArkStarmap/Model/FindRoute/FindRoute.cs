using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.FindRoute
{
    public class FindRoute
    {
        [JsonProperty("shortest")]
        public Route Shortest { get; set; }

        [JsonProperty("leastjumps")]
        public Route LeastJumps { get; set; }
    }
}