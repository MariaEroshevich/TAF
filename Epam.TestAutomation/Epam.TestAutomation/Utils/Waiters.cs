using Epam.TestAutomation.Core.Browser;
using OpenQA.Selenium;

namespace Epam.TestAutomation.Utils
{
    public static class Waiters
    {
        public static void WaitForPageLoad(TimeSpan wait) => BrowserFactory.Browser.Waiters(wait).Until(condition => BrowserFactory.Browser.ExecuteScript("return document.readyState").Equals("complete"));
        
        public static void WaitForCondition(Func<bool> condition, TimeSpan wait) => BrowserFactory.Browser.Waiters(wait).Until(x => condition.Invoke());

        public static void WaitSpinner(TimeSpan wait)
        {
            BrowserFactory.Browser.Waiters(wait).Until(x => !BrowserFactory.Browser.FindElement(By.XPath("//div[contains(@class,'grid__spinner')]")).Displayed);
        }
    }
}
