using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.BootUp.ShaderData
{
    public class Starfield
    {
        [JsonProperty("radius")]
        public double Radius { get; set; }

        [JsonProperty("count")]
        public double Count { get; set; }

        [JsonProperty("sizeMin")]
        public double SizeMin { get; set; }

        [JsonProperty("sizeMax")]
        public double SizeMax { get; set; }

        [JsonProperty("color1")]
        public string Color1 { get; set; }

        [JsonProperty("color2")]
        public string Color2 { get; set; }
    }
}