using OpenQA.Selenium;

namespace Epam.TestAutomation.Elements
{
    public class BasePanel : BaseElement
    {
        public BasePanel(By locator) : base(locator)
        {

        }

        public BasePanel(IWebElement element) : base(element)
        {

        }
    }
}
