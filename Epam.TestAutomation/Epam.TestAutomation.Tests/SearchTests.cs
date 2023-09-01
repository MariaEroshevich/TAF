using Epam.TestAutomation.Helper;
using Epam.TestAutomation.TestData.Models;
using Epam.TestAutomation.Utils;
using Epam.TestAutomation.Web.PageObjects.Pages;
using NUnit.Framework;
using ReportPortal.TestAutomation.Utilities.Parser;

namespace Epam.TestAutomation.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class SearchTests : BaseTest
    {
        private MainPage _mainPage;
        private SearchResultsPage _searchResultsPage;
        private InformationPage _informationPage;

        [SetUp]
        public void SetUp()
        {
            _mainPage = new MainPage();
            _searchResultsPage = new SearchResultsPage();
            _informationPage = new InformationPage();
        }

        [TestCaseSource((nameof(GetSearcInformation)))]
        public void InformationPageIsOpened(SearchModel search)
        {
            Thread.Sleep(2000);
            _mainPage.AcceptAllCookies();

            _mainPage.HeaderBlock.SearchButton.Click();
            _mainPage.HeaderBlock.SearchBlock.SearchInput.SendKeys(search.SearchPhrase);
            _mainPage.HeaderBlock.SearchBlock.FindButton.Click();

            Waiters.WaitForCondition(() => _searchResultsPage.SearchResultLinks.GetElements().Any(x => x.IsDisplayed()));
            _searchResultsPage.GetSearchResultLinkByName(search.SearchResult).Click();

            Waiters.WaitForCondition(() => _informationPage.Title.IsDisplayed());

            Assert.AreEqual(search.InformationPageTitle, _informationPage.Title.GetText(), 
                $"Information page {_informationPage.Title.GetText()} title doesn't equal to {search.InformationPageTitle}");
        }

        private static List<SearchModel> GetSearcInformation()
        {
            return JsonParser.DeserializeJsonToObjects<SearchModel>(File.ReadAllText($"{TestSettings.DataDir}\\Search.json"));
        }
    }
}
