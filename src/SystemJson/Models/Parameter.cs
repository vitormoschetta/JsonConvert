using System.Text.Json.Serialization;

namespace SystemJson.Models
{
    public class Parameter
    {
        public string Url;

        [JsonPropertyName("Segundos")]
        public string Seconds;
    }
}