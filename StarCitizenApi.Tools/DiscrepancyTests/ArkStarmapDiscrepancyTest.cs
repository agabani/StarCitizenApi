using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using StarCitizenApi.Tools.ArkStarmap;

namespace StarCitizenApi.Tools.DiscrepancyTests
{
    [TestFixture]
    public class ArkStarmapDiscrepancyTest
    {
        [Test]
        public async Task Test()
        {
            var jObject = await new JObjectArkStarmap().BootUp();
            var fromObject = JObject.FromObject(await new StarCitizenApi.ArkStarmap.ArkStarmap().BootUp());

            foreach (var child in jObject.Children())
            {
                var jToken = fromObject[child.Path];

                Assert.That(jToken, Is.Not.Null, $"Missing Path: {child.Path}");
            }
        }
    }
}