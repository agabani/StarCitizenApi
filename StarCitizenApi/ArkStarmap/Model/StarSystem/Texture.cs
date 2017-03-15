using System;
using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.StarSystem
{
    public class Texture
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("source")]
        public Uri Source { get; set; }

        [JsonProperty("images")]
        public TextureImage TextureImages { get; set; }
    }
}