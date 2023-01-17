using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.TestAutomation.Core.Browser;
using Epam.TestAutomation.Utils;
using Epam.TestAutomation.Web.PageObjects.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Epam.TestAutomation.BDD.Steps.Pages
{
    [Binding]
    public class LandingPageSteps
    {
        private MainPage LandingPage => new();

        [Given(@"I navigate to Landing Page of Epam site")]
        public void GivenINavigateToLandingPageOfEpamSite()
        {
            BrowserFactory.Browser.GotToUrl(LandingPage.Url);
            Waiters.WaitForPageLoad();
        }
    }
}
