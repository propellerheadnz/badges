﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace badges_api.Models
{
    [DataContract]
    public class ProficiencyMap
    {
        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string id { get; set; }
        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string occupationStageId { get; set; }
        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string competencyId { get; set; }
        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string proficiencyId { get; set; }
    }
}