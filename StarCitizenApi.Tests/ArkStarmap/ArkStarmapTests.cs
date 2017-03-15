using System.Threading.Tasks;
using NUnit.Framework;

namespace StarCitizenApi.Tests.ArkStarmap
{
    [TestFixture]
    public class ArkStarmapTests
    {
        [Test]
        public async Task BootUp()
        {
            var arkStarmap = new StarCitizenApi.ArkStarmap.ArkStarmap();

            var result = await arkStarmap.BootUp();
        }

        [Test]
        public async Task StarSystem()
        {
            var arkStarmap = new StarCitizenApi.ArkStarmap.ArkStarmap();

            var result = await arkStarmap.StarSystem("SOL");
        }

        [Test]
        public async Task CelestialObjects()
        {
            var arkStarmap = new StarCitizenApi.ArkStarmap.ArkStarmap();

            var celestialObjects = await arkStarmap.CelestialObjects("SOL.PLANETS.JUPITER");
        }
    }
}