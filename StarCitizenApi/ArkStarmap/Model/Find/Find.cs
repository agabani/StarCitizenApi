using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.Find
{
    public class Find
    {
        [JsonProperty("success")]
        public int Success { get; set; }

        [JsonProperty("data")]
        public FindData Data { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }
    }
}