using System.Collections.ObjectModel;
using Epam.TestAutomation.Core.Browser;
using Epam.TestAutomation.Elements;
using Epam.TestAutomation.Utils;
using OpenQA.Selenium;

namespace Epam.TestAutomation.Core.BasePage
{
    public abstract class BasePage
    {
        private Button AcceptAllCookiesButton => new Button(By.Id("onetrust-accept-btn-handler"));

        public abstract string URL { get; }

        public abstract bool IsOpened();

        public IWebElement FindElement(By by)
        {
            return BrowserFactory.Browser.FindElement(by);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return BrowserFactory.Browser.FindElements(by);
        }

        public void AcceptAllCookies()
        {
            Waiters.WaitForCondition(() => AcceptAllCookiesButton.IsDisplayed());
            AcceptAllCookiesButton.Click();
        }

    }
}
