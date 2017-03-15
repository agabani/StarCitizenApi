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
        public double alpha { get; set; }

        [JsonProperty("atmosphere1")]
        public double atmosphere1 { get; set; }

        [JsonProperty("atmosphere2")]
        public double atmosphere2 { get; set; }

        [JsonProperty("atmosphere3")]
        public double atmosphere3 { get; set; }

        [JsonProperty("scaleMin")]
        public double scaleMin { get; set; }

        [JsonProperty("scaleMax")]
        public double scaleMax { get; set; }

        [JsonProperty("scalePeriod")]
        public double scalePeriod { get; set; }
    }
}