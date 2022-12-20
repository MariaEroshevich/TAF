using Newtonsoft.Json;

namespace ReportPortal.TestAutomation.Utilities.Parser
{
    public static class JsonParser
    {
        public static T DeserializeJsonToObject<T>(string json) where T : class => JsonConvert.DeserializeObject<T>(json);

        public static string SerializeJson(object content) => JsonConvert.SerializeObject(content);

    }
}
