namespace StarCitizenApi.ArkStarmap.Model
{
    public class Data
    {
        public int rowcount { get; set; }
        public string totalrows { get; set; }
        public bool estimatedrows { get; set; }
        public int pagesize { get; set; }
        public object pagecount { get; set; }
        public int page { get; set; }
        public int offset { get; set; }
        public int startrow { get; set; }
        public Resultset[] resultset { get; set; }
    }
}