using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.CelestialObjects
{
    public class Child
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("time_modified")]
        public string time_modified { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("designation")]
        public string designation { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("age")]
        public string age { get; set; }

        [JsonProperty("distance")]
        public string distance { get; set; }

        [JsonProperty("latitude")]
        public string latitude { get; set; }

        [JsonProperty("longitude")]
        public string longitude { get; set; }

        [JsonProperty("axial_tilt")]
        public string axial_tilt { get; set; }

        [JsonProperty("orbit_period")]
        public string orbit_period { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("info_url")]
        public object info_url { get; set; }

        [JsonProperty("habitable")]
        public object habitable { get; set; }

        [JsonProperty("fairchanceact")]
        public object fairchanceact { get; set; }

        [JsonProperty("show_orbitlines")]
        public string show_orbitlines { get; set; }

        [JsonProperty("show_label")]
        public string show_label { get; set; }

        [JsonProperty("appearance")]
        public string appearance { get; set; }

        [JsonProperty("sensor_population")]
        public string sensor_population { get; set; }

        [JsonProperty("sensor_economy")]
        public string sensor_economy { get; set; }

        [JsonProperty("sensor_danger")]
        public string sensor_danger { get; set; }

        [JsonProperty("shader_data")]
        public Shader_Data1 shader_data { get; set; }

        [JsonProperty("size")]
        public string size { get; set; }

        [JsonProperty("subtype_id")]
        public string subtype_id { get; set; }

        [JsonProperty("parent_id")]
        public string parent_id { get; set; }

        [JsonProperty("subtype")]
        public Subtype1 subtype { get; set; }

        [JsonProperty("affiliation")]
        public object[] affiliation { get; set; }

        [JsonProperty("population")]
        public object[] population { get; set; }

        [JsonProperty("media")]
        public Medium[] media { get; set; }
    }
}