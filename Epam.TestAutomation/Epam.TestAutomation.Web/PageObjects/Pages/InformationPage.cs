using Epam.TestAutomation.Core.BasePage;
using Epam.TestAutomation.Elements;
using OpenQA.Selenium;

namespace Epam.TestAutomation.Web.PageObjects.Pages
{
    public class InformationPage : BasePage
    {
        public override string URL => "https://www.epam.com/about";

        public Label Title => new Label(By.TagName("h1"));

        public override bool IsOpened()
        {
            return Title.IsDisplayed();
        }
    }
}
