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
        public DeletableProperties<int?> bug_council_thumbnail { get; set; }

        [JsonProperty("post_section_header")]
        public Post_Section_Header post_section_header { get; set; }

        [JsonProperty("channel_item_full")]
        public Channel_Item_Full channel_item_full { get; set; }

        [JsonProperty("home_transmissions_item_expanded")]
        public Home_Transmissions_Item_Expanded home_transmissions_item_expanded { get; set; }

        [JsonProperty("subscribers_vault_thumbnail")]
        public Subscribers_Vault_Thumbnail subscribers_vault_thumbnail { get; set; }

        [JsonProperty("slideshow")]
        public Slideshow slideshow { get; set; }

        [JsonProperty("slideshow_pager")]
        public Slideshow_Pager slideshow_pager { get; set; }

        [JsonProperty("slideshow_wide")]
        public Slideshow_Wide slideshow_wide { get; set; }

        [JsonProperty("vault_thumb")]
        public Properties<int?> vault_thumb { get; set; }

        [JsonProperty("post")]
        public Properties<int?> post { get; set; }

        [JsonProperty("wallpaper_thumb")]
        public Wallpaper_Thumb wallpaper_thumb { get; set; }

        [JsonProperty("product_thumb_large")]
        public Product_Thumb_Large product_thumb_large { get; set; }

        [JsonProperty("product_thumb_medium_and_small")]
        public Product_Thumb_Medium_And_Small product_thumb_medium_and_small { get; set; }

        [JsonProperty("component_description")]
        public Properties<int?> component_description { get; set; }

        [JsonProperty("product_thumb_in_description")]
        public Product_Thumb_In_Description product_thumb_in_description { get; set; }

        [JsonProperty("product_thumb_shipmod")]
        public Product_Thumb_Shipmod product_thumb_shipmod { get; set; }

        [JsonProperty("press_latest_post")]
        public Press_Latest_Post press_latest_post { get; set; }

        [JsonProperty("store_small")]
        public Store_Small store_small { get; set; }

        [JsonProperty("store_large")]
        public Store_Large store_large { get; set; }

        [JsonProperty("store_hub_small")]
        public Store_Hub_Small store_hub_small { get; set; }

        [JsonProperty("store_hub_large")]
        public Store_Hub_Large store_hub_large { get; set; }

        [JsonProperty("store_slideshow_small")]
        public Store_Slideshow_Small store_slideshow_small { get; set; }

        [JsonProperty("store_slideshow_large")]
        public Store_Slideshow_Large store_slideshow_large { get; set; }

        [JsonProperty("store_slideshow_small_zoom")]
        public Store_Slideshow_Small_Zoom store_slideshow_small_zoom { get; set; }

        [JsonProperty("store_slideshow_large_zoom")]
        public Store_Slideshow_Large_Zoom store_slideshow_large_zoom { get; set; }

        [JsonProperty("store_thumb_listing_small")]
        public Store_Thumb_Listing_Small store_thumb_listing_small { get; set; }

        [JsonProperty("store_thumb_sku_detail")]
        public Store_Thumb_Sku_Detail store_thumb_sku_detail { get; set; }

        [JsonProperty("store_upgrade_half")]
        public Store_Upgrade_Half store_upgrade_half { get; set; }

        [JsonProperty("avatar")]
        public Avatar avatar { get; set; }

        [JsonProperty("banner")]
        public Banner banner { get; set; }

        [JsonProperty("cover")]
        public DeletableProperties<int?> cover { get; set; }

        [JsonProperty("logo")]
        public Logo logo { get; set; }

        [JsonProperty("icon")]
        public Icon icon { get; set; }

        [JsonProperty("background_blur")]
        public Background_Blur background_blur { get; set; }

        [JsonProperty("texture")]
        public Texture1 texture { get; set; }

        [JsonProperty("hub_large")]
        public Properties<string> hub_large { get; set; }

        [JsonProperty("hub_medium")]
        public Hub_Medium hub_medium { get; set; }

        [JsonProperty("hub_small")]
        public Hub_Small hub_small { get; set; }

        [JsonProperty("hub_tile")]
        public Hub_Tile hub_tile { get; set; }
    }
}