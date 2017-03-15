using System;
using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects.Assets
{
    public class Media
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("time_modified")]
        public DateTime TimeModified { get; set; }

        [JsonProperty("publish_start")]
        public object PublishStart { get; set; }

        [JsonProperty("publish_end")]
        public object PublishEnd { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("tag_string")]
        public string TagString { get; set; }

        [JsonProperty("purpose")]
        public string Purpose { get; set; }

        [JsonProperty("depot")]
        public string Depot { get; set; }

        [JsonProperty("depot_status")]
        public string DepotStatus { get; set; }

        [JsonProperty("distant_id")]
        public object DistantId { get; set; }

        [JsonProperty("distant_source")]
        public object DistantSource { get; set; }

        [JsonProperty("source_name")]
        public string SourceName { get; set; }

        [JsonProperty("source_extension")]
        public string SourceExtension { get; set; }

        [JsonProperty("source_duration")]
        public object SourceDuration { get; set; }

        [JsonProperty("derived_data")]
        public DerivedData DerivedData { get; set; }

        [JsonProperty("cover_data")]
        public object CoverData { get; set; }

        [JsonProperty("source_url")]
        public string SourceUrl { get; set; }

        [JsonProperty("source_stream")]
        public Source_Stream SourceStream { get; set; }

        [JsonProperty("")]
        public Images1 Images { get; set; }

        [JsonProperty("membership.id")]
        public string MembershipId { get; set; }

        [JsonProperty("membership.slot")]
        public string MembershipSlot { get; set; }
    }
}