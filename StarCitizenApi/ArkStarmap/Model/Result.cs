using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model
{
    [JsonObject]
    public class Result
    {
        [JsonProperty(PropertyName = "success")]
        public double Success { get; set; }

        [JsonProperty(PropertyName = "data")]
        public Data Data { get; set; }

        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "msg")]
        public string Msg { get; set; }
    }
}