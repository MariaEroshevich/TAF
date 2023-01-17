using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.TestAutomation.Utils;
using Epam.TestAutomation.Web.PageObjects.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Epam.TestAutomation.BDD.Steps.Pages
{
    [Binding]
    public class InvestorsPageSteps
    {
        private InvestorsPage InvestorsPage => new();

        [Then(@"I check that Investors page is opened")]
        public void ThenICheckThatInvestorsPageIsOpened()
        {
            Waiters.WaitForPageLoad();
            Assert.That(InvestorsPage.IsOpened(), Is.True, "Investors page should be opened!");
        }
    }
}
