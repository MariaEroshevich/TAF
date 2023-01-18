using Epam.TestAutomation.Core.Browser;
using OpenQA.Selenium.Interactions;

namespace Epam.TestAutomation.Elements
{
    public static class WebElementExtention
    {
        public static bool IsElementOnView(this BaseElement element)
        {
            var script = "var elem = arguments[0],                 " +
                         "  box = elem.getBoundingClientRect(),    " +
                         "  cx = box.left + box.width / 2,         " +
                         "  cy = box.top + box.height / 2,         " +
                         "  e = document.elementFromPoint(cx, cy); " +
                         "for (; e; e = e.parentElement) {         " +
                         "  if (e === elem)                        " +
                         "    return true;                         " +
                         "}                                        " +
                         "return false;                            ";
            return (bool)BrowserFactory.Browser.ExecuteScript(script, element.OriginalWebElement);
        }


        public static void ClickUsingJS(this BaseElement element)
        {
            BrowserFactory.Browser.ExecuteScript("arguments[0].click()", element.OriginalWebElement);
        }

        public static void DragAndDrop(this BaseElement element, BaseElement targetElement)
        {
            CreateAction().DragAndDrop(element.OriginalWebElement, targetElement.OriginalWebElement).Perform();
        }

        public static void DragAndDropToOffset(this BaseElement element, int offsetX, int offsetY)
        {
            CreateAction().DragAndDropToOffset(element.OriginalWebElement, offsetX, offsetY).Perform();
        }

        private static Actions CreateAction()
        {
            return BrowserFactory.Browser.Action;
        }
    }
}
