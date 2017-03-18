namespace StarCitizenApi.ArkStarmap.Cache
{
    public interface ICache
    {
        string Get(string endpoint, string body);
        void Put(string endpoint, string body, string content);
    }
}