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
using StarCitizenApi.ArkStarmap.Model.FindRoute;
using StarCitizenApi.ArkStarmap.Model.StarSystem;

namespace StarCitizenApi.ArkStarmap
{
    public class ArkStarmap
    {
        private static readonly ApiClient Client = new ApiClient(new Uri("https://robertsspaceindustries.com"));
        private static readonly FileCache FileCache = new FileCache();

        public Task<Result<BootUpData>> BootUp()
        {
            return Post<BootUpData>("/api/starmap/bootup", null);
        }

        public Task<Result<StarSystems>> StarSystem(string code)
        {
            return Post<StarSystems>($"/api/starmap/star-systems/{code}", null);
        }

        public Task<Result<CeletialObjectData>> CelestialObjects(string code)
        {
            return Post<CeletialObjectData>($"/api/starmap/star-systems/{code}", null);
        }

        public Task<Result<Find>> Find(string query)
        {
            return Post<Find>("/api/starmap/find", new {Query = query});
        }

        public Task<Result<FindRoute>> FindRoute(string departure, string destination, string shipSize)
        {
            return Post<FindRoute>("/api/starmap/routes/find", new {Departure = departure, Destination = destination, Ship_Size = shipSize});
        }

        public async Task<Result<T>> Post<T>(string endpoint, object body)
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

        private static Result<T> FromJson<T>(string value)
        {
            return JsonConvert.DeserializeObject<Result<T>>(value);
        }
    }
}