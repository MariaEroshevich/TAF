
using Epam.TestAutomation.Elements;
using Epam.TestAutomation.Web.PageObjects.Panels;
using OpenQA.Selenium;

namespace Epam.TestAutomation.Web.PageObjects.Pages
{
    public class MainPage
    {
        public Label Header => new Label(By.XPath("//*[@class ='main-page-header_journey-header__1R0pX']"));

        public HeaderPanel HeaderPanel => new HeaderPanel(By.XPath("//*[@class ='header__content']"));

        public CookiePanel CookiePanel => new CookiePanel(By.Id("onetrust-banner-sdk"));

        public FooterPanel Footer => new(By.CssSelector(".footer-links"));

        public SearchPanel SearchPanel => new(By.CssSelector(".header-search__panel")); 
    }
}
