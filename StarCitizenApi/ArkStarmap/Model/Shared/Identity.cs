using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.Shared
{
    public class Identity
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}