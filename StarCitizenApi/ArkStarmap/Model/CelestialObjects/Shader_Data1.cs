using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects
{
    public class Shader_Data1
    {
        [JsonProperty("orbitalMin")]
        public int orbitalMin { get; set; }

        [JsonProperty("orbitalMax")]
        public int orbitalMax { get; set; }

        [JsonProperty("orbitalFactor")]
        public int orbitalFactor { get; set; }

        [JsonProperty("highlight")]
        public Highlight1 highlight { get; set; }

        [JsonProperty("radius")]
        public float radius { get; set; }
    }
}