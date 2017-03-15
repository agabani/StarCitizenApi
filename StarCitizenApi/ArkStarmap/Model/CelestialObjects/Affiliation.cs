using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects
{
    public class Affiliation
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("color")]
        public string color { get; set; }

        [JsonProperty("membershipid")]
        public string membershipid { get; set; }
    }
}