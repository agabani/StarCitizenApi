using Newtonsoft.Json;
using StarCitizenApi.ArkStarmap.Model.Shared;

namespace StarCitizenApi.ArkStarmap.Model.BootUp
{
    public class Specie : Identity
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }
}