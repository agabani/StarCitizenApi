using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects
{
    public class Product_Thumb_Medium_And_Small
    {
        [JsonProperty("width")]
        public int width { get; set; }

        [JsonProperty("height")]
        public int height { get; set; }

        [JsonProperty("mode")]
        public string mode { get; set; }
    }
}