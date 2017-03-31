using Newtonsoft.Json;
using StarCitizenApi.ArkStarmap.Model.Shared;

namespace StarCitizenApi.ArkStarmap.Model.FindRoute
{
    public class Segment : Identity
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("system_id")]
        public string SystemId { get; set; }

        [JsonProperty("system_code")]
        public string SystemCode { get; set; }

        [JsonProperty("object_id")]
        public string ObjectId { get; set; }

        [JsonProperty("object_code")]
        public string ObjectCode { get; set; }

        [JsonProperty("segment_type")]
        public string SegmentType { get; set; }

        [JsonProperty("segment_distance")]
        public double? SegmentDistance { get; set; }

        [JsonProperty("is_departure")]
        public object IsDeparture { get; set; }

        [JsonProperty("is_destination")]
        public object IsDestination { get; set; }
    }
}