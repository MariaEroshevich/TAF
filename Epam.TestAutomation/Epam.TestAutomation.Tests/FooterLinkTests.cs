using Epam.TestAutomation.Core.Browser;
using Epam.TestAutomation.TestData.Models;
using Epam.TestAutomation.Utils;
using Epam.TestAutomation.Web.PageObjects.Pages;
using NUnit.Framework;
using ReportPortal.TestAutomation.Utilities.Parser;

namespace Epam.TestAutomation.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class FooterLinkTests : BaseTest
    {
        private MainPage _mainPage;
        private InformationPage _informationPage;

        private static List<string> _footerLinks = new List<string>()
        {
            "Investors",
            "Open Source",
            "Privacy Policy",
            "Cookie Policy",
            "Applicant Privacy Notice",
            "Web Accessibility"
        };

        [Test]
        [TestCaseSource(nameof(GetFooterLinks))]
        public void FooterLinksAreWorkingTest(FooterLinkModel linkName)
        {
            _mainPage = new MainPage();
            _informationPage = new InformationPage();

            Thread.Sleep(2000);
            _mainPage.AcceptAllCookiesButton.Click();
            BrowserFactory.Browser.ScrollToElement(_mainPage.FooterBlock.OriginalWebElement);
            _mainPage.FooterBlock.GetFooterLinkByName(linkName.FooterLink).Click();
            Waiters.WaitForCondition(() => _informationPage.Title.IsDisplayed());

            Assert.IsTrue(_informationPage.IsOpened(), "Information page doesn't open");
        }

        private static List<FooterLinkModel> GetFooterLinks()
        {
            return JsonParser.DeserializeJsonToObjects<FooterLinkModel>(@"C:\EPAM_Data\Tuition\TAF\Epam.TestAutomation\Epam.TestAutomation.TestData\FooterLinks.json").ToList();
        }
    }
}
