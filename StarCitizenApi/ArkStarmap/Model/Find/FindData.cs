using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.Find
{
    public class FindData
    {
        [JsonProperty("systems")]
        public Systems Systems { get; set; }

        [JsonProperty("objects")]
        public Objects Objects { get; set; }
    }
}