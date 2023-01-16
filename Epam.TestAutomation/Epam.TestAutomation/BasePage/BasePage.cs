using Epam.TestAutomation.Core.Browser;
using Epam.TestAutomation.Elements;
using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace Epam.TestAutomation.Core.BasePage
{
    public abstract class BasePage
    {
        public abstract string Url { get; }

        public Button AcceptAllCookiesButton => new Button(By.XPath("//*[@id = 'onetrust-accept-btn-handler']"));

        public bool IsOpened()
        {
            return BrowserFactory.Browser.GetUrl().Equals(Url);
        }

        public void AcceptAllCookies()
        {
            AcceptAllCookiesButton.Click();
        }

        public IWebElement FindElement(By by)
        {
            return BrowserFactory.Browser.FindElement(by);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return BrowserFactory.Browser.FindElements(by);
        }

    }
}
