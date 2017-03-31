using Newtonsoft.Json;
using StarCitizenApi.ArkStarmap.Model.BootUp.ShaderData;
using StarCitizenApi.ArkStarmap.Model.Shared.ShaderData;

namespace StarCitizenApi.ArkStarmap.Model.BootUp
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
        public LongRangeScanner LongRangeScanner { get; set; }
    }
}