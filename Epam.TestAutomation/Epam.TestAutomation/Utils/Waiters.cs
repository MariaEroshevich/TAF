using Epam.TestAutomation.Core.Browser;
using OpenQA.Selenium;

namespace Epam.TestAutomation.Utils
{
    public static class Waiters
    {
        public static void WaitForPageLoad() => BrowserFactory.Browser.Waiters().Until(condition => BrowserFactory.Browser.ExecuteScript("return document.readyState").Equals("complete"));
        
        public static void WaitForCondition(Func<bool> condition) => BrowserFactory.Browser.Waiters().Until(x => condition.Invoke());

        public static void WaitSpinner()
        {
            BrowserFactory.Browser.Waiters().Until(x => !BrowserFactory.Browser.FindElement(By.XPath("//div[contains(@class,'grid__spinner')]")).Displayed);
        }
    }
}
