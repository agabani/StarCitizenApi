using System.Linq;
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

            Assert.That(result.Success, Is.EqualTo(1));

            // Affiliations
            Assert.That(result.Data.Affiliations.ResultSet, Is.Not.Empty);

            // Config
            Assert.That(result.Data.Config.Routes, Is.Not.Empty);
            Assert.That(result.Data.Config.Starfield, Is.Not.Null);
            Assert.That(result.Data.Config.LongRangeScanner, Is.Not.Null);

            // Species
            Assert.That(result.Data.Species, Is.Not.Null);
            Assert.That(result.Data.Species.ResultSet, Is.Not.Empty);

            // Systems
            Assert.That(result.Data.Systems.ResultSet, Is.Not.Empty);
            foreach (var resultSet in result.Data.Systems.ResultSet)
            {
                Assert.That(resultSet.Affiliation.All(affiliation => affiliation.MembershipId != null));
            }

            // Tunnels
            Assert.That(result.Data.Tunnels.ResultSet, Is.Not.Empty);
            foreach (var resultSet in result.Data.Tunnels.ResultSet)
            {
                Assert.That(resultSet.Entry, Is.Not.Null);
                Assert.That(resultSet.Exit, Is.Not.Null);
            }
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

        [Test]
        [TestCase("SOL.PLANETS.EARTH", "STANTON.STATION.PORTOLISAR", "L")]
        public async Task FindRoute(string departure, string destination, string shipSize)
        {
            var arkStarmap = new StarCitizenApi.ArkStarmap.ArkStarmap();

            var find = await arkStarmap.FindRoute(departure, destination, shipSize);
        }

        [Test]
        [TestCase("SOL")]
        [TestCase("STANTON")]
        public async Task StarSystem(string code)
        {
            var arkStarmap = new StarCitizenApi.ArkStarmap.ArkStarmap();

            var result = await arkStarmap.StarSystem(code);
        }
    }
}