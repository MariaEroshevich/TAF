using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.TestAutomation.Core.Browser;
using Epam.TestAutomation.Helper;
using Epam.TestAutomation.Utilities.Logger;
using Epam.TestAutomation.Utils;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Epam.TestAutomation.BDD.Steps.GeneralSteps
{
    [Binding]
    public class SetupSteps
    {
        [BeforeFeature(Order = 1)]
        public static void OneTimeSetUp()
        {
            Logger.InitLogger(TestContext.CurrentContext.Test.Name, TestContext.CurrentContext.TestDirectory);

        }

        [BeforeScenario()]
        public static void BeforeTest()
        {
            Logger.Info("Test begin");
            BrowserFactory.Browser.Maximize();
        }
    }
}
