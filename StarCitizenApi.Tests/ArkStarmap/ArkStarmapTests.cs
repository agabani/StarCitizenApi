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

       /* [Test]
        public async Task StarSystem()
        {
            var arkStarmap = new StarCitizenApi.ArkStarmap.ArkStarmap();

            var result = await arkStarmap.StarSystem("SOL");
        }*/
    }
}