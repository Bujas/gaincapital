using Gaincapital_v1.Api.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gaincapital_v1.Api
{
    class LastesDto
    {
        [JsonProperty("base")]
        public string Base { get; set; }
        public Rates Rates { get; set; }
    }
}
