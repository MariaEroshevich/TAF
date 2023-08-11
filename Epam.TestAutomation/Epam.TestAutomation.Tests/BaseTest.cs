using Epam.TestAutomation.Core.Browser;
using Epam.TestAutomation.Helper;
using Epam.TestAutomation.Utilities.Logger;
using Epam.TestAutomation.Utils;
using Epam.TestAutomation.Web.Steps;
using NUnit.Framework;

namespace Epam.TestAutomation.Tests
{
    public abstract class BaseTest
    {
        protected MainPageSteps _mainPageSteps;
        public TestContext TestContext { get; set; }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Logger.InitLogger(TestContext.CurrentContext.Test.Name, TestContext.CurrentContext.TestDirectory);
        }

        [SetUp]
        public virtual void BeforeTest()
        {
            _mainPageSteps = new MainPageSteps();
            Logger.Info("Test begin");
            BrowserFactory.Browser.GotToUrl(TestSettings.ApplicationUrl);
            Waiters.WaitForPageLoad(TimeSpan.FromSeconds(10));
            _mainPageSteps.AcceptAllCookie();
        }

        [TearDown]
        public virtual void CleanTest()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                Logger.Info("Test is failed");
                BrowserFactory.Browser.SaveScreenshoot(TestContext.CurrentContext.Test.MethodName, 
                    Path.Combine(TestContext.CurrentContext.TestDirectory, TestSettings.ScreenShotPath));
            }
            Logger.Info("Test finish");
            BrowserFactory.Browser.Quit();
        }
    }
}