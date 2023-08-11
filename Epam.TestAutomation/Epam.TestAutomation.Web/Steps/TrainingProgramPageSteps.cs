using Epam.TestAutomation.Utils;
using Epam.TestAutomation.Web.PageObjects.Pages;

namespace Epam.TestAutomation.Web.Steps
{
    public class TrainingProgramPageSteps
    {
        private TrainingProgramsPage _trainingProgramPage;

        public TrainingProgramPageSteps()
        {
            _trainingProgramPage = new TrainingProgramsPage();
        }

        public string GetHeader()
        {
            Waiters.WaitForCondition(() => _trainingProgramPage.Header.IsDisplayed(), TimeSpan.FromSeconds(10));
            return _trainingProgramPage.Header.GetText();
        }
    }
}
