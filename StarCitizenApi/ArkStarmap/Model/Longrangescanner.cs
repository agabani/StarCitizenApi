using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model
{
    public class Longrangescanner
    {
        [JsonProperty("radius")]
        public double Radius { get; set; }

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

        [JsonProperty("colorBorder")]
        public string ColorBorder { get; set; }

        [JsonProperty("colorGlow")]
        public string ColorGlow { get; set; }

        [JsonProperty("colorMap")]
        public string ColorMap { get; set; }

        [JsonProperty("alpha")]
        public double Alpha { get; set; }

        [JsonProperty("radiusD")]
        public double RadiusD { get; set; }

        [JsonProperty("widthD")]
        public double WidthD { get; set; }

        [JsonProperty("ratioD")]
        public double RatioD { get; set; }

        [JsonProperty("radiusL")]
        public double RadiusL { get; set; }

        [JsonProperty("widthL")]
        public double WidthL { get; set; }

        [JsonProperty("ratioL")]
        public double RatioL { get; set; }

        [JsonProperty("radiusC")]
        public double RadiusC { get; set; }

        [JsonProperty("widthC")]
        public double WidthC { get; set; }

        [JsonProperty("ratioC")]
        public double RatioC { get; set; }

        [JsonProperty("radiusBorder")]
        public double RadiusBorder { get; set; }

        [JsonProperty("widthBorder")]
        public double WidthBorder { get; set; }

        [JsonProperty("tickCount")]
        public double TickCount { get; set; }

        [JsonProperty("tickLength")]
        public double TickLength { get; set; }

        [JsonProperty("tickWidth")]
        public double TickWidth { get; set; }

        [JsonProperty("glowWidth")]
        public double GlowWidth { get; set; }
    }
}