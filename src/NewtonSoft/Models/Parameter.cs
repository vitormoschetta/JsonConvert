using Newtonsoft.Json;

namespace Shared.Models
{
    public class Parameter
    {        
        public string Url;

        [JsonProperty("Segundos")]
        public string Seconds;
    }
}