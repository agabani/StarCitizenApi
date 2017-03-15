using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model
{
    public class Stars
    {
        [JsonProperty("useStarFading")]
        public bool UseStarFading { get; set; }

        [JsonProperty("fadeStart")]
        public double FadeStart { get; set; }

        [JsonProperty("pitchEffect")]
        public double PitchEffect { get; set; }

        [JsonProperty("pitchIntensity")]
        public double PitchIntensity { get; set; }

        [JsonProperty("radiusFactor")]
        public double RadiusFactor { get; set; }

        [JsonProperty("maxRadius")]
        public double MaxRadius { get; set; }

        [JsonProperty("colorD1")]
        public string ColorD1 { get; set; }

        [JsonProperty("colorD2")]
        public string ColorD2 { get; set; }

        [JsonProperty("colorL1")]
        public string ColorL1 { get; set; }

        [JsonProperty("colorL2")]
        public string ColorL2 { get; set; }

        [JsonProperty("colorC1")]
        public string ColorC1 { get; set; }

        [JsonProperty("colorC2")]
        public string ColorC2 { get; set; }
    }
}