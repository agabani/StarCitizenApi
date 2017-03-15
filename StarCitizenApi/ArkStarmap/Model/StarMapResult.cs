using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model
{
    public class StarMapResult<TData>
    {
        [JsonProperty("success")]
        public int Success { get; set; }

        [JsonProperty("data")]
        public TData Data { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }
    }
}