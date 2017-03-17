using Newtonsoft.Json;
using StarCitizenApi.ArkStarmap.Model.Shared;

namespace StarCitizenApi.ArkStarmap.Model.BootUp
{
    public class Tunnel : Identity
    {
        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("entry_id")]
        public string EntryId { get; set; }

        [JsonProperty("exit_id")]
        public string ExitId { get; set; }

        [JsonProperty("entry")]
        public TunnelEntrance Entry { get; set; }

        [JsonProperty("exit")]
        public TunnelEntrance Exit { get; set; }
    }
}