using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects
{
    public class Properties<THeight>
    {
        [JsonProperty("width")]
        public int? width { get; set; }

        [JsonProperty("height")]
        public THeight height { get; set; }

        [JsonProperty("mode")]
        public string mode { get; set; }

    }
}