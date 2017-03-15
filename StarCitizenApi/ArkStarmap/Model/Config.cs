using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model
{
    public class Config
    {
        [JsonProperty("nearPlane")]
        public double NearPlane { get; set; }

        [JsonProperty("farPlane")]
        public double FarPlane { get; set; }

        [JsonProperty("stars")]
        public Stars Stars { get; set; }

        [JsonProperty("routes")]
        public Route[] Routes { get; set; }

        [JsonProperty("starfield")]
        public Starfield Starfield { get; set; }

        [JsonProperty("longRangeScanner")]
        public Longrangescanner LongRangeScanner { get; set; }
    }
}