namespace StarCitizenApi.FileSystem.Cache
{
    public class CacheOptions
    {
        public static readonly CacheOptions Default = new CacheOptions
        {
            CacheLocation = "."
        };

        public string CacheLocation { get; set; }
    }
}