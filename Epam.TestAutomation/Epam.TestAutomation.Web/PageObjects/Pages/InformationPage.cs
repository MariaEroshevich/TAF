using Epam.TestAutomation.Elements;
using OpenQA.Selenium;

namespace Epam.TestAutomation.Web.PageObjects.Pages
{
    public class InformationPage
    {
        public Label Header => new(By.XPath("//p[@class='scaling-of-text-wrapper']"));
    }
}
