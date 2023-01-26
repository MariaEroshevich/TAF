using Epam.TestAutomation.Web.PageObjects.Pages;
using NUnit.Framework;

namespace Epam.TestAutomation.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
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
    }
}
