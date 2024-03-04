using System.Text.Json;

namespace ClientLibrary.Helpers
{
    public static class Serializations
    {
        public static string Serializeobj<T>(T modelObject) => JsonSerializer.Serialize(modelObject);
        public static T DeserializeJsonString<T>(string JsonString) => JsonSerializer.Deserialize<T>(JsonString);
        public static IList<T> DeserializeJsonStringList<T>(String JsonString) => JsonSerializer.Deserialize<IList<T>>(JsonString);
    }
}
 