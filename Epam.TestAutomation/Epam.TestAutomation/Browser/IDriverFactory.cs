using OpenQA.Selenium;

namespace Epam.TestAutomation.Core.Browser
{
    public interface IDriverFactory
    {
        public IWebDriver GetDriver();
    }
}
