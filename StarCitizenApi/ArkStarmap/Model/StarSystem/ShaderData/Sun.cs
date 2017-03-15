using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.StarSystem.ShaderData
{
    public class Sun
    {
        [JsonProperty("color1")]
        public string Color1 { get; set; }

        [JsonProperty("color2")]
        public string Color2 { get; set; }

        [JsonProperty("flare1")]
        public double Flare1 { get; set; }

        [JsonProperty("flare2")]
        public double Flare2 { get; set; }

        [JsonProperty("flare3")]
        public double Flare3 { get; set; }

        [JsonProperty("flare4")]
        public double Flare4 { get; set; }

        [JsonProperty("flare5")]
        public double Flare5 { get; set; }

        [JsonProperty("flare6")]
        public double Flare6 { get; set; }

        [JsonProperty("sphere")]
        public double Sphere { get; set; }

        [JsonProperty("texture")]
        public double Texture { get; set; }

        [JsonProperty("corona")]
        public double Corona { get; set; }

        [JsonProperty("glow")]
        public double Glow { get; set; }

        [JsonProperty("alpha")]
        public double Alpha { get; set; }

        [JsonProperty("rotation1")]
        public double Rotation1 { get; set; }

        [JsonProperty("rotation2")]
        public double Rotation2 { get; set; }

        [JsonProperty("map")]
        public double Map { get; set; }

        [JsonProperty("iterations")]
        public double Iterations { get; set; }

        [JsonProperty("scaleMin")]
        public double ScaleMin { get; set; }

        [JsonProperty("scaleMax")]
        public double ScaleMax { get; set; }

        [JsonProperty("scalePeriod")]
        public double ScalePeriod { get; set; }
    }
}