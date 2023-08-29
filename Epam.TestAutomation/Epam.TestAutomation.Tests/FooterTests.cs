using Epam.TestAutomation.Core.Browser;
using Epam.TestAutomation.TestData;
using Epam.TestAutomation.TestData.Models;
using Epam.TestAutomation.Utils;
using Epam.TestAutomation.Web.PageObjects.Pages;
using NUnit.Framework;
using System.Linq;
using System.Security.Policy;

namespace Epam.TestAutomation.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class FooterTests : BaseTest
    {
        private MainPage _mainPage;

        private static List<FooterLinkModel> _footerPages = new List<FooterLinkModel>()
        {
            new FooterLinkModel
            {
                FooterLink = "EPAM CONTINUUM",
                Url = "/services/epam-continuum"
            },
            new FooterLinkModel
            {
                FooterLink = "INVESTORS",
                Url = "/investors"
            },
            new FooterLinkModel
            {
                FooterLink = "OPEN SOURCE",
                Url = "/services/engineering/open-source"
            }
        };

        [SetUp]
        public void Setup()
        {
            _mainPage = new MainPage();
        }

        [Test]
        [TestCase("EPAM CONTINUUM", "/services/epam-continuum")]
        [TestCase("INVESTORS", "/investors")]
        [TestCase("OPEN SOURCE", "/services/engineering/open-source")]
        [TestCase("COOKIE POLICY", "/cookie-policy")]
        [TestCase("APPLICANT PRIVACY NOTICE", "/applicant-privacy-notice")]
        [TestCase("WEB ACCESSIBILITY", "/web-accessibility-statement")]
        public void FooterTest(string footerLinkName, string url)
        {
            var footerLink = _mainPage.Footer.GetFooterLinkByName(footerLinkName);
            footerLink.Click();
            Waiters.WaitForPageLoad(TimeSpan.FromSeconds(10));

            Assert.IsTrue(BrowserFactory.Browser.GetUrl().Contains(url), $"Site doesn't navigate to {url}");
        }

        [Test]
        [TestCaseSource(nameof(_footerPages))]
        public void FooterTestVersion2(FooterLinkModel footerPage)
        {
            var footerLink = _mainPage.Footer.GetFooterLinkByName(footerPage.FooterLink);
            footerLink.Click();
            Waiters.WaitForPageLoad(TimeSpan.FromSeconds(10));

            Assert.IsTrue(BrowserFactory.Browser.GetUrl().Contains(footerPage.Url), $"Site doesn't navigate to {footerPage.Url}");
        }

        [Test]
        [TestCaseSource(typeof(FooterTestData), nameof(FooterTestData.GetFooterLinks))]
        public void FooterTestVersion3(FooterLinkModel footerPage)
        {
            var footerLink = _mainPage.Footer.GetFooterLinkByName(footerPage.FooterLink);
            footerLink.Click();
            Waiters.WaitForPageLoad(TimeSpan.FromSeconds(10));

            Assert.IsTrue(BrowserFactory.Browser.GetUrl().Contains(footerPage.Url), $"Site doesn't navigate to {footerPage.Url}");
        }
    }
}
