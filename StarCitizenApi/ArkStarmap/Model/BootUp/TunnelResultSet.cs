using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.BootUp
{
    public class TunnelResultSet
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public object Name { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("entry_id")]
        public string EntryId { get; set; }

        [JsonProperty("exit_id")]
        public string ExitId { get; set; }

        [JsonProperty("entry")]
        public Entry Entry { get; set; }

        [JsonProperty("exit")]
        public Exit Exit { get; set; }
    }
}