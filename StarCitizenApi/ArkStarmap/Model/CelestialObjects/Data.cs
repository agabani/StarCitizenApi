using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects
{
    public class Data
    {
        [JsonProperty("rowcount")]
        public int rowcount { get; set; }

        [JsonProperty("totalrows")]
        public string totalrows { get; set; }

        [JsonProperty("estimatedrows")]
        public bool estimatedrows { get; set; }

        [JsonProperty("pagesize")]
        public int pagesize { get; set; }

        [JsonProperty("pagecount")]
        public object pagecount { get; set; }

        [JsonProperty("page")]
        public int page { get; set; }

        [JsonProperty("offset")]
        public int offset { get; set; }

        [JsonProperty("startrow")]
        public int startrow { get; set; }

        [JsonProperty("resultset")]
        public Resultset[] resultset { get; set; }
    }
}