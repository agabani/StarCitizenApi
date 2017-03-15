using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.BootUp
{
    public class Systems
    {
        [JsonProperty("rowcount")]
        public int RowCount { get; set; }

        [JsonProperty("totalrows")]
        public string TotalRows { get; set; }

        [JsonProperty("estimatedrows")]
        public bool EstimatedRows { get; set; }

        [JsonProperty("pagesize")]
        public int PageSize { get; set; }

        [JsonProperty("pagecount")]
        public object PageCount { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("startrow")]
        public int StartRow { get; set; }

        [JsonProperty("resultset")]
        public SystemResultSet[] ResultSet { get; set; }
    }
}