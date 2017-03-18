using System.Threading.Tasks;

namespace StarCitizenApi.ArkStarmap.Cache
{
    public class NullCache : ICache
    {
        public Task<string> Get(string endpoint, string body)
        {
            return Task.FromResult<string>(null);
        }

        public Task Put(string endpoint, string body, string content)
        {
            return Task.FromResult<object>(null);
        }
    }
}