
using OpenQA.Selenium;

namespace Epam.TestAutomation.Elements
{
    public class Label : BaseElement
    {
        public Label(By locator) : base(locator)
        {
        }

        public Label(IWebElement element) : base(element)
        {

        }
    }
}
