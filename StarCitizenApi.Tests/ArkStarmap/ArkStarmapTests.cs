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
            Assert.That(result.Data.Config.Routes.All(r => r.Color != null));
            Assert.That(result.Data.Config.Starfield.Color1, Is.Not.Null);
            Assert.That(result.Data.Config.LongRangeScanner.ColorC1, Is.Not.Null);

            // Species
            Assert.That(result.Data.Species.ResultSet.All(r => r.Id != null));

            // Systems
            Assert.That(result.Data.Systems.ResultSet.All(r => r.Id != null));
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


            var result = await arkStarmap.Find(query);

            Assert.That(result.Success, Is.EqualTo(1));

            Assert.That(result.Data.Systems.ResultSet.All(r => r.Id != null));
            Assert.That(result.Data.Objects.ResultSet.All(r => r.Id != null));
        }

        [Test]
        [TestCase("SOL.PLANETS.EARTH", "STANTON.STATION.PORTOLISAR", "L")]
        public async Task FindRoute(string departure, string destination, string shipSize)
        {
            var arkStarmap = new StarCitizenApi.ArkStarmap.ArkStarmap();

            var result = await arkStarmap.FindRoute(departure, destination, shipSize);

            Assert.That(result.Data.LeastJumps.Segments.All(s => s.Id != null));
            Assert.That(result.Data.Shortest.Segments.All(s => s.Id != null));
        }

        [Test]
        [TestCase("SOL")]
        [TestCase("STANTON")]
        public async Task StarSystem(string code)
        {
            var arkStarmap = new StarCitizenApi.ArkStarmap.ArkStarmap();

            var result = await arkStarmap.StarSystem(code);

            Assert.That(result.Data.ResultSet.All(r => r.CelestialObjects.All(c => c.Affiliation.All(a => a.Id != null))));
        }
    }
}