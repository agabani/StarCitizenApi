using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.FindRoute
{
    public class Route
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("first_jump")]
        public string FirstJump { get; set; }

        [JsonProperty("flight_distance")]
        public float FlightDistance { get; set; }

        [JsonProperty("jumps")]
        public int Jumps { get; set; }

        [JsonProperty("segments")]
        public Segment[] Segments { get; set; }
    }
}