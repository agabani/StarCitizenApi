using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects.Assets
{
    public class Sizes
    {
        [JsonProperty("heap_note")]
        public DeletableProperties<int?> HeapNote { get; set; }

        [JsonProperty("heap_thumb")]
        public DeletableProperties<int?> HeapThumb { get; set; }

        [JsonProperty("heap_infobox")]
        public DeletableProperties<int?> HeapInfobox { get; set; }

        [JsonProperty("bug_council_thumbnail")]
        public DeletableProperties<int?> BugCouncilThumbnail { get; set; }

        [JsonProperty("post_section_header")]
        public Properties<int?> PostSectionHeader { get; set; }

        [JsonProperty("channel_item_full")]
        public Properties<int?> ChannelItemFull { get; set; }

        [JsonProperty("home_transmissions_item_expanded")]
        public Properties<int?> HomeTransmissionsItemExpanded { get; set; }

        [JsonProperty("subscribers_vault_thumbnail")]
        public Properties<int?> SubscribersVaultThumbnail { get; set; }

        [JsonProperty("slideshow")]
        public Properties<int?> Slideshow { get; set; }

        [JsonProperty("slideshow_pager")]
        public Properties<int?> SlideshowPager { get; set; }

        [JsonProperty("slideshow_wide")]
        public Properties<int?> SlideshowWide { get; set; }

        [JsonProperty("vault_thumb")]
        public Properties<int?> VaultThumb { get; set; }

        [JsonProperty("post")]
        public Properties<int?> Post { get; set; }

        [JsonProperty("wallpaper_thumb")]
        public Properties<int?> WallpaperThumb { get; set; }

        [JsonProperty("product_thumb_large")]
        public Properties<int?> ProductThumbLarge { get; set; }

        [JsonProperty("product_thumb_medium_and_small")]
        public Properties<int?> ProductThumbMediumAndSmall { get; set; }

        [JsonProperty("component_description")]
        public Properties<int?> ComponentDescription { get; set; }

        [JsonProperty("product_thumb_in_description")]
        public Properties<int?> ProductThumbInDescription { get; set; }

        [JsonProperty("product_thumb_shipmod")]
        public Properties<int?> ProductThumbShipmod { get; set; }

        [JsonProperty("press_latest_post")]
        public Properties<int?> PressLatestPost { get; set; }

        [JsonProperty("store_small")]
        public Properties<int?> StoreSmall { get; set; }

        [JsonProperty("store_large")]
        public Properties<int?> StoreLarge { get; set; }

        [JsonProperty("store_hub_small")]
        public Properties<int?> StoreHubSmall { get; set; }

        [JsonProperty("store_hub_large")]
        public Properties<int?> StoreHubLarge { get; set; }

        [JsonProperty("store_slideshow_small")]
        public Properties<int?> StoreSlideshowSmall { get; set; }

        [JsonProperty("store_slideshow_large")]
        public Properties<int?> StoreSlideshowLarge { get; set; }

        [JsonProperty("store_slideshow_small_zoom")]
        public Properties<int?> StoreSlideshowSmallZoom { get; set; }

        [JsonProperty("store_slideshow_large_zoom")]
        public Properties<int?> StoreSlideshowLargeZoom { get; set; }

        [JsonProperty("store_thumb_listing_small")]
        public Properties<int?> StoreThumbListingSmall { get; set; }

        [JsonProperty("store_thumb_sku_detail")]
        public Properties<int?> StoreThumbSkuDetail { get; set; }

        [JsonProperty("store_upgrade_half")]
        public Properties<int?> StoreUpgradeHalf { get; set; }

        [JsonProperty("avatar")]
        public DeletableProperties<int?> Avatar { get; set; }

        [JsonProperty("banner")]
        public DeletableProperties<int?> Banner { get; set; }

        [JsonProperty("cover")]
        public DeletableProperties<int?> Cover { get; set; }

        [JsonProperty("logo")]
        public DeletableProperties<int?> Logo { get; set; }

        [JsonProperty("icon")]
        public DeletableProperties<int?> Icon { get; set; }

        [JsonProperty("background_blur")]
        public DeletableProperties<int?> BackgroundBlur { get; set; }

        [JsonProperty("texture")]
        public Properties<int?> Texture { get; set; }

        [JsonProperty("hub_large")]
        public Properties<string> HubLarge { get; set; }

        [JsonProperty("hub_medium")]
        public DeletableProperties<int?> HubMedium { get; set; }

        [JsonProperty("hub_small")]
        public DeletableProperties<int?> HubSmall { get; set; }

        [JsonProperty("hub_tile")]
        public DeletableProperties<int?> HubTile { get; set; }
    }
}