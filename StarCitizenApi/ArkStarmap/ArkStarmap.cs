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
        private static readonly ArkStarmapApiClient Client = new ArkStarmapApiClient();

        public async Task<Result<BootUp>> BootUp()
        {
            return (await Client.BootUp()).ToObject<Result<BootUp>>();
        }

        public async Task<Result<StarSystems>> StarSystem(string code)
        {
            return (await Client.StarSystem(code)).ToObject<Result<StarSystems>>();
        }

        public async Task<Result<CelestialObjects>> CelestialObjects(string code)
        {
            return (await Client.CelestialObjects(code)).ToObject<Result<CelestialObjects>>();
        }

        public async Task<Result<Find>> Find(string query)
        {
            return (await Client.Find(query)).ToObject<Result<Find>>();
        }

        public async Task<Result<FindRoute>> FindRoute(string departure, string destination, string shipSize)
        {
            return (await Client.FindRoute(departure, destination, shipSize)).ToObject<Result<FindRoute>>();
        }
    }
}