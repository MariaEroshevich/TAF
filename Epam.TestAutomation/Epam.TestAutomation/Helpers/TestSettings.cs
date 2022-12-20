using System.Configuration;
using System.IO;

namespace Epam.TestAutomation.Helper
{
    public static partial class TestSettings
    {
        public static readonly string ApplicationUrl = GetConfigurationValue("ApplicationUrl");

        public static readonly string LogsPath = Path.Combine(Directory.GetCurrentDirectory(), GetConfigurationValue("LogsPath"));

        public static string TestResourcesFolder => Path.Combine(Directory.GetCurrentDirectory(), GetConfigurationValue("TestResourcesFolder"));
        
        public static string UserName => GetConfigurationValue("UserName");
        
        public static string UserPassword => GetConfigurationValue("UserPassword");

        private static string GetConfigurationValue(string parameter) => ConfigurationManager.AppSettings.Get(parameter);
    }
}
