using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using StarCitizenApi.Tools.ArkStarmap;

namespace StarCitizenApi.Tools.DiscrepancyTests
{
    [TestFixture]
    public class ArkStarmapDiscrepancyTest
    {
        private readonly JObjectArkStarmap _jObjectArkStarmap = new JObjectArkStarmap();
        private readonly StarCitizenApi.ArkStarmap.ArkStarmap _arkStarmap = new StarCitizenApi.ArkStarmap.ArkStarmap();

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
            Test(await _jObjectArkStarmap.BootUp(), await _arkStarmap.BootUp());
        }

        [Test]
        public async Task CelestialObjects()
        {
            foreach (var starSystem in (await _arkStarmap.BootUp()).Data.Systems.ResultSet)
            {
                foreach (var system in (await _arkStarmap.StarSystem(starSystem.Code)).Data.ResultSet)
                {
                    foreach (var celestialObject in system.CelestialObjects)
                    {
                        Console.WriteLine(celestialObject.Code);
                        Test(await _jObjectArkStarmap.CelestialObjects(celestialObject.Code), await _arkStarmap.CelestialObjects(celestialObject.Code));
                    }
                }
            }
        }

        [Test]
        [TestCase("SOL")]
        public async Task Find(string query)
        {
            Test(await _jObjectArkStarmap.Find(query), await _arkStarmap.Find(query));
        }

        [Test]
        public async Task StarSystem()
        {
            foreach (var starSystem in (await _arkStarmap.BootUp()).Data.Systems.ResultSet)
            {
                Test(await _jObjectArkStarmap.StarSystem(starSystem.Code), await _arkStarmap.StarSystem(starSystem.Code));
            }
        }
    }
}