using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects
{
    public class Source_Stream
    {
        [JsonProperty("progressive")]
        public string progressive { get; set; }
    }
}