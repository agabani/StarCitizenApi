﻿using Newtonsoft.Json;

namespace StarCitizenApi.ArkStarmap.Model.BootUp
{
    public class BootUp
    {
        [JsonProperty("success")]
        public int Success { get; set; }

        [JsonProperty("data")]
        public BootUpData Data { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }
    }
}