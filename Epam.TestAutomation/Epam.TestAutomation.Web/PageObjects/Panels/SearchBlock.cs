using Epam.TestAutomation.Elements;
using OpenQA.Selenium;

namespace Epam.TestAutomation.Web.PageObjects.Panels
{
    public class SearchBlock : BasePanel
    {
        public TextInput SearchInput => new TextInput(By.Id("new_form_search"));

        public Button FindButton => new Button(By.ClassName("header-search__submit"));

        public SearchBlock(By locator) : base(locator) { }
    }
}
