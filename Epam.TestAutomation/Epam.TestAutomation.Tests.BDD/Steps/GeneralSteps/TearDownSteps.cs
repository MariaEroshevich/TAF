using Epam.TestAutomation.Core.Browser;
using Epam.TestAutomation.Helper;
using Epam.TestAutomation.Utilities.Logger;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Epam.TestAutomation.Tests.BDD.Steps.GeneralSteps
{
    [Binding]
    public class TearDownSteps
    {
        [AfterScenario]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                Logger.Info("Test failed!");

                BrowserFactory.Browser.SaveScreenshoot(TestContext.CurrentContext.Test.MethodName,
                    Path.Combine(TestContext.CurrentContext.TestDirectory, TestSettings.ScreenShotPath));
            }

            Logger.Info("Test finished!");
            BrowserFactory.Browser.Quit();
        }
    }
}
