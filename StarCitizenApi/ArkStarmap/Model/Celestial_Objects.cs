namespace StarCitizenApi.ArkStarmap.Model
{
    public class Celestial_Objects
    {
        public string id { get; set; }
        public string time_modified { get; set; }
        public string type { get; set; }
        public string designation { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string age { get; set; }
        public string distance { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string axial_tilt { get; set; }
        public string orbit_period { get; set; }
        public string description { get; set; }
        public object info_url { get; set; }
        public string habitable { get; set; }
        public string fairchanceact { get; set; }
        public string show_orbitlines { get; set; }
        public string show_label { get; set; }
        public string appearance { get; set; }
        public string sensor_population { get; set; }
        public string sensor_economy { get; set; }
        public string sensor_danger { get; set; }
        public Shader_Data1 shader_data { get; set; }
        public string size { get; set; }
        public string subtype_id { get; set; }
        public string parent_id { get; set; }
        public Subtype subtype { get; set; }
        public Affiliation1[] affiliation { get; set; }
        public object[] population { get; set; }
        public Texture texture { get; set; }
        public Thumbnail thumbnail { get; set; }
    }
}