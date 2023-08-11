using Epam.TestAutomation.Utils;
using Epam.TestAutomation.Web.PageObjects.Pages;

namespace Epam.TestAutomation.Web.Steps
{
    public class MainPageSteps
    {
        private MainPage _mainPage;

        public MainPageSteps()
        {
            _mainPage = new MainPage();
        }

        public string GetHeaderText()
        {
            return _mainPage.Header.GetText().Replace("\r\n", " ");
        }

        public void NavigateByName(string name)
        {
            _mainPage.HeaderPanel.NavigationMenuItems.FirstOrDefault(x => x.Text.Equals(name)).Click();
        }

        public void AcceptAllCookie()
        {
            Waiters.WaitForCondition(() => _mainPage.CookiePanel.AcceptAllButton.IsDisplayed(), TimeSpan.FromSeconds(10));
            _mainPage.CookiePanel.AcceptAllButton.Click();
            Waiters.WaitForCondition(() => !_mainPage.CookiePanel.AcceptAllButton.IsDisplayed(), TimeSpan.FromSeconds(10));
        }
    }
}