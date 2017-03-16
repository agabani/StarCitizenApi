using System;
using Newtonsoft.Json;
using StarCitizenApi.ArkStarmap.Model.CelestialObjects.Assets;
using StarCitizenApi.ArkStarmap.Model.Shared;
using StarCitizenApi.ArkStarmap.Model.Shared.ShaderData;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects
{
    public class Child : Entity
    {
        [JsonProperty("time_modified")]
        public DateTime TimeModified { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("age")]
        public string Age { get; set; }

        [JsonProperty("distance")]
        public string Distance { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("axial_tilt")]
        public string AxialTilt { get; set; }

        [JsonProperty("orbit_period")]
        public string OrbitPeriod { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("info_url")]
        public object InfoUrl { get; set; }

        [JsonProperty("habitable")]
        public object Habitable { get; set; }

        [JsonProperty("fairchanceact")]
        public object Fairchanceact { get; set; }

        [JsonProperty("show_orbitlines")]
        public string ShowOrbitlines { get; set; }

        [JsonProperty("show_label")]
        public string ShowLabel { get; set; }

        [JsonProperty("appearance")]
        public string Appearance { get; set; }

        [JsonProperty("sensor_population")]
        public string SensorPopulation { get; set; }

        [JsonProperty("sensor_economy")]
        public string SensorEconomy { get; set; }

        [JsonProperty("sensor_danger")]
        public string SensorDanger { get; set; }

        [JsonProperty("shader_data")]
        public ShaderData ShaderData { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("subtype_id")]
        public string SubtypeId { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("subtype")]
        public SubType SubType { get; set; }

        [JsonProperty("affiliation")]
        public object[] Affiliation { get; set; }

        [JsonProperty("population")]
        public object[] Population { get; set; }

        [JsonProperty("media")]
        public Media[] Media { get; set; }
    }
}