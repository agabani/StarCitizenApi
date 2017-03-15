using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.BootUp
{
    public class SystemAffiliation : Affiliation
    {
        [JsonProperty("membership.id")]
        public string MembershipId { get; set; }
    }
}