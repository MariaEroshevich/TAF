using Epam.TestAutomation.Web.PageObjects.Pages;
using Epam.TestAutomation.Web.Steps;
using NUnit.Framework;

namespace Epam.TestAutomation.Tests
{
    [TestFixture]
    public class TrainingProgramsTests : BaseTest
    {
        private MainPageSteps _mainPage = new MainPageSteps();
        private TrainingProgramPageSteps _trainingProgramPageSteps = new TrainingProgramPageSteps();

        [Test]
        public void TrainingProgramsPageIsOpenTest()
        {
            _mainPage.NavigateByName("Programs");

            Assert.AreEqual("Training programs", _trainingProgramPageSteps.GetHeader());
        }
    }
}