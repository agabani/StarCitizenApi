using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.StarSystem
{
    public class Highlight
    {
        [JsonProperty("color1")]
        public string Color1 { get; set; }

        [JsonProperty("color2")]
        public string Color2 { get; set; }

        [JsonProperty("alpha")]
        public double Alpha { get; set; }

        [JsonProperty("atmosphere1")]
        public double Atmosphere1 { get; set; }

        [JsonProperty("atmosphere2")]
        public double Atmosphere2 { get; set; }

        [JsonProperty("atmosphere3")]
        public double Atmosphere3 { get; set; }

        [JsonProperty("scaleMin")]
        public double ScaleMin { get; set; }

        [JsonProperty("scaleMax")]
        public double ScaleMax { get; set; }

        [JsonProperty("scalePeriod")]
        public double ScalePeriod { get; set; }
    }
}