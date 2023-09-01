using Epam.TestAutomation.Web.PageObjects.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Epam.TestAutomation.Tests.BDD.Steps.ComponentsSteps
{
    [Binding]
    public class CookieBannerSteps
    {
        private MainPage _langingPage = new();

        [Given(@"I accept all cookies on Epam site")]
        public void GivenIAcceptAllCookiesOnEpamSite()
        {
            _langingPage.AcceptAllCookies();
        }
    }
}
