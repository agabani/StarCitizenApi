using System;
using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model
{
    [JsonObject]
    public class System
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "time_modified")]
        public DateTime TimeModified { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "position_x")]
        public string PositionX { get; set; }

        [JsonProperty(PropertyName = "position_y")]
        public string PositionY { get; set; }

        [JsonProperty(PropertyName = "position_z")]
        public string PositionZ { get; set; }

        [JsonProperty(PropertyName = "info_url")]
        public Uri InfoUrl { get; set; }

        [JsonProperty(PropertyName = "habitable_zone_inner")]
        public string HabitableZoneInner { get; set; }

        [JsonProperty(PropertyName = "habitable_zone_outer")]
        public string HabitableZoneOuter { get; set; }

        [JsonProperty(PropertyName = "frost_line")]
        public string FrostLine { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "shader_data")]
        public ShaderData ShaderData { get; set; }

        [JsonProperty(PropertyName = "affiliation")]
        public Affiliation[] Affiliation { get; set; }

        [JsonProperty(PropertyName = "celestial_objects")]
        public CelestialObjects[] CelestialObjects { get; set; }

        [JsonProperty(PropertyName = "aggregated_size")]
        public string AggregatedSize { get; set; }

        [JsonProperty(PropertyName = "aggregated_population")]
        public double AggregatedPopulation { get; set; }

        [JsonProperty(PropertyName = "aggregated_economy")]
        public double AggregatedEconomy { get; set; }

        [JsonProperty(PropertyName = "aggregated_danger")]
        public double AggregatedDanger { get; set; }
    }
}