namespace StarCitizenApi.ArkStarmap.Model
{
    public class Highlight
    {
        public string color1 { get; set; }
        public string color2 { get; set; }
        public float alpha { get; set; }
        public float atmosphere1 { get; set; }
        public float atmosphere2 { get; set; }
        public float atmosphere3 { get; set; }
        public float scaleMin { get; set; }
        public int scaleMax { get; set; }
        public int scalePeriod { get; set; }
    }
}