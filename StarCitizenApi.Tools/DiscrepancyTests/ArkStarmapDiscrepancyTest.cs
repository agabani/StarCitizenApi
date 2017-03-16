using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using StarCitizenApi.Tools.ArkStarmap;

namespace StarCitizenApi.Tools.DiscrepancyTests
{
    [TestFixture]
    public class ArkStarmapDiscrepancyTest
    {
        private static void Test(JToken jObject, object @object)
        {
            TestLeaf(jObject, JObject.FromObject(@object));
        }

        private static void TestLeaf(JToken truth, JToken check)
        {
            foreach (var child in truth.Children())
            {
                Assert.That(check.SelectToken(child.Path), Is.Not.Null, $"Missing Path: {child.Path}");
                TestLeaf(child, check);
            }
        }

        [Test]
        public async Task BootUp()
        {
            Test(await new JObjectArkStarmap().BootUp(), await new StarCitizenApi.ArkStarmap.ArkStarmap().BootUp());
        }

        [Test]
        public async Task StarSystem()
        {
            var arkStarmap = new StarCitizenApi.ArkStarmap.ArkStarmap();
            var result = await arkStarmap.BootUp();

            foreach (var starSystem in result.Data.Systems.ResultSet)
            {
                Test(await new JObjectArkStarmap().StarSystem(starSystem.Code), await arkStarmap.StarSystem(starSystem.Code));
            }
        }
    }
}