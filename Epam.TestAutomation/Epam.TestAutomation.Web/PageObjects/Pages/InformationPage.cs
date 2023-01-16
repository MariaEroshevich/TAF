using Epam.TestAutomation.Core.BasePage;
using Epam.TestAutomation.Elements;
using OpenQA.Selenium;

namespace Epam.TestAutomation.Web.PageObjects.Pages
{
    public class InformationPage : BasePage
    {
        public override string Url => "https://www.epam.com/search";

        public Label Title => new Label(By.TagName("h1"));
    }
}
