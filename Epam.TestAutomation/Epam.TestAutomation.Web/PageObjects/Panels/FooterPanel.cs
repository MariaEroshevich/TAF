using Epam.TestAutomation.Elements;
using OpenQA.Selenium;

namespace Epam.TestAutomation.Web.PageObjects.Panels
{
    public class FooterPanel : BaseElement
    {
        public FooterPanel(By locator) : base(locator) { }

        public ElementsList<Link> FooterLinks => new ElementsList<Link>(By.TagName("li"));

        public Link GetFooterLinkByName(string linkName) => FooterLinks.GetElements().FirstOrDefault(x => x.GetText().ToLower().Equals(linkName.ToLower()));
    }
}
