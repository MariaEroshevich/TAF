using System.Collections.ObjectModel;
using Epam.TestAutomation.Core.Browser;
using Epam.TestAutomation.Elements;
using OpenQA.Selenium;

namespace Epam.TestAutomation.Core.BasePage
{
    public abstract class BasePage
    {
        public Button AcceptAllCookiesButton => new Button(By.Id("onetrust-accept-btn-handler"));

        public abstract bool IsOpened();

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
