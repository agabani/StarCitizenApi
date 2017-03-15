using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects
{
    public class Shader_Data
    {
        [JsonProperty("orbitalMin")]
        public int orbitalMin { get; set; }

        [JsonProperty("orbitalMax")]
        public int orbitalMax { get; set; }

        [JsonProperty("orbitalFactor")]
        public int orbitalFactor { get; set; }

        [JsonProperty("ring")]
        public Ring ring { get; set; }

        [JsonProperty("highlight")]
        public Highlight highlight { get; set; }

        [JsonProperty("orbitalColor")]
        public string orbitalColor { get; set; }

        [JsonProperty("orbitalHighlightColor")]
        public string orbitalHighlightColor { get; set; }
    }
}