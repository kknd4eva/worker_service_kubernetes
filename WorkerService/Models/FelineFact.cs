using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WorkerService.Models
{
    
    public class FelineFact
    {
        [JsonPropertyName("fact")]
        public string Fact { get; set; }
        [JsonPropertyName("length")]
        public int Length { get; set; }
    }
}
