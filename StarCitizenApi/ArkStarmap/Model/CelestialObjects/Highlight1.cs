using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects
{
    public class Highlight1
    {
        [JsonProperty("color1")]
        public string color1 { get; set; }

        [JsonProperty("color2")]
        public string color2 { get; set; }

        [JsonProperty("alpha")]
        public int alpha { get; set; }

        [JsonProperty("atmosphere1")]
        public float atmosphere1 { get; set; }

        [JsonProperty("atmosphere2")]
        public float atmosphere2 { get; set; }

        [JsonProperty("atmosphere3")]
        public float atmosphere3 { get; set; }

        [JsonProperty("scaleMin")]
        public float scaleMin { get; set; }

        [JsonProperty("scaleMax")]
        public int scaleMax { get; set; }

        [JsonProperty("scalePeriod")]
        public int scalePeriod { get; set; }
    }
}