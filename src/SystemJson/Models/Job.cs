using System.Text.Json.Serialization;

namespace SystemJson.Models
{
    public class Job
    {
        [JsonPropertyName("servico")]
        public string Service;

        [JsonPropertyName("gabilitado")]
        public string Enabled;

        [JsonPropertyName("parametros")]
        public Parameter Parameters;

        //public Dictionary<string, string> Parameters;
    }
}