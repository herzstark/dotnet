using System.Text.Json.Serialization;

namespace dotnet.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Warlock = 1,
        DemonHunter = 2,
        Priest = 3
    }
}