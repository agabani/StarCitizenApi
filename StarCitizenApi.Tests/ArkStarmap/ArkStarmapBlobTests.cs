using System.Threading.Tasks;
using StarCitizenApi.WindowsAzure.Cache;
using Xunit;

namespace StarCitizenApi.Tests.ArkStarmap
{
    public class ArkStarmapBlobTests
    {
        private readonly StarCitizenApi.ArkStarmap.ArkStarmap _arkStarmap =
            new StarCitizenApi.ArkStarmap.ArkStarmap(
                new BlobCache(new CacheOptions
                {
                    ConnectionString = "UseDevelopmentStorage=true;",
                    Container = "starcitizenapicache"
                }));

        [Theory]
        [Trait("Category", "Integration.Azure")]
        [InlineData("SOL.STARS.SOL")]
        [InlineData("SOL.PLANETS.JUPITER")]
        [InlineData("SOL.JUMPPOINTS.DAVIEN")]
        [InlineData("SOL.BELTS.KEUPERBELT")]
        [InlineData("STANTON.STATION.PORTOLISAR")]
        public async Task CelestialObjects(string code)
        {
            var result = await _arkStarmap.CelestialObjects(code);
            Assert.All(result.Data.ResultSet,
                celestialObject => Assert.All(celestialObject.Children, child => Assert.NotNull(child.Id)));
        }

        [Theory]
        [Trait("Category", "Integration.Azure")]
        [InlineData("SOL")]
        public async Task Find(string query)
        {
            var result = await _arkStarmap.Find(query);

            Assert.Equal(result.Success, 1);

            Assert.All(result.Data.Systems.ResultSet, entity => Assert.NotNull(entity.Id));
            Assert.All(result.Data.Objects.ResultSet, entity => Assert.NotNull(entity.Id));
        }

        [Theory]
        [Trait("Category", "Integration.Azure")]
        [InlineData("SOL.PLANETS.EARTH", "STANTON.STATION.PORTOLISAR", "L")]
        public async Task FindRoute(string departure, string destination, string shipSize)
        {
            var result = await _arkStarmap.FindRoute(departure, destination, shipSize);

            Assert.All(result.Data.LeastJumps.Segments, segment => Assert.NotNull(segment.Id));
            Assert.All(result.Data.Shortest.Segments, segment => Assert.NotNull(segment.Id));
        }

        [Theory]
        [Trait("Category", "Integration.Azure")]
        [InlineData("SOL")]
        [InlineData("STANTON")]
        public async Task StarSystem(string code)
        {
            var result = await _arkStarmap.StarSystem(code);

            Assert.All(result.Data.ResultSet,
                system => Assert.All(system.CelestialObjects, celestialObject => Assert.NotNull(celestialObject.Id)));
        }

        [Fact]
        [Trait("Category", "Integration.Azure")]
        public async Task BootUp()
        {
            var result = await _arkStarmap.BootUp();

            Assert.Equal(result.Success, 1);

            // Affiliations
            Assert.NotEmpty(result.Data.Affiliations.ResultSet);

            // Config
            Assert.NotEmpty(result.Data.Config.Routes);
            Assert.All(result.Data.Config.Routes, route => Assert.NotNull(route.Color));
            Assert.NotNull(result.Data.Config.Starfield.Color1);
            Assert.NotNull(result.Data.Config.LongRangeScanner.ColorC1);

            // Species
            Assert.All(result.Data.Species.ResultSet, specie => Assert.NotNull(specie.Id));

            // Systems
            Assert.All(result.Data.Systems.ResultSet, system => Assert.NotNull(system.Id));
            Assert.All(result.Data.Systems.ResultSet,
                system => Assert.All(system.Affiliation, affiliation => Assert.NotNull(affiliation.MembershipId)));

            // Tunnels
            Assert.NotEmpty(result.Data.Tunnels.ResultSet);
            Assert.All(result.Data.Tunnels.ResultSet, tunnel => Assert.NotNull(tunnel.Entry));
            Assert.All(result.Data.Tunnels.ResultSet, tunnel => Assert.NotNull(tunnel.Exit));
        }
    }
}