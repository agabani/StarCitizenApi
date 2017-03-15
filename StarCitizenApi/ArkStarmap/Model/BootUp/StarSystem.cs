using System;
using Newtonsoft.Json;
using StarCitizenApi.ArkStarmap.Model.Shared;
using StarCitizenApi.ArkStarmap.Model.Shared.Assests;

namespace StarCitizenApi.ArkStarmap.Model.BootUp
{
    public class StarSystem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("time_modified")]
        public DateTime TimeModified { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("position_x")]
        public string PositionX { get; set; }

        [JsonProperty("position_y")]
        public string PositionY { get; set; }

        [JsonProperty("position_z")]
        public string PositionZ { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("info_url")]
        public object InfoUrl { get; set; }

        [JsonProperty("affiliation")]
        public MemberedAffiliation[] Affiliation { get; set; }

        [JsonProperty("aggregated_size")]
        public string AggregatedSize { get; set; }

        [JsonProperty("aggregated_population")]
        public double AggregatedPopulation { get; set; }

        [JsonProperty("aggregated_economy")]
        public double AggregatedEconomy { get; set; }

        [JsonProperty("aggregated_danger")]
        public double AggregatedDanger { get; set; }

        [JsonProperty("thumbnail")]
        public Thumbnail<object> Thumbnail { get; set; }
    }
}