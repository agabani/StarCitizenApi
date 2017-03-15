using System;
using Newtonsoft.Json;
using StarCitizenApi.ArkStarmap.Model.Shared;
using StarCitizenApi.ArkStarmap.Model.Shared.Assests;
using StarCitizenApi.ArkStarmap.Model.StarSystem.Assests;
using StarCitizenApi.ArkStarmap.Model.StarSystem.ShaderData;

namespace StarCitizenApi.ArkStarmap.Model.StarSystem
{
    public class CelestialObjects
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("time_modified")]
        public DateTime TimeModified { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

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
        public string Habitable { get; set; }

        [JsonProperty("fairchanceact")]
        public string FairChanceAct { get; set; }

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
        public CelestialShaderData ShaderData { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("subtype_id")]
        public string SubtypeId { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("subtype")]
        public SubType SubType { get; set; }

        [JsonProperty("affiliation")]
        public MemberedAffiliation[] Affiliation { get; set; }

        [JsonProperty("population")]
        public object[] Population { get; set; }

        [JsonProperty("texture")]
        public Texture Texture { get; set; }

        [JsonProperty("thumbnail")]
        public Thumbnail Thumbnail { get; set; }
    }
}