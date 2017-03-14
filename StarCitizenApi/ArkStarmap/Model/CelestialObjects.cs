using System;
using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model
{
    [JsonObject]
    public class CelestialObjects
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "time_modified")]
        public DateTime TimeModified { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "designation")]
        public string Designation { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "age")]
        public string Age { get; set; }

        [JsonProperty(PropertyName = "distance")]
        public string Distance { get; set; }

        [JsonProperty(PropertyName = "latitude")]
        public string Latitude { get; set; }

        [JsonProperty(PropertyName = "longitude")]
        public string Longitude { get; set; }

        [JsonProperty(PropertyName = "axial_tilt")]
        public string AxialTilt { get; set; }

        [JsonProperty(PropertyName = "orbit_period")]
        public string OrbitPeriod { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "info_url")]
        public Uri InfoUrl { get; set; }

        [JsonProperty(PropertyName = "habitable")]
        public string Habitable { get; set; }

        [JsonProperty(PropertyName = "fairchanceact")]
        public string FairChanceAct { get; set; }

        [JsonProperty(PropertyName = "show_orbitlines")]
        public string ShowOrbitlines { get; set; }

        [JsonProperty(PropertyName = "show_label")]
        public string ShowLabel { get; set; }

        [JsonProperty(PropertyName = "appearance")]
        public string Appearance { get; set; }

        [JsonProperty(PropertyName = "sensor_population")]
        public string SensorPopulation { get; set; }

        [JsonProperty(PropertyName = "sensor_economy")]
        public string SensorEconomy { get; set; }

        [JsonProperty(PropertyName = "sensor_danger")]
        public string SensorDanger { get; set; }

        [JsonProperty(PropertyName = "shader_data")]
        public ShaderData ShaderData { get; set; }

        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; }

        [JsonProperty(PropertyName = "subtype_id")]
        public string SubtypeId { get; set; }

        [JsonProperty(PropertyName = "parent_id")]
        public string ParentId { get; set; }

        [JsonProperty(PropertyName = "subtype")]
        public SubType Subtype { get; set; }

        [JsonProperty(PropertyName = "affiliation")]
        public Affiliation[] Affiliation { get; set; }

        [JsonProperty(PropertyName = "population")]
        public string[] Population { get; set; }
    }
}