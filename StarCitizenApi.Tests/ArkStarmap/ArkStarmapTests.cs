using System.Threading.Tasks;
using NUnit.Framework;

namespace StarCitizenApi.Tests.ArkStarmap
{
    [TestFixture]
    public class ArkStarmapTests
    {
        [Test]
        public async Task Test()
        {
            var arkStarmap = new StarCitizenApi.ArkStarmap.ArkStarmap();

            var result = await arkStarmap.StarSystem("SOL");
        }
    }
}