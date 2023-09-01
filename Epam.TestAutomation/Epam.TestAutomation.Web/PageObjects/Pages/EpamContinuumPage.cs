using Epam.TestAutomation.Core.BasePage;
using Epam.TestAutomation.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.TestAutomation.Web.PageObjects.Pages
{
    public class EpamContinuumPage : BasePage
    {
        public override string URL => "https://www.epam.com/services/epam-continuum";

        public Label Title => new Label(By.XPath("//span[@class = 'rte-text-animation live-text']//*[@class = 'font-size-56']"));

        public override bool IsOpened()
        {
            return Title.IsDisplayed();
        }
    }
}
