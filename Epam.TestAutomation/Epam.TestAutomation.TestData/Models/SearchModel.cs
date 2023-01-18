using System.Text.Json.Serialization;

namespace Epam.TestAutomation.TestData.Models
{
    public class SearchModel
    {
        [JsonPropertyName("SearchPhrase")]
        public string SearchPhrase;

        [JsonPropertyName("SearchResult")]
        public string SearchResult;

        [JsonPropertyName("InformationPageTitle")]
        public string InformationPageTitle;
    }
}
