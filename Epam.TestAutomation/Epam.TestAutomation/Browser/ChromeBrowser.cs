using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Epam.TestAutomation.Core.Browser
{
    public class ChromeBrowser : IDriverFactory
    {
        public IWebDriver GetDriver()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--start-maximized");
            var service = ChromeDriverService.CreateDefaultService();
            var chromeDriver = new ChromeDriver(service, chromeOptions, TimeSpan.FromMinutes(3));
            return chromeDriver;
        }
    }
}
