using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.TestAutomation.Core.Browser;
using Epam.TestAutomation.Web.PageObjects.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Epam.TestAutomation.Tests.BDD.Steps.PagesSteps
{
    [Binding]
    public class InvestorsPageSteps
    {
        private InvestorsPage _investorsPage => new();

        [Then(@"I check that Investors page is opened")]
        public void ThenICheckThatInvestorsPageIsOpened()
        {
            Assert.That(_investorsPage.IsOpened(), Is.True, $"Investors page should be opened! Expected {_investorsPage.URL} but was {BrowserFactory.Browser.Url}!");
        }

    }
}
