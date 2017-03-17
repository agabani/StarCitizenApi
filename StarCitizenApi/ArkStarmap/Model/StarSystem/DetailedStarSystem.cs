using Newtonsoft.Json;
using StarCitizenApi.ArkStarmap.Model.Shared;
using StarCitizenApi.ArkStarmap.Model.StarSystem.ShaderData;

namespace StarCitizenApi.ArkStarmap.Model.StarSystem
{
    public class DetailedStarSystem : Shared.StarSystem
    {
        [JsonProperty("habitable_zone_inner")]
        public string HabitableZoneInner { get; set; }

        [JsonProperty("habitable_zone_outer")]
        public string HabitableZoneOuter { get; set; }

        [JsonProperty("frost_line")]
        public string FrostLine { get; set; }

        [JsonProperty("shader_data")]
        public StarSystemShaderData ShaderData { get; set; }

        [JsonProperty("celestial_objects")]
        public DetailedCelestialObject[] CelestialObjects { get; set; }
    }
}