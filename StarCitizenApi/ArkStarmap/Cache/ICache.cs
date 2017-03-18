using System.Threading.Tasks;

namespace StarCitizenApi.ArkStarmap.Cache
{
    public interface ICache
    {
        Task<string> Get(string endpoint, string body);
        Task Put(string endpoint, string body, string content);
    }
}