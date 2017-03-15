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
        [TestCase("SOL")]
        [TestCase("STANTON")]
        public async Task StarSystem(string code)
        {
            var arkStarmap = new StarCitizenApi.ArkStarmap.ArkStarmap();

            var result = await arkStarmap.StarSystem(code);
        }

        [Test]
        [TestCase("SOL.STARS.SOL")]
        [TestCase("SOL.PLANETS.JUPITER")]
        [TestCase("SOL.JUMPPOINTS.DAVIEN")]
        [TestCase("SOL.BELTS.KEUPERBELT")]
        [TestCase("STANTON.STATION.PORTOLISAR")]
        public async Task CelestialObjects(string code)
        {
            var arkStarmap = new StarCitizenApi.ArkStarmap.ArkStarmap();

            var celestialObjects = await arkStarmap.CelestialObjects(code);
        }

        [Test]
        [TestCase("SOL")]
        public async Task Find(string query)
        {
            var arkStarmap = new StarCitizenApi.ArkStarmap.ArkStarmap();

            var find = await arkStarmap.Find(query);
        }
    }
}