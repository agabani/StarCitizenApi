using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects
{
    public class Store_Slideshow_Small
    {
        [JsonProperty("")]
        public int width { get; set; }

        [JsonProperty("")]
        public int height { get; set; }

        [JsonProperty("")]
        public string mode { get; set; }
    }
}