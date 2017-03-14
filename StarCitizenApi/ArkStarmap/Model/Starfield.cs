using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model
{
    [JsonObject]
    public class Starfield
    {
        [JsonProperty(PropertyName = "radius")]
        public double Radius { get; set; }

        [JsonProperty(PropertyName = "count")]
        public double Count { get; set; }

        [JsonProperty(PropertyName = "sizeMin")]
        public double SizeMin { get; set; }

        [JsonProperty(PropertyName = "sizeMax")]
        public double SizeMax { get; set; }

        [JsonProperty(PropertyName = "color1")]
        public string Color1 { get; set; }

        [JsonProperty(PropertyName = "color2")]
        public string Color2 { get; set; }
    }
}