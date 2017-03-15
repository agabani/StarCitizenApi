using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StarCitizenApi.ArkStarmap.Model.BootUp;
using StarCitizenApi.ArkStarmap.Model.StarSystem;

namespace StarCitizenApi.ArkStarmap
{
    public class ArkStarmap
    {
        private static readonly ApiClient Client = new ApiClient(new Uri("https://robertsspaceindustries.com"));

        public async Task<BootUp> BootUp()
        {
            using (var response = await Client.Send(new HttpRequestMessage(HttpMethod.Post, "/api/starmap/bootup")))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception();
                }

                return JsonConvert.DeserializeObject<BootUp>(await response.Content.ReadAsStringAsync());
            }
        }

        public async Task<StarSystem> StarSystem(string code)
        {
            using (var response = await Client.Send(new HttpRequestMessage(HttpMethod.Post, $"/api/starmap/star-systems/{code}")))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception();
                }

                return JsonConvert.DeserializeObject<StarSystem>(await response.Content.ReadAsStringAsync());
            }
        }

        public async Task<CelestialObjects> CelestialObjects(string code)
        {
            using (var response = await Client.Send(new HttpRequestMessage(HttpMethod.Post, $"/api/starmap/star-systems/{code}")))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception();
                }

                return JsonConvert.DeserializeObject<CelestialObjects>(await response.Content.ReadAsStringAsync());
            }
        }
    }
}