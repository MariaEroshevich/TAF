using Epam.TestAutomation.Core.Browser;
using Epam.TestAutomation.Utils;
using Epam.TestAutomation.Web.PageObjects.Pages;
using NUnit.Framework;

namespace Epam.TestAutomation.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class ConsultAndDesignPageTests : BaseTest
    {
        private MainPage _mainPage;
        private EpamContinuumPage _continuumPage;

        [SetUp]
        public void SetUp()
        {
            _mainPage = new MainPage();
            _continuumPage = new EpamContinuumPage();
        }

        [Test]
        public void EpamContimuumPageIsOpenedTest()
        {
            Thread.Sleep(2000);
            _mainPage.AcceptAllCookiesButton.Click();

            BrowserFactory.Browser.ScrollToElement(_mainPage.FooterBlock.OriginalWebElement);
            _mainPage.FooterBlock.EpamContinuumLinks.Click();

            BrowserFactory.Browser.ScrollBy(500);
            Waiters.WaitForCondition(() => _continuumPage.Title.IsDisplayed());

            Assert.IsTrue(_continuumPage.IsOpened());
        }
    }
}
