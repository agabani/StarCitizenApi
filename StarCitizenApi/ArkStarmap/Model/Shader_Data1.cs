namespace StarCitizenApi.ArkStarmap.Model
{
    public class Shader_Data1
    {
        public float orbitalMin { get; set; }
        public float orbitalMax { get; set; }
        public int orbitalFactor { get; set; }
        public Sun sun { get; set; }
        public float radius { get; set; }
        public Ring ring { get; set; }
        public Highlight highlight { get; set; }
        public string orbitalColor { get; set; }
        public string orbitalHighlightColor { get; set; }
        public int fullturn { get; set; }
    }
}