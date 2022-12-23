using Epam.TestAutomation.Core.Browser;
using Epam.TestAutomation.Utils;
using Epam.TestAutomation.Web.PageObjects.Pages;
using NUnit.Framework;

namespace Epam.TestAutomation.Tests
{
    public class MainPageTests : BaseTest
    {
        private MainPage _mainPage;

        [SetUp]
        public void SetUp()
        {
            _mainPage = new MainPage();
        }

        [Test]
        public void MainPageIsOpenedTest()
        {
            Assert.IsTrue(_mainPage.Title.IsDisplayed(), "Page doesn't open");
        }

        [Test]
        public void EpamContimuumPageIsOpenedTest()
        {
            var epamContinuumPage = new EpamContinuumPage();

            BrowserFactory.Browser.ScrollToElement(_mainPage.FooterBlock.OriginalWebElement);
            _mainPage.FooterBlock.EpamContinuumLinks.Click();

            epamContinuumPage.AcceptAllCookiesButton.Click();
            Waiters.WaitForCondition(() => epamContinuumPage.Title.IsDisplayed());

            Assert.IsTrue(epamContinuumPage.IsOpened());
        }
    }
}
