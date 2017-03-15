using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects
{
    public class Store_Slideshow_Small_Zoom
    {
        [JsonProperty("width")]
        public int width { get; set; }

        [JsonProperty("height")]
        public int height { get; set; }

        [JsonProperty("mode")]
        public string mode { get; set; }
    }
}