using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects
{
    public class CeletialObjects
    {
        [JsonProperty("success")]
        public int success { get; set; }

        [JsonProperty("data")]
        public Data data { get; set; }

        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("msg")]
        public string msg { get; set; }
    }
}

