using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects
{
    public class Background_Blur
    {
        [JsonProperty("width")]
        public int width { get; set; }

        [JsonProperty("height")]
        public int height { get; set; }

        [JsonProperty("mode")]
        public string mode { get; set; }

        [JsonProperty("delete")]
        public string delete { get; set; }
    }
}