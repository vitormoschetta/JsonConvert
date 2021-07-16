using System.Collections.Generic;
using Newtonsoft.Json;

namespace Shared.Models
{
    public class Job
    {
        [JsonProperty("Servico")]
        public string Service;

        [JsonProperty("Habilitado")]
        public string Enabled;

        [JsonProperty("Parametros")]
        public Parameter Parameters;

        //public Dictionary<string, string> Parameters;
    }
}