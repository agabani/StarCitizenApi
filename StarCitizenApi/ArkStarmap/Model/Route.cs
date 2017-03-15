using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model
{
    public class Route
    {
        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("colorBorder")]
        public string ColorBorder { get; set; }

        [JsonProperty("size")]
        public double Size { get; set; }

        [JsonProperty("density")]
        public double Density { get; set; }

        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("side")]
        public double Side { get; set; }

        [JsonProperty("center")]
        public double Center { get; set; }

        [JsonProperty("pitchEffect")]
        public double PitchEffect { get; set; }

        [JsonProperty("pitchIntensity")]
        public double PitchIntensity { get; set; }

        [JsonProperty("highlightFactor")]
        public double HighlightFactor { get; set; }

        [JsonProperty("depthFactor")]
        public double DepthFactor { get; set; }
    }
}