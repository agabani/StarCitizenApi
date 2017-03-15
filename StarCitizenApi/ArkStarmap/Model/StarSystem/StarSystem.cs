using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.StarSystem
{
    public class StarSystem
    {
        [JsonProperty("success")]
        public int Success { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }
    }
}