using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Epam.TestAutomation.Web.PageObjects.Pages;
using TechTalk.SpecFlow;

namespace Epam.TestAutomation.BDD.Steps.SharedComponents
{
    [Binding]
    public class CookieBannerSteps
    {
        private MainPage LandingPage => new();

        [Given(@"I accept all cookies on Epam Site")]
        public void GivenIAcceptAllCookiesOnEpamSite()
        {
            Thread.Sleep(3000);
            LandingPage.AcceptAllCookies();
        }
    }
}
