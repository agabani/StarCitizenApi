using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects.Assets
{
    public class TextureImages
    {
        [JsonProperty("post")]
        public string Post { get; set; }

        [JsonProperty("product_thumb_large")]
        public string ProductThumbLarge { get; set; }

        [JsonProperty("subscribers_vault_thumbnail")]
        public string SubscribersVaultThumbnail { get; set; }
    }
}