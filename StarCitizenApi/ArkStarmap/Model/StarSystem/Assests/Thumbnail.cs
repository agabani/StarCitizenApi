using System;
using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.StarSystem.Assests
{
    public class Thumbnail
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("source")]
        public Uri Source { get; set; }

        [JsonProperty("images")]
        public ThumbnailImage Images { get; set; }
    }
}