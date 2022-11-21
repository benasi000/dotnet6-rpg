using System.Text.Json.Serialization;

namespace NET_6_WEB_API.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight = 1,
        Mage = 2,
        Clerec = 3
    }
}