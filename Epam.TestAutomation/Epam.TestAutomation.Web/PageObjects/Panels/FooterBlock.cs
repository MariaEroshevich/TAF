using Epam.TestAutomation.Elements;
using OpenQA.Selenium;

namespace Epam.TestAutomation.Web.PageObjects.Panels
{
    public class FooterBlock : BasePanel
    {
        public FooterBlock(By locator) : base(locator) { }

        public Link EpamContinuumLinks => new Link(By.XPath("//*[@class='footer__brands-link']"));

        public ElementsList<Link> FooterLinks => new ElementsList<Link>(By.ClassName("footer__links-item"));

        public Link GetFooterLinkByName(string footerLinkName)
        {
            return FooterLinks.GetElements().Where(x => x.GetText().ToLower().Equals(footerLinkName.ToLower())).FirstOrDefault();
        }

        public void ClickOnLink(string linkName)
        {
            var link = GetFooterLinkByName(linkName);
            link.Click();
        }
    }
}
