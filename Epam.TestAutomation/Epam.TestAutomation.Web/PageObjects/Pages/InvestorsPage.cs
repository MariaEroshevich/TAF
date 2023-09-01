using Epam.TestAutomation.Core.BasePage;
using Epam.TestAutomation.Core.Browser;

namespace Epam.TestAutomation.Web.PageObjects.Pages
{
    public class InvestorsPage : BasePage
    {
        public override string URL => "https://investors.epam.com/investors";

        public override bool IsOpened()
        {
            return BrowserFactory.Browser.Url.Equals(URL);
        }
    }
}