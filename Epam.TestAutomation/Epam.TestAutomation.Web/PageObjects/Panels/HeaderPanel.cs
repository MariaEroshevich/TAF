using Epam.TestAutomation.Elements;
using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace Epam.TestAutomation.Web.PageObjects.Panels
{
    public class HeaderPanel : BaseElement
    {
        public HeaderPanel(By locator) : base(locator) { }

        public ReadOnlyCollection<IWebElement> NavigationMenuItems => FindElements(By.CssSelector("[class*='nav-bar_menu-items']"));

        public Button SearchButton => new Button(By.CssSelector(".search-icon"));
    }
}