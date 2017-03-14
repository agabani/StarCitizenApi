using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model
{
    [JsonObject]
    public class Data
    {
        [JsonProperty(PropertyName = "rowcount")]
        public double Rowcount { get; set; }

        [JsonProperty(PropertyName = "totalrows")]
        public string TotalRows { get; set; }

        [JsonProperty(PropertyName = "estimatedrows")]
        public bool EstimatedRows { get; set; }

        [JsonProperty(PropertyName = "pagesize")]
        public double PageSize { get; set; }

        [JsonProperty(PropertyName = "pagecount")]
        public string PageCount { get; set; }

        [JsonProperty(PropertyName = "page")]
        public double Page { get; set; }

        [JsonProperty(PropertyName = "offset")]
        public double Offset { get; set; }

        [JsonProperty(PropertyName = "startrow")]
        public double StartRow { get; set; }

        [JsonProperty(PropertyName = "resultset")]
        public System[] ResultSet { get; set; }
    }
}