using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.Shared.ShaderData
{
    public class ChildShaderData : ShaderData
    {
        [JsonProperty("radius")]
        public double Radius { get; set; }
    }
}