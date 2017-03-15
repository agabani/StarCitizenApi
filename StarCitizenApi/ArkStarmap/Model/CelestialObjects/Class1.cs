using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects
{
    public class CeletialObjects
    {
        [JsonProperty("")]
        public int success { get; set; }

        [JsonProperty("")]
        public Data data { get; set; }

        [JsonProperty("")]
        public string code { get; set; }

        [JsonProperty("")]
        public string msg { get; set; }
    }

    public class Data
    {
        [JsonProperty("")]
        public int rowcount { get; set; }

        [JsonProperty("")]
        public string totalrows { get; set; }

        [JsonProperty("")]
        public bool estimatedrows { get; set; }

        [JsonProperty("")]
        public int pagesize { get; set; }

        [JsonProperty("")]
        public object pagecount { get; set; }

        [JsonProperty("")]
        public int page { get; set; }

        [JsonProperty("")]
        public int offset { get; set; }

        [JsonProperty("")]
        public int startrow { get; set; }

        [JsonProperty("")]
        public Resultset[] resultset { get; set; }
    }

    public class Resultset
    {
        [JsonProperty("")]
        public string id { get; set; }

        [JsonProperty("")]
        public string time_modified { get; set; }

        [JsonProperty("")]
        public string type { get; set; }

        [JsonProperty("")]
        public string designation { get; set; }

        [JsonProperty("")]
        public string name { get; set; }

        [JsonProperty("")]
        public string code { get; set; }

        [JsonProperty("")]
        public string age { get; set; }

        [JsonProperty("")]
        public string distance { get; set; }

        [JsonProperty("")]
        public string latitude { get; set; }

        [JsonProperty("")]
        public string longitude { get; set; }

        [JsonProperty("")]
        public string axial_tilt { get; set; }

        [JsonProperty("")]
        public string orbit_period { get; set; }

        [JsonProperty("")]
        public string description { get; set; }

        [JsonProperty("")]
        public object info_url { get; set; }

        [JsonProperty("")]
        public object habitable { get; set; }

        [JsonProperty("")]
        public object fairchanceact { get; set; }

        [JsonProperty("")]
        public string show_orbitlines { get; set; }

        [JsonProperty("")]
        public string show_label { get; set; }

        [JsonProperty("")]
        public string appearance { get; set; }

        [JsonProperty("")]
        public string sensor_population { get; set; }

        [JsonProperty("")]
        public string sensor_economy { get; set; }

        [JsonProperty("")]
        public string sensor_danger { get; set; }

        [JsonProperty("")]
        public Shader_Data shader_data { get; set; }

        [JsonProperty("")]
        public string size { get; set; }

        [JsonProperty("")]
        public string subtype_id { get; set; }

        [JsonProperty("")]
        public string parent_id { get; set; }

        [JsonProperty("")]
        public Subtype subtype { get; set; }

        [JsonProperty("")]
        public Affiliation[] affiliation { get; set; }

        [JsonProperty("")]
        public object[] population { get; set; }

        [JsonProperty("")]
        public Child[] children { get; set; }

        [JsonProperty("")]
        public Texture texture { get; set; }
    }

    public class Shader_Data
    {
        [JsonProperty("")]
        public int orbitalMin { get; set; }

        [JsonProperty("")]
        public int orbitalMax { get; set; }

        [JsonProperty("")]
        public int orbitalFactor { get; set; }

        [JsonProperty("")]
        public Ring ring { get; set; }

        [JsonProperty("")]
        public Highlight highlight { get; set; }

        [JsonProperty("")]
        public string orbitalColor { get; set; }

        [JsonProperty("")]
        public string orbitalHighlightColor { get; set; }
    }

    public class Ring
    {
        [JsonProperty("")]
        public string color1 { get; set; }

        [JsonProperty("")]
        public string color2 { get; set; }

        [JsonProperty("")]
        public float radius1 { get; set; }

        [JsonProperty("")]
        public int radius2 { get; set; }
    }

    public class Highlight
    {
        [JsonProperty("")]
        public string color1 { get; set; }

        [JsonProperty("")]
        public string color2 { get; set; }

        [JsonProperty("")]
        public int alpha { get; set; }

        [JsonProperty("")]
        public float atmosphere1 { get; set; }

        [JsonProperty("")]
        public float atmosphere2 { get; set; }

        [JsonProperty("")]
        public float atmosphere3 { get; set; }

        [JsonProperty("")]
        public int scaleMin { get; set; }

        [JsonProperty("")]
        public int scaleMax { get; set; }

        [JsonProperty("")]
        public int scalePeriod { get; set; }
    }

    public class Subtype
    {
        [JsonProperty("")]
        public string id { get; set; }

        [JsonProperty("")]
        public string name { get; set; }

        [JsonProperty("")]
        public string type { get; set; }
    }

    public class Texture
    {
        [JsonProperty("")]
        public string slug { get; set; }

        [JsonProperty("")]
        public string source { get; set; }

        [JsonProperty("")]
        public Images images { get; set; }
    }

    public class Images
    {
        [JsonProperty("")]
        public string post { get; set; }

        [JsonProperty("")]
        public string product_thumb_large { get; set; }

        [JsonProperty("")]
        public string subscribers_vault_thumbnail { get; set; }
    }

    public class Affiliation
    {
        [JsonProperty("")]
        public string id { get; set; }

        [JsonProperty("")]
        public string name { get; set; }

        [JsonProperty("")]
        public string code { get; set; }

        [JsonProperty("")]
        public string color { get; set; }

        [JsonProperty("")]
        public string membershipid { get; set; }
    }

    public class Child
    {
        [JsonProperty("")]
        public string id { get; set; }

        [JsonProperty("")]
        public string time_modified { get; set; }

        [JsonProperty("")]
        public string type { get; set; }

        [JsonProperty("")]
        public string designation { get; set; }

        [JsonProperty("")]
        public string name { get; set; }

        [JsonProperty("")]
        public string code { get; set; }

        [JsonProperty("")]
        public string age { get; set; }

        [JsonProperty("")]
        public string distance { get; set; }

        [JsonProperty("")]
        public string latitude { get; set; }

        [JsonProperty("")]
        public string longitude { get; set; }

        [JsonProperty("")]
        public string axial_tilt { get; set; }

        [JsonProperty("")]
        public string orbit_period { get; set; }

        [JsonProperty("")]
        public string description { get; set; }

        [JsonProperty("")]
        public object info_url { get; set; }

        [JsonProperty("")]
        public object habitable { get; set; }

        [JsonProperty("")]
        public object fairchanceact { get; set; }

        [JsonProperty("")]
        public string show_orbitlines { get; set; }

        [JsonProperty("")]
        public string show_label { get; set; }

        [JsonProperty("")]
        public string appearance { get; set; }

        [JsonProperty("")]
        public string sensor_population { get; set; }

        [JsonProperty("")]
        public string sensor_economy { get; set; }

        [JsonProperty("")]
        public string sensor_danger { get; set; }

        [JsonProperty("")]
        public Shader_Data1 shader_data { get; set; }

        [JsonProperty("")]
        public string size { get; set; }

        [JsonProperty("")]
        public string subtype_id { get; set; }

        [JsonProperty("")]
        public string parent_id { get; set; }

        [JsonProperty("")]
        public Subtype1 subtype { get; set; }

        [JsonProperty("")]
        public object[] affiliation { get; set; }

        [JsonProperty("")]
        public object[] population { get; set; }

        [JsonProperty("")]
        public Medium[] media { get; set; }
    }

    public class Shader_Data1
    {
        [JsonProperty("")]
        public int orbitalMin { get; set; }

        [JsonProperty("")]
        public int orbitalMax { get; set; }

        [JsonProperty("")]
        public int orbitalFactor { get; set; }

        [JsonProperty("")]
        public Highlight1 highlight { get; set; }

        [JsonProperty("")]
        public float radius { get; set; }
    }

    public class Highlight1
    {
        [JsonProperty("")]
        public string color1 { get; set; }

        [JsonProperty("")]
        public string color2 { get; set; }

        [JsonProperty("")]
        public int alpha { get; set; }

        [JsonProperty("")]
        public float atmosphere1 { get; set; }

        [JsonProperty("")]
        public float atmosphere2 { get; set; }

        [JsonProperty("")]
        public float atmosphere3 { get; set; }

        [JsonProperty("")]
        public float scaleMin { get; set; }

        [JsonProperty("")]
        public int scaleMax { get; set; }

        [JsonProperty("")]
        public int scalePeriod { get; set; }
    }

    public class Subtype1
    {
        [JsonProperty("")]
        public string id { get; set; }

        [JsonProperty("")]
        public string name { get; set; }

        [JsonProperty("")]
        public string type { get; set; }
    }

    public class Medium
    {
        [JsonProperty("")]
        public string id { get; set; }

        [JsonProperty("")]
        public string slug { get; set; }

        [JsonProperty("")]
        public string status { get; set; }

        [JsonProperty("")]
        public string time_modified { get; set; }

        [JsonProperty("")]
        public object publish_start { get; set; }

        [JsonProperty("")]
        public object publish_end { get; set; }

        [JsonProperty("")]
        public string type { get; set; }

        [JsonProperty("")]
        public string tag_string { get; set; }

        [JsonProperty("")]
        public string purpose { get; set; }

        [JsonProperty("")]
        public string depot { get; set; }

        [JsonProperty("")]
        public string depot_status { get; set; }

        [JsonProperty("")]
        public object distant_id { get; set; }

        [JsonProperty("")]
        public object distant_source { get; set; }

        [JsonProperty("")]
        public string source_name { get; set; }

        [JsonProperty("")]
        public string source_extension { get; set; }

        [JsonProperty("")]
        public object source_duration { get; set; }

        [JsonProperty("")]
        public Derived_Data derived_data { get; set; }

        [JsonProperty("")]
        public object cover_data { get; set; }

        [JsonProperty("")]
        public string source_url { get; set; }

        [JsonProperty("")]
        public Source_Stream source_stream { get; set; }

        [JsonProperty("")]
        public Images1 images { get; set; }

        [JsonProperty("")]
        public string membershipid { get; set; }

        [JsonProperty("")]
        public string membershipslot { get; set; }
    }

    public class Derived_Data
    {
        [JsonProperty("")]
        public Sizes sizes { get; set; }
    }

    public class Sizes
    {
        [JsonProperty("")]
        public Heap_Note heap_note { get; set; }

        [JsonProperty("")]
        public Heap_Thumb heap_thumb { get; set; }

        [JsonProperty("")]
        public Heap_Infobox heap_infobox { get; set; }

        [JsonProperty("")]
        public Bug_Council_Thumbnail bug_council_thumbnail { get; set; }

        [JsonProperty("")]
        public Post_Section_Header post_section_header { get; set; }

        [JsonProperty("")]
        public Channel_Item_Full channel_item_full { get; set; }

        [JsonProperty("")]
        public Home_Transmissions_Item_Expanded home_transmissions_item_expanded { get; set; }

        [JsonProperty("")]
        public Subscribers_Vault_Thumbnail subscribers_vault_thumbnail { get; set; }

        [JsonProperty("")]
        public Slideshow slideshow { get; set; }

        [JsonProperty("")]
        public Slideshow_Pager slideshow_pager { get; set; }

        [JsonProperty("")]
        public Slideshow_Wide slideshow_wide { get; set; }

        [JsonProperty("")]
        public Vault_Thumb vault_thumb { get; set; }

        [JsonProperty("")]
        public Post post { get; set; }

        [JsonProperty("")]
        public Wallpaper_Thumb wallpaper_thumb { get; set; }

        [JsonProperty("")]
        public Product_Thumb_Large product_thumb_large { get; set; }

        [JsonProperty("")]
        public Product_Thumb_Medium_And_Small product_thumb_medium_and_small { get; set; }

        [JsonProperty("")]
        public Component_Description component_description { get; set; }

        [JsonProperty("")]
        public Product_Thumb_In_Description product_thumb_in_description { get; set; }

        [JsonProperty("")]
        public Product_Thumb_Shipmod product_thumb_shipmod { get; set; }

        [JsonProperty("")]
        public Press_Latest_Post press_latest_post { get; set; }

        [JsonProperty("")]
        public Store_Small store_small { get; set; }

        [JsonProperty("")]
        public Store_Large store_large { get; set; }

        [JsonProperty("")]
        public Store_Hub_Small store_hub_small { get; set; }

        [JsonProperty("")]
        public Store_Hub_Large store_hub_large { get; set; }

        [JsonProperty("")]
        public Store_Slideshow_Small store_slideshow_small { get; set; }

        [JsonProperty("")]
        public Store_Slideshow_Large store_slideshow_large { get; set; }

        [JsonProperty("")]
        public Store_Slideshow_Small_Zoom store_slideshow_small_zoom { get; set; }

        [JsonProperty("")]
        public Store_Slideshow_Large_Zoom store_slideshow_large_zoom { get; set; }

        [JsonProperty("")]
        public Store_Thumb_Listing_Small store_thumb_listing_small { get; set; }

        [JsonProperty("")]
        public Store_Thumb_Sku_Detail store_thumb_sku_detail { get; set; }

        [JsonProperty("")]
        public Store_Upgrade_Half store_upgrade_half { get; set; }

        [JsonProperty("")]
        public Avatar avatar { get; set; }

        [JsonProperty("")]
        public Banner banner { get; set; }

        [JsonProperty("")]
        public Cover cover { get; set; }

        [JsonProperty("")]
        public Logo logo { get; set; }

        [JsonProperty("")]
        public Icon icon { get; set; }

        [JsonProperty("")]
        public Background_Blur background_blur { get; set; }

        [JsonProperty("")]
        public Texture1 texture { get; set; }

        [JsonProperty("")]
        public Hub_Large hub_large { get; set; }

        [JsonProperty("")]
        public Hub_Medium hub_medium { get; set; }

        [JsonProperty("")]
        public Hub_Small hub_small { get; set; }

        [JsonProperty("")]
        public Hub_Tile hub_tile { get; set; }
    }

    public class Heap_Note
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }

        [JsonProperty("")]
        public string delete { get; set; }
    }

    public class Heap_Thumb
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }

        [JsonProperty("")]
        public string delete { get; set; }
    }

    public class Heap_Infobox
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }

        [JsonProperty("")]
        public string delete { get; set; }
    }

    public class Bug_Council_Thumbnail
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }

        [JsonProperty("")]
        public string delete { get; set; }
    }

    public class Post_Section_Header
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }
    }

    public class Channel_Item_Full
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }
    }

    public class Home_Transmissions_Item_Expanded
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }
    }

    public class Subscribers_Vault_Thumbnail
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }
    }

    public class Slideshow
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }
    }

    public class Slideshow_Pager
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }
    }

    public class Slideshow_Wide
    {
        public int width { get; set; }
        public int height { get; set; }
        public string mode { get; set; }
    }

    public class Vault_Thumb
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public object height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }
    }

    public class Post
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public object height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }
    }

    public class Wallpaper_Thumb
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }
    }

    public class Product_Thumb_Large
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }
    }

    public class Product_Thumb_Medium_And_Small
    {
        public int width { get; set; }
        public int height { get; set; }
        public string mode { get; set; }
    }

    public class Component_Description
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public object height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }
    }

    public class Product_Thumb_In_Description
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }
    }

    public class Product_Thumb_Shipmod
    {
        public int width { get; set; }
        public int height { get; set; }
        public string mode { get; set; }
    }

    public class Press_Latest_Post
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }
    }

    public class Store_Small
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }
    }

    public class Store_Large
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }
    }

    public class Store_Hub_Small
    {
        public int width { get; set; }
        public int height { get; set; }
        public string mode { get; set; }
    }

    public class Store_Hub_Large
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }
    }

    public class Store_Slideshow_Small
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }
    }

    public class Store_Slideshow_Large
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }
    }

    public class Store_Slideshow_Small_Zoom
    {
        public int width { get; set; }
        public int height { get; set; }
        public string mode { get; set; }
    }

    public class Store_Slideshow_Large_Zoom
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }
    }

    public class Store_Thumb_Listing_Small
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }
    }

    public class Store_Thumb_Sku_Detail
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }
    }

    public class Store_Upgrade_Half
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }
    }

    public class Avatar
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }

        [JsonProperty("")]
        public string delete { get; set; }
    }

    public class Banner
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }

        [JsonProperty("")]
        public string delete { get; set; }
    }

    public class Cover
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public string height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }

        [JsonProperty("")]
        public string delete { get; set; }
    }

    public class Logo
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }

        [JsonProperty("")]
        public string delete { get; set; }
    }

    public class Icon
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }

        [JsonProperty("")]
        public string delete { get; set; }
    }

    public class Background_Blur
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }

        [JsonProperty("")]
        public string delete { get; set; }
    }

    public class Texture1
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }
    }

    public class Hub_Large
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public string height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }
    }

    public class Hub_Medium
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }

        [JsonProperty("")]
        public string delete { get; set; }
    }

    public class Hub_Small
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }

        [JsonProperty("")]
        public string delete { get; set; }
    }

    public class Hub_Tile
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }

        [JsonProperty("")]
        public string delete { get; set; }
    }

    public class Source_Stream
    {
        [JsonProperty("")]
        public string progressive { get; set; }
    }

    public class Images1
    {
        [JsonProperty("")]
        public string heap_note { get; set; }

        [JsonProperty("")]
        public string heap_thumb { get; set; }

        [JsonProperty("")]
        public string heap_infobox { get; set; }

        [JsonProperty("")]
        public string bug_council_thumbnail { get; set; }

        [JsonProperty("")]
        public string tavern_upload_square { get; set; }

        [JsonProperty("")]
        public string tavern_upload_small { get; set; }

        [JsonProperty("")]
        public string tavern_upload_medium { get; set; }

        [JsonProperty("")]
        public string tavern_upload_large { get; set; }

        [JsonProperty("")]
        public string post_section_header { get; set; }

        [JsonProperty("")]
        public string channel_item_full { get; set; }

        [JsonProperty("")]
        public string home_transmissions_item_expanded { get; set; }

        [JsonProperty("")]
        public string subscribers_vault_thumbnail { get; set; }

        [JsonProperty("")]
        public string slideshow { get; set; }

        [JsonProperty("")]
        public string slideshow_pager { get; set; }

        [JsonProperty("")]
        public string slideshow_wide { get; set; }

        [JsonProperty("")]
        public string vault_thumb { get; set; }

        [JsonProperty("")]
        public string post { get; set; }

        [JsonProperty("")]
        public string wallpaper_thumb { get; set; }

        [JsonProperty("")]
        public string product_thumb_large { get; set; }

        [JsonProperty("")]
        public string product_thumb_medium_and_small { get; set; }

        [JsonProperty("")]
        public string component_description { get; set; }

        [JsonProperty("")]
        public string product_thumb_in_description { get; set; }

        [JsonProperty("")]
        public string product_thumb_shipmod { get; set; }

        [JsonProperty("")]
        public string press_latest_post { get; set; }

        [JsonProperty("")]
        public string store_small { get; set; }

        [JsonProperty("")]
        public string store_large { get; set; }

        [JsonProperty("")]
        public string store_hub_small { get; set; }

        [JsonProperty("")]
        public string store_hub_large { get; set; }

        [JsonProperty("")]
        public string store_slideshow_small { get; set; }

        [JsonProperty("")]
        public string store_slideshow_large { get; set; }

        [JsonProperty("")]
        public string store_slideshow_small_zoom { get; set; }

        [JsonProperty("")]
        public string store_slideshow_large_zoom { get; set; }

        [JsonProperty("")]
        public string store_thumb_listing_small { get; set; }

        [JsonProperty("")]
        public string store_thumb_sku_detail { get; set; }

        [JsonProperty("")]
        public string store_upgrade_half { get; set; }

        [JsonProperty("")]
        public string avatar { get; set; }

        [JsonProperty("")]
        public string banner { get; set; }

        [JsonProperty("")]
        public string cover { get; set; }

        [JsonProperty("")]
        public string logo { get; set; }

        [JsonProperty("")]
        public string icon { get; set; }

        [JsonProperty("")]
        public string background_blur { get; set; }

        [JsonProperty("")]
        public string texture { get; set; }

        [JsonProperty("")]
        public string hub_large { get; set; }

        [JsonProperty("")]
        public string hub_medium { get; set; }

        [JsonProperty("")]
        public string hub_small { get; set; }

        [JsonProperty("")]
        public string hub_tile { get; set; }
    }
}

// https://robertsspaceindustries.com/api/starmap/celestial-objects/SOL.PLANETS.JUPITER