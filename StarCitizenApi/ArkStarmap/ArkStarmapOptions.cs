namespace StarCitizenApi.ArkStarmap
{
    public class ArkStarmapOptions
    {
        public static readonly ArkStarmapOptions Default = new ArkStarmapOptions
        {
            CacheLocation = "."
        };

        public string CacheLocation { get; set; }
    }
}