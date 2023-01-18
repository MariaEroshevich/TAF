using System.IO;
using Epam.TestAutomation.Core.Browser;
using Epam.TestAutomation.Helper;
using Epam.TestAutomation.Utilities.Logger;
using Epam.TestAutomation.Utils;
using NUnit.Framework;

namespace Epam.TestAutomation.Tests
{
    public abstract class BaseTest
    {
        public TestContext TestContext { get; set; }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Logger.InitLogger(TestContext.CurrentContext.Test.Name, TestContext.CurrentContext.TestDirectory);

        }

        [SetUp]
        public virtual void BeforeTest()
        {
            Logger.Info("Test begin");
            BrowserFactory.Browser.GotToUrl(TestSettings.ApplicationUrl);
            BrowserFactory.Browser.Refresh();
            Waiters.WaitForPageLoad();
        }

        [TearDown]
        public virtual void CleanTest()
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
