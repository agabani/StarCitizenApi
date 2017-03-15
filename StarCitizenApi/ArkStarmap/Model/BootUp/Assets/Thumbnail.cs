using System;
using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.BootUp
{
    public class Thumbnail
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("source")]
        public Uri Source { get; set; }

        [JsonProperty("images")]
        public object Images { get; set; } // TODO: CAN BE IMAGE OR EMPTY ARRAY.... NEED TO MAKE DESERIALIZER THAT WILL MAKE THIS INTO A LIST OF IAMGES
    }
}