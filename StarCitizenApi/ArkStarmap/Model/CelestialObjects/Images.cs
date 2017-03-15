using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects
{
    public class Images
    {
        [JsonProperty("post")]
        public string post { get; set; }

        [JsonProperty("product_thumb_large")]
        public string product_thumb_large { get; set; }

        [JsonProperty("subscribers_vault_thumbnail")]
        public string subscribers_vault_thumbnail { get; set; }
    }
}