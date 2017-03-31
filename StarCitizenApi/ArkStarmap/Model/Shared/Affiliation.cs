using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.Shared
{
    public class Affiliation : Identity
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }
}