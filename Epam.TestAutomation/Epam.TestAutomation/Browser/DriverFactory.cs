using Epam.TestAutomation.Enums;
using OpenQA.Selenium;

namespace Epam.TestAutomation.Core.Browser
{
    public static class DriverFactory
    {
        public static IWebDriver GetWebDriver(BrowserType browser)
        {
            IWebDriver createdWebDriver;
            switch (browser)
            {
                case BrowserType.Chrome:
                    createdWebDriver = new ChromeBrowser().GetDriver();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(browser));
            }

            return createdWebDriver;
        }
    }
}
