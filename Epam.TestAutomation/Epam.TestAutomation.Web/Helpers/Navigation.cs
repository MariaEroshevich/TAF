
using Epam.TestAutomation.Core.BasePage;

namespace ReportPortal.TestAutomation.Web.Helper
{
    public static class Navigation
    {
        public static TPage GetPage<TPage>() where TPage : BasePage
        {
            var pageInstans = (TPage)Activator.CreateInstance(typeof(TPage));
            return pageInstans;
        }
    }
}
