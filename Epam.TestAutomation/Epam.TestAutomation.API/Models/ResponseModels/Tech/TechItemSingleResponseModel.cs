using Epam.TestAutomation.API.Models.SharedModels.Tech;

namespace Epam.TestAutomation.API.Models.ResponseModels.Tech
{
    public class TechItemSingleResponseModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public TechData? data { get; set; }
    }
}
