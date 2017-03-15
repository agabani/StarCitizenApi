using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects.Assets
{
    public class SourceStream
    {
        [JsonProperty("progressive")]
        public string Progressive { get; set; }
    }
}