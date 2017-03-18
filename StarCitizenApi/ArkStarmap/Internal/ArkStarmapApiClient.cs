using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using StarCitizenApi.ArkStarmap.Cache;
using StarCitizenApi.Internal;

namespace StarCitizenApi.ArkStarmap.Internal
{
    public class ArkStarmapApiClient
    {
        private static readonly ApiClient Client = new ApiClient(new Uri("https://robertsspaceindustries.com"));
        private readonly ICache _cache;

        public ArkStarmapApiClient(ICache cache)
        {
            _cache = cache;
        }

        public Task<JObject> BootUp()
        {
            return Post("/api/starmap/bootup", null);
        }

        public Task<JObject> StarSystem(string code)
        {
            return Post($"/api/starmap/star-systems/{code}", null);
        }

        public Task<JObject> CelestialObjects(string code)
        {
            return Post($"/api/starmap/celestial-objects/{code}", null);
        }

        public Task<JObject> Find(string query)
        {
            return Post("/api/starmap/find", new {Query = query});
        }

        public Task<JObject> FindRoute(string departure, string destination, string shipSize)
        {
            return Post("/api/starmap/routes/find",
                new {Departure = departure, Destination = destination, Ship_Size = shipSize});
        }

        public async Task<JObject> Post(string endpoint, object body)
        {
            var json = ToJson(body);

            var content = await _cache.Get(endpoint, json);

            if (content != null)
                return FromJson(content);

            using (var response = await Client.Send(NewPostRequest(endpoint, json)))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new Exception();

                content = await response.Content.ReadAsStringAsync();
            }

            await _cache.Put(endpoint, json, content);

            return FromJson(content);
        }

        private static HttpRequestMessage NewPostRequest(string endpoint, string json)
        {
            if (json == null)
                return new HttpRequestMessage(HttpMethod.Post, endpoint);

            return new HttpRequestMessage(HttpMethod.Post, endpoint)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
        }

        private static string ToJson(object o)
        {
            return o == null
                ? null
                : JsonConvert.SerializeObject(o,
                    new JsonSerializerSettings {ContractResolver = new CamelCasePropertyNamesContractResolver()});
        }

        private static JObject FromJson(string value)
        {
            return JObject.Parse(value);
        }
    }
}