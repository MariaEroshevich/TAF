using Epam.TestAutomation.Elements;
using OpenQA.Selenium;

namespace Epam.TestAutomation.Web.PageObjects.Panels
{
    public class FooterBlock : BasePanel
    {
        public FooterBlock(By locator) : base(locator) { }

        public Link EpamContinuumLinks => new Link(By.XPath("//*[@class='footer__brands-link']"));
    }
}
