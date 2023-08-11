using Epam.TestAutomation.Elements;
using OpenQA.Selenium;

namespace Epam.TestAutomation.Web.PageObjects.Panels
{
    public class CookiePanel : BaseElement
    {
        public CookiePanel(By locator) : base(locator) { }

        public Button AcceptAllButton => new Button(By.Id("onetrust-accept-btn-handler"));
    }
}
