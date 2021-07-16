using System.Collections.Generic;
using Newtonsoft.Json;

namespace Shared.Models
{
    public class Root
    {
        [JsonProperty("Tarefas")]
        public IList<Job> Jobs;
    }
}