using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using StarCitizenApi.ArkStarmap.Model;
using StarCitizenApi.ArkStarmap.Model.BootUp;
using StarCitizenApi.ArkStarmap.Model.CelestialObjects;
using StarCitizenApi.ArkStarmap.Model.Find;
using StarCitizenApi.ArkStarmap.Model.Route;
using StarCitizenApi.ArkStarmap.Model.StarSystem;
using Data = StarCitizenApi.ArkStarmap.Model.CelestialObjects.Data;
using Route = StarCitizenApi.ArkStarmap.Model.BootUp.Route;
using StarSystem = StarCitizenApi.ArkStarmap.Model.StarSystem.StarSystem;

namespace StarCitizenApi.ArkStarmap
{
    public class ArkStarmap
    {
        private static readonly ApiClient Client = new ApiClient(new Uri("https://robertsspaceindustries.com"));

        public async Task<StarMapResult<BootUpData>> BootUp()
        {
            using (var response = await Client.Send(new HttpRequestMessage(HttpMethod.Post, "/api/starmap/bootup")))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception();
                }

                return JsonConvert.DeserializeObject<StarMapResult<BootUpData>>(await response.Content.ReadAsStringAsync());
            }
        }

        public async Task<StarMapResult<StarSystemData>> StarSystem(string code)
        {
            using (var response = await Client.Send(new HttpRequestMessage(HttpMethod.Post, $"/api/starmap/star-systems/{code}")))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception();
                }

                return JsonConvert.DeserializeObject<StarMapResult<StarSystemData>>(await response.Content.ReadAsStringAsync());
            }
        }

        public async Task<StarCitizenApi.ArkStarmap.Model.CelestialObjects.CeletialObjects> CelestialObjects(string code)
        {
            using (var response = await Client.Send(new HttpRequestMessage(HttpMethod.Post, $"/api/starmap/star-systems/{code}")))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception();
                }

                return JsonConvert.DeserializeObject<StarCitizenApi.ArkStarmap.Model.CelestialObjects.CeletialObjects>(await response.Content.ReadAsStringAsync());
            }
        }

        public async Task<Find> Find(string query)
        {
            using (var response = await Client.Send(new HttpRequestMessage(HttpMethod.Post, "/api/starmap/find")
            {
                Content = new StringContent(JsonConvert.SerializeObject(new {Query = query}, new JsonSerializerSettings {ContractResolver = new CamelCasePropertyNamesContractResolver()}), Encoding.UTF8, "application/json")
            }))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception();
                }

                return JsonConvert.DeserializeObject<Find>(await response.Content.ReadAsStringAsync());
            }
        }

        public async Task<FindRoute> FindRoute(string departure, string destination, string shipSize)
        {
            using (var response = await Client.Send(new HttpRequestMessage(HttpMethod.Post, "/api/starmap/routes/find")
            {
                Content = new StringContent(JsonConvert.SerializeObject(new {Departure = departure, Destination = destination, Ship_Size = shipSize}, new JsonSerializerSettings {ContractResolver = new CamelCasePropertyNamesContractResolver()}), Encoding.UTF8, "application/json")
            }))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception();
                }

                return JsonConvert.DeserializeObject<FindRoute>(await response.Content.ReadAsStringAsync());
            }
        }
    }
}