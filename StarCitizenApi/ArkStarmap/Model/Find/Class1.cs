using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.Find
{
    public class Find
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

    public class Data
    {
        [JsonProperty("systems")]
        public Systems systems { get; set; }

        [JsonProperty("objects")]
        public Objects objects { get; set; }
    }

    public class Systems
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

    public class Resultset
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("code")]
        public string code { get; set; }
    }

    public class Objects
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
        public Resultset1[] resultset { get; set; }
    }

    public class Resultset1
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("star_system_id")]
        public string star_system_id { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("designation")]
        public string designation { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("star_system")]
        public Star_System star_system { get; set; }
    }

    public class Star_System
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("code")]
        public string code { get; set; }
    }
}