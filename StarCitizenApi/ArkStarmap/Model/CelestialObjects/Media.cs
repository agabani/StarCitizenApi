using System;
using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects
{
    public class Media
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("slug")]
        public string slug { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("time_modified")]
        public DateTime time_modified { get; set; }

        [JsonProperty("publish_start")]
        public object publish_start { get; set; }

        [JsonProperty("publish_end")]
        public object publish_end { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("tag_string")]
        public string tag_string { get; set; }

        [JsonProperty("purpose")]
        public string purpose { get; set; }

        [JsonProperty("depot")]
        public string depot { get; set; }

        [JsonProperty("depot_status")]
        public string depot_status { get; set; }

        [JsonProperty("distant_id")]
        public object distant_id { get; set; }

        [JsonProperty("distant_source")]
        public object distant_source { get; set; }

        [JsonProperty("source_name")]
        public string source_name { get; set; }

        [JsonProperty("source_extension")]
        public string source_extension { get; set; }

        [JsonProperty("source_duration")]
        public object source_duration { get; set; }

        [JsonProperty("derived_data")]
        public Derived_Data derived_data { get; set; }

        [JsonProperty("cover_data")]
        public object cover_data { get; set; }

        [JsonProperty("source_url")]
        public string source_url { get; set; }

        [JsonProperty("source_stream")]
        public Source_Stream source_stream { get; set; }

        [JsonProperty("")]
        public Images1 images { get; set; }

        [JsonProperty("membership.id")]
        public string membershipId { get; set; }

        [JsonProperty("membership.slot")]
        public string membershipSlot { get; set; }
    }
}