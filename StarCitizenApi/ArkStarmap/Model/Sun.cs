using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model
{
    public class Sun
    {
        [JsonProperty(PropertyName = "color1")]
        public string Color1 { get; set; }

        [JsonProperty(PropertyName = "color2")]
        public string Color2 { get; set; }

        [JsonProperty(PropertyName = "flare1")]
        public double Flare1 { get; set; }

        [JsonProperty(PropertyName = "flare2")]
        public double Flare2 { get; set; }

        [JsonProperty(PropertyName = "flare3")]
        public double Flare3 { get; set; }

        [JsonProperty(PropertyName = "flare4")]
        public double Flare4 { get; set; }

        [JsonProperty(PropertyName = "flare5")]
        public double Flare5 { get; set; }

        [JsonProperty(PropertyName = "flare6")]
        public double Flare6 { get; set; }

        [JsonProperty(PropertyName = "sphere")]
        public double Sphere { get; set; }

        [JsonProperty(PropertyName = "texture")]
        public double Texture { get; set; }

        [JsonProperty(PropertyName = "corona")]
        public double Corona { get; set; }

        [JsonProperty(PropertyName = "glow")]
        public double Glow { get; set; }

        [JsonProperty(PropertyName = "alpha")]
        public double Alpha { get; set; }

        [JsonProperty(PropertyName = "rotation1")]
        public double Rotation1 { get; set; }

        [JsonProperty(PropertyName = "rotation2")]
        public double Rotation2 { get; set; }

        [JsonProperty(PropertyName = "map")]
        public double Map { get; set; }

        [JsonProperty(PropertyName = "iterations")]
        public double Iterations { get; set; }

        [JsonProperty(PropertyName = "scaleMin")]
        public double ScaleMin { get; set; }

        [JsonProperty(PropertyName = "scaleMax")]
        public double ScaleMax { get; set; }

        [JsonProperty(PropertyName = "scalePeriod")]
        public double ScalePeriod { get; set; }
    }
}