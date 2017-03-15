using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using StarCitizenApi.ArkStarmap.Cache;
using StarCitizenApi.ArkStarmap.Model;
using StarCitizenApi.ArkStarmap.Model.BootUp;
using StarCitizenApi.ArkStarmap.Model.CelestialObjects;
using StarCitizenApi.ArkStarmap.Model.Find;
using StarCitizenApi.ArkStarmap.Model.Route;
using StarCitizenApi.ArkStarmap.Model.StarSystem;

namespace StarCitizenApi.ArkStarmap
{
    public class ArkStarmap
    {
        private static readonly ApiClient Client = new ApiClient(new Uri("https://robertsspaceindustries.com"));
        private static readonly FileCache FileCache = new FileCache();

        public async Task<StarMapResult<BootUpData>> BootUp()
        {
            const string endpoint = "/api/starmap/bootup";

            var content = FileCache.Get(endpoint, null);

            if (content != null)
            {
                return JsonConvert.DeserializeObject<StarMapResult<BootUpData>>(content);
            }

            using (var response = await Client.Send(new HttpRequestMessage(HttpMethod.Post, endpoint)))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception();
                }

                var value = await response.Content.ReadAsStringAsync();

                FileCache.Put(endpoint, null, value);

                return JsonConvert.DeserializeObject<StarMapResult<BootUpData>>(value);
            }
        }

        public async Task<StarMapResult<StarSystemData>> StarSystem(string code)
        {
            var endpoint = $"/api/starmap/star-systems/{code}";

            var content = FileCache.Get(endpoint, null);

            if (content != null)
            {
                return JsonConvert.DeserializeObject<StarMapResult<StarSystemData>>(content);
            }

            using (var response = await Client.Send(new HttpRequestMessage(HttpMethod.Post, endpoint)))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception();
                }

                var value = await response.Content.ReadAsStringAsync();

                FileCache.Put(endpoint, null, value);

                return JsonConvert.DeserializeObject<StarMapResult<StarSystemData>>(value);
            }
        }

        public async Task<CeletialObjects> CelestialObjects(string code)
        {
            using (var response = await Client.Send(new HttpRequestMessage(HttpMethod.Post, $"/api/starmap/star-systems/{code}")))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception();
                }

                return JsonConvert.DeserializeObject<CeletialObjects>(await response.Content.ReadAsStringAsync());
            }
        }

        public async Task<StarMapResult<FindData>> Find(string query)
        {
            const string endpoint = "/api/starmap/find";

            var body = JsonConvert.SerializeObject(new {Query = query}, new JsonSerializerSettings {ContractResolver = new CamelCasePropertyNamesContractResolver()});

            var content = FileCache.Get(endpoint, body);

            if (content != null)
            {
                return JsonConvert.DeserializeObject<StarMapResult<FindData>>(content);
            }

            using (var response = await Client.Send(new HttpRequestMessage(HttpMethod.Post, endpoint)
            {
                Content = new StringContent(body, Encoding.UTF8, "application/json")
            }))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception();
                }

                var value = await response.Content.ReadAsStringAsync();

                FileCache.Put(endpoint, body, value);

                return JsonConvert.DeserializeObject<StarMapResult<FindData>>(value);
            }
        }

        public async Task<StarMapResult<RouteData>> FindRoute(string departure, string destination, string shipSize)
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

                return JsonConvert.DeserializeObject<StarMapResult<RouteData>>(await response.Content.ReadAsStringAsync());
            }
        }
    }
}