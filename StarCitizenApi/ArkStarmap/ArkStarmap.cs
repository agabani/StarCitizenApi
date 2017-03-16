using System.Threading.Tasks;
using StarCitizenApi.ArkStarmap.Internal;
using StarCitizenApi.ArkStarmap.Model;
using StarCitizenApi.ArkStarmap.Model.BootUp;
using StarCitizenApi.ArkStarmap.Model.CelestialObjects;
using StarCitizenApi.ArkStarmap.Model.Find;
using StarCitizenApi.ArkStarmap.Model.FindRoute;
using StarCitizenApi.ArkStarmap.Model.StarSystem;

namespace StarCitizenApi.ArkStarmap
{
    public class ArkStarmap
    {
        private readonly ArkStarmapApiClient _client;

        public ArkStarmap() : this(ArkStarmapOptions.Default)
        {
        }

        public ArkStarmap(ArkStarmapOptions options)
        {
            _client = new ArkStarmapApiClient(options);
        }

        public async Task<Result<BootUp>> BootUp()
        {
            return (await _client.BootUp()).ToObject<Result<BootUp>>();
        }

        public async Task<Result<StarSystems>> StarSystem(string code)
        {
            return (await _client.StarSystem(code)).ToObject<Result<StarSystems>>();
        }

        public async Task<Result<CelestialObjects>> CelestialObjects(string code)
        {
            return (await _client.CelestialObjects(code)).ToObject<Result<CelestialObjects>>();
        }

        public async Task<Result<Find>> Find(string query)
        {
            return (await _client.Find(query)).ToObject<Result<Find>>();
        }

        public async Task<Result<FindRoute>> FindRoute(string departure, string destination, string shipSize)
        {
            return (await _client.FindRoute(departure, destination, shipSize)).ToObject<Result<FindRoute>>();
        }
    }
}