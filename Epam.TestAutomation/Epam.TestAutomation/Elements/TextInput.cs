using OpenQA.Selenium;

namespace Epam.TestAutomation.Elements
{
    public class TextInput : BaseElement
    {
        public TextInput(By element) : base(element)
        {
        }

        public TextInput(IWebElement element) : base(element)
        {

        }

    }
}
