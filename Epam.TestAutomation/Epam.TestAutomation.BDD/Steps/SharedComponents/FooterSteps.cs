using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.TestAutomation.Web.PageObjects.Pages;
using Epam.TestAutomation.Web.PageObjects.Panels;
using TechTalk.SpecFlow;

namespace Epam.TestAutomation.BDD.Steps.SharedComponents
{
    [Binding]
    public class FooterSteps
    {
        private FooterBlock Footer => new MainPage().FooterBlock;

        [When(@"I click '([^']*)' link on Footer of Epam site")]
        public void WhenIClickLinkOnFooterOfEpamSite(string link)
        {
            Footer.ClickOnLink(link);
        }
    }
}
