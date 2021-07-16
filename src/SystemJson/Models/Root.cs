using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SystemJson.Models
{
    public class Root
    {
        [JsonPropertyName("tarefas")]
        public IList<Job> Jobs;
    }
}