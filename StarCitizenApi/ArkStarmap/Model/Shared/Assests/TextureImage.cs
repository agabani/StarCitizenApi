using System;
using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.Shared.Assests
{
    public class TextureImage
    {
        [JsonProperty("post")]
        public Uri Post { get; set; }

        [JsonProperty("product_thumb_large")]
        public Uri ProductThumbLarge { get; set; }

        [JsonProperty("subscribers_vault_thumbnail")]
        public Uri SubscribersVaultThumbnail { get; set; }
    }
}