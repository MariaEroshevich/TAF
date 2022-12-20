//using Epam.TestAutomation.Web.PageObjects.Pages;
//using NUnit.Framework;

//namespace ReportPortal.TestAutomation.Tests
//{
//    [TestFixture]
//    public class LoginTests : BaseTest
//    {
//        private LoginPage _loginPage;

//        [SetUp]
//        public void GetPage()
//        {
//            _loginPage = Navigation.GetPage<LoginPage>();
//        }

//        [Test]
//        public void LoginTest()
//        {
//            var user = new UserModel
//            {
//                UserName = "default",
//                Password = "1q2w3e"
//            };

//            var dashboarsPage = _loginPage.Login(user);
//            Assert.AreEqual("ALL DASHBOARDS", dashboarsPage.Label.GetText());
//        }
//    }
//}
