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
        [TestCase("SOL")]
        [TestCase("STANTON")]
        public async Task StarSystem(string code)
        {
            Test(await new JObjectArkStarmap().StarSystem(code), await new StarCitizenApi.ArkStarmap.ArkStarmap().StarSystem(code));
        }
    }
}