using Epam.TestAutomation.Core.Browser;
using Epam.TestAutomation.Utilities.Logger;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Epam.TestAutomation.Tests.BDD.Steps.GeneralSteps
{
    [Binding]
    public class SetUpSteps
    {
        [BeforeFeature(Order = 1)]
        public static void SetUpLogger()
        {
            Logger.InitLogger(TestContext.CurrentContext.Test.Name, TestContext.CurrentContext.TestDirectory);
        }

        [BeforeScenario(Order = 1)]
        public static void SetUp()
        {
            Logger.Info("Test begins");
            BrowserFactory.Browser.Maximize();
        }
    }
}
