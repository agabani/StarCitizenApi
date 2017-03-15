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

        public Task<StarMapResult<BootUpData>> BootUp()
        {
            return Post<BootUpData>("/api/starmap/bootup", null);
        }

        public Task<StarMapResult<StarSystemData>> StarSystem(string code)
        {
            return Post<StarSystemData>($"/api/starmap/star-systems/{code}", null);
        }

        public Task<StarMapResult<CeletialObjectData>> CelestialObjects(string code)
        {
            return Post<CeletialObjectData>($"/api/starmap/star-systems/{code}", null);
        }

        public Task<StarMapResult<FindData>> Find(string query)
        {
            return Post<FindData>("/api/starmap/find", new {Query = query});
        }

        public Task<StarMapResult<RouteData>> FindRoute(string departure, string destination, string shipSize)
        {
            return Post<RouteData>("/api/starmap/routes/find", new {Departure = departure, Destination = destination, Ship_Size = shipSize});
        }

        public async Task<StarMapResult<T>> Post<T>(string endpoint, object body)
        {
            var json = ToJson(body);

            var content = FileCache.Get(endpoint, json);

            if (content != null)
            {
                return FromJson<T>(content);
            }

            using (var response = await Client.Send(NewPostRequest(endpoint, json)))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception();
                }

                content = await response.Content.ReadAsStringAsync();
            }

            FileCache.Put(endpoint, json, content);

            return FromJson<T>(content);
        }

        private static HttpRequestMessage NewPostRequest(string endpoint, string json)
        {
            if (json == null)
            {
                return new HttpRequestMessage(HttpMethod.Post, endpoint);
            }

            return new HttpRequestMessage(HttpMethod.Post, endpoint)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
        }

        private static string ToJson(object o)
        {
            return o == null ? null
                : JsonConvert.SerializeObject(o, new JsonSerializerSettings {ContractResolver = new CamelCasePropertyNamesContractResolver()});
        }

        private static StarMapResult<T> FromJson<T>(string value)
        {
            return JsonConvert.DeserializeObject<StarMapResult<T>>(value);
        }
    }
}