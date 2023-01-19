using Epam.TestAutomation.Enums;
using Epam.TestAutomation.Utils;
using NUnit.Framework;

namespace Epam.TestAutomation.Helper
{
    public static partial class TestSettings
    {
        public static TestContext TestContext { get; set; }

        #region RunSettingsMethods

        public static BrowserType Browser => EnumUtils.ParseEnum<BrowserType>(TestContext.Parameters.Get("Browser").ToString());

        public static string ScreenShotPath => TestContext.Parameters.Get("ScreenShotPath").ToString();

        public static string LogsPath => Path.Combine(TestContext.TestDirectory, @TestContext.Parameters.Get("LogsPath").ToString());

        public static TimeSpan WebDriverTimeOut => TimeSpan.FromSeconds(int.Parse(TestContext.Parameters.Get("WebDriverTimeOut").ToString()));

        public static string DefaultTimeOut => TestContext.Parameters.Get("WaitElementTimeOut").ToString();

        public static string ApplicationUrl => TestContext.Parameters.Get("ApplicationUrl").ToString();

        public static string DataDir => Path.Combine(Directory.GetCurrentDirectory(), TestContext.Parameters.Get("TestDataFolder").ToString());
        
        #endregion

    }
}
