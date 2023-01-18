using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.TestAutomation.Core.Browser;
using Epam.TestAutomation.Helper;
using Epam.TestAutomation.Utilities.Logger;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Epam.TestAutomation.BDD.Steps.GeneralSteps
{
    [Binding]
    public class TearDownSteps
    {
        [AfterScenario()]
        public static void CleanTest()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                Logger.Info("Test is failed");
                BrowserFactory.Browser.SaveScreenshoot(TestContext.CurrentContext.Test.MethodName, Path.Combine(TestContext.CurrentContext.TestDirectory, TestSettings.ScreenShotPath));
            }
            Logger.Info("Test finish");
            BrowserFactory.Browser.Quit();
        }
    }
}
