using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using StarCitizenApi.ArkStarmap.Internal;
using StarCitizenApi.WindowsAzure.Cache;
using Xunit;

namespace StarCitizenApi.Tools.Discrepancy
{
    public class ArkStarmapBlobTests
    {
        private readonly ArkStarmapApiClient _arkStarmapApiClient =
            new ArkStarmapApiClient(new BlobCache(new CacheOptions
            {
                ConnectionString = "UseDevelopmentStorage=true;",
                Container = "starcitizenapicache"
            }));

        private readonly ArkStarmap.ArkStarmap _arkStarmap =
            new ArkStarmap.ArkStarmap(new BlobCache(new CacheOptions
            {
                ConnectionString = "UseDevelopmentStorage=true;",
                Container = "starcitizenapicache"
            }));

        private static void Test(JToken jObject, object @object)
        {
            TestLeaf(jObject, JObject.FromObject(@object));
        }

        private static void TestLeaf(JToken truth, JToken check)
        {
            foreach (var child in truth.Children())
            {
                Assert.NotNull(check.SelectToken(child.Path));
                TestLeaf(child, check);
            }
        }

        [Theory]
        [Trait("Category", "Discrepancy.Azure")]
        [InlineData("SOL")]
        public async Task Find(string query)
        {
            Test(await _arkStarmapApiClient.Find(query), await _arkStarmap.Find(query));
        }

        [Fact]
        [Trait("Category", "Discrepancy.Azure")]
        public async Task BootUp()
        {
            Test(await _arkStarmapApiClient.BootUp(), await _arkStarmap.BootUp());
        }

        [Fact]
        [Trait("Category", "Discrepancy.Azure")]
        public async Task CelestialObjects()
        {
            foreach (var starSystem in (await _arkStarmap.BootUp()).Data.Systems.ResultSet)
            foreach (var system in (await _arkStarmap.StarSystem(starSystem.Code)).Data.ResultSet)
            foreach (var celestialObject in system.CelestialObjects)
            {
                Console.WriteLine(celestialObject.Code);
                Test(await _arkStarmapApiClient.CelestialObjects(celestialObject.Code),
                    await _arkStarmap.CelestialObjects(celestialObject.Code));
            }
        }

        [Fact]
        [Trait("Category", "Discrepancy.Azure")]
        public async Task StarSystem()
        {
            foreach (var starSystem in (await _arkStarmap.BootUp()).Data.Systems.ResultSet)
                Test(await _arkStarmapApiClient.StarSystem(starSystem.Code),
                    await _arkStarmap.StarSystem(starSystem.Code));
        }
    }
}