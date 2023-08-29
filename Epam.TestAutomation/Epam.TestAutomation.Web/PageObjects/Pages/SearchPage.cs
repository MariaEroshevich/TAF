using Epam.TestAutomation.Elements;
using OpenQA.Selenium;

namespace Epam.TestAutomation.Web.PageObjects.Pages
{
    public class SearchPage
    {
        public ElementsList<Link> ArticlesLinks => new(By.CssSelector("article a"));
    }
}