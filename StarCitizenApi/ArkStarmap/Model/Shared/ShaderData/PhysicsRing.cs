using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.Shared.ShaderData
{
    public class PhysicsRing : Ring
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("extraDensity")]
        public double ExtraDensity { get; set; }

        [JsonProperty("borderFading")]
        public double BorderFading { get; set; }
    }
}