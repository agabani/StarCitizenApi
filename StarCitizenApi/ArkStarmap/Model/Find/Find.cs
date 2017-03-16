using Newtonsoft.Json;
using StarCitizenApi.ArkStarmap.Model.Shared;

namespace StarCitizenApi.ArkStarmap.Model.Find
{
    public class Find
    {
        [JsonProperty("systems")]
        public Paged<Entity> Systems { get; set; }

        [JsonProperty("objects")]
        public Paged<Object> Objects { get; set; }
    }
}