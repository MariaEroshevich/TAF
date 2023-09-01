using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.TestAutomation.Web.PageObjects.Pages;
using Epam.TestAutomation.Web.PageObjects.Panels;
using TechTalk.SpecFlow;

namespace Epam.TestAutomation.Tests.BDD.Steps.ComponentsSteps
{
    [Binding]
    public class FooterSteps
    {
        private FooterBlock _footer => new MainPage().FooterBlock;

        [When(@"I click on '([^']*)' link on Footer on Epam site")]
        public void WhenIClickOnLinkOnFooterOnEpamSite(string linkName)
        {
            _footer.GetFooterLinkByName(linkName).Click();
        }

    }
}
