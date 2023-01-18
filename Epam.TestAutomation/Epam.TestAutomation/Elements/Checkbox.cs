using OpenQA.Selenium;

namespace Epam.TestAutomation.Elements
{
    public class Checkbox : BaseElement
    {
        public Checkbox(By locator) : base(locator)
        {

        }

        public Checkbox(IWebElement element) : base(element)
        {

        }
    }
}
