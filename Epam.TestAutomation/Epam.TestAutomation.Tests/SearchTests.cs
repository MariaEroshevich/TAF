using Epam.TestAutomation.Helper;
using Epam.TestAutomation.TestData.Models;
using Epam.TestAutomation.Utilities.Parser;
using Epam.TestAutomation.Utils;
using Epam.TestAutomation.Web.PageObjects.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.TestAutomation.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class SearchTests : BaseTest
    {
        private MainPage _mainPage;
        private SearchPage _searchPage;
        private InformationPage _informationPage;

        [SetUp]
        public void Setup()
        {
            _mainPage = new MainPage();
            _searchPage = new SearchPage();
            _informationPage = new InformationPage();
        }

        [Test]
        [TestCaseSource(nameof(GetSearchTestData))]
        public void InformationPageDisplayedTest(SearchModel searchModel)
        {
            _mainPage.HeaderPanel.SearchButton.Click();
            _mainPage.SearchPanel.SearchField.SendKeys(searchModel.SearchPhrase);
            _mainPage.SearchPanel.FindButton.Click();

            var articleLink = _searchPage.ArticlesLinks.GetElements().FirstOrDefault(x => x.GetText().ToLower().Equals(searchModel.SearchResult.ToLower()));
            articleLink.Click();

            Waiters.WaitForCondition(() => _informationPage.Header.IsDisplayed(), TimeSpan.FromSeconds(10));

            Assert.AreEqual(_informationPage.Header.GetText(), searchModel.InformationPageTitle, $"Page with {searchModel.InformationPageTitle} header is not open");
        }

        private static List<SearchModel> GetSearchTestData()
        {
            var json = File.ReadAllText(Path.Combine(TestSettings.DataDir, @"Search.json"));
            return JsonParser.DeserializeJsonToObjects<SearchModel>(json);
        }
    }
}