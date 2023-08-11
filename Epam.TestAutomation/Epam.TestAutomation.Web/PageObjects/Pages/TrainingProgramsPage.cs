using Epam.TestAutomation.Elements;
using OpenQA.Selenium;

namespace Epam.TestAutomation.Web.PageObjects.Pages
{
    public class TrainingProgramsPage
    {
        public Label Header => new Label(By.CssSelector("[class*='training-catalog_header']"));
    }
}
