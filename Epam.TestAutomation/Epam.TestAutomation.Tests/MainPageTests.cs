using Epam.TestAutomation.Web.PageObjects.Pages;
using Epam.TestAutomation.Web.Steps;
using NUnit.Framework;

namespace Epam.TestAutomation.Tests
{
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class MainPageTests : BaseTest
    {
        [Test]
        public void MainPageIsOpenTest()
        {
            var header = _mainPageSteps.GetHeaderText();

            Assert.AreEqual("Start your IT journey with us", header);
        }
    }
}