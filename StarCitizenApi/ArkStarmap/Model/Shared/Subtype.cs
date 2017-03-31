using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.Shared
{
    public class SubType : Identity
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}