namespace StarCitizenApi.ArkStarmap.Model
{
    public class Resultset
    {
        public string id { get; set; }
        public string status { get; set; }
        public string time_modified { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string position_x { get; set; }
        public string position_y { get; set; }
        public string position_z { get; set; }
        public object info_url { get; set; }
        public string habitable_zone_inner { get; set; }
        public string habitable_zone_outer { get; set; }
        public string frost_line { get; set; }
        public string description { get; set; }
        public Shader_Data shader_data { get; set; }
        public Affiliation[] affiliation { get; set; }
        public Celestial_Objects[] celestial_objects { get; set; }
        public string aggregated_size { get; set; }
        public float aggregated_population { get; set; }
        public float aggregated_economy { get; set; }
        public int aggregated_danger { get; set; }
    }
}