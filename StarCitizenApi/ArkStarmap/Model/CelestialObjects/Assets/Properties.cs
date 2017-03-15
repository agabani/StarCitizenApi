using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects.Assets
{
    public class Properties<THeight>
    {
        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("height")]
        public THeight Height { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }
    }
}