using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.Shared.ShaderData
{
    public class SystemBlackhole
    {
        [JsonProperty("color1")]
        public string Color1 { get; set; }

        [JsonProperty("color2")]
        public string Color2 { get; set; }

        [JsonProperty("turbulence1")]
        public double Turbulence1 { get; set; }

        [JsonProperty("turbulence2")]
        public double Turbulence2 { get; set; }

        [JsonProperty("turbulence3")]
        public double Turbulence3 { get; set; }

        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("pitch")]
        public double Pitch { get; set; }

        [JsonProperty("yaw")]
        public double Yaw { get; set; }

        [JsonProperty("roll")]
        public double Roll { get; set; }

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