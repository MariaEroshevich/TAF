using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.TestAutomation.Core.Browser;
using Epam.TestAutomation.Utils;
using Epam.TestAutomation.Web.PageObjects.Pages;
using TechTalk.SpecFlow;

namespace Epam.TestAutomation.Tests.BDD.Steps.PagesSteps
{
    [Binding]
    public class LandingPageSteps
    {
        private MainPage _langingPage = new();

        [Given(@"I navigate to Landing page of Epam site")]
        public void GivenINavigateToLandingPageOfEpamSite()
        {
            BrowserFactory.Browser.GotToUrl(_langingPage.URL);
            Waiters.WaitForPageLoad();
        }

    }
}
