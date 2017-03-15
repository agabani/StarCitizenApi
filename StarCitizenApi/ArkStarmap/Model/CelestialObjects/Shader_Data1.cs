using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects
{
    public class Shader_Data1
    {
        [JsonProperty("orbitalMin")]
        public double orbitalMin { get; set; }

        [JsonProperty("orbitalMax")]
        public double orbitalMax { get; set; }

        [JsonProperty("orbitalFactor")]
        public double orbitalFactor { get; set; }

        [JsonProperty("highlight")]
        public Highlight1 highlight { get; set; }

        [JsonProperty("radius")]
        public double radius { get; set; }
    }
}