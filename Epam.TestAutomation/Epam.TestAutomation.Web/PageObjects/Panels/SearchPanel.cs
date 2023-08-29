using Epam.TestAutomation.Elements;
using OpenQA.Selenium;

namespace Epam.TestAutomation.Web.PageObjects.Panels
{
    public class SearchPanel : BaseElement
    {
        public SearchPanel(By locator) : base(locator) { }

        public TextInput SearchField => new(By.Id("new_form_search"));

        public Button FindButton => new(By.CssSelector("[class *='custom-button']"));
    }
}
