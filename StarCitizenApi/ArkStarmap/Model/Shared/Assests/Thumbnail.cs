using System;
using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.Shared.Assests
{
    public class Thumbnail<TImage>
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("source")]
        public Uri Source { get; set; }

        [JsonProperty("images")]
        public TImage Images { get; set; }
    }
}