using Epam.TestAutomation.Helper;

namespace Epam.TestAutomation.Core.Browser
{
    public static class BrowserFactory
    {
        private static ThreadLocal<Browser> _browser;

        static BrowserFactory()
        {
            _browser = new ThreadLocal<Browser>(() => new Browser(DriverFactory.GetWebDriver(TestSettings.Browser)));
        }

        public static Browser Browser
        {
            get
            {
                _browser.Value = _browser.Value != null
                    ? _browser.Value
                    : new Browser(DriverFactory.GetWebDriver(TestSettings.Browser));
                return _browser.Value;
            }
        }

        public static void CloseBrowser()
        {
            _browser.Value.Quit();
            _browser.Value = null;
        }
    }
}
