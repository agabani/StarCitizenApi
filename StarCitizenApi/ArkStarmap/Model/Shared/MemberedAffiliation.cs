using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.Shared
{
    public class MemberedAffiliation : Affiliation
    {
        [JsonProperty("membership.id")]
        public string MembershipId { get; set; }
    }
}