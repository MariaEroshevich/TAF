using NUnit.Framework;
using System.Net;
using Epam.TestAutomation.API.Controllers;
using Epam.TestAutomation.API.Models.RequestModel;
using Epam.TestAutomation.API.Models.ResponseModels.Tech;
using Epam.TestAutomation.API.Models.SharedModels.Tech;

namespace Epam.TestAutomation.API.Tests
{
    [TestFixture]
    public class TechTests
    {
        [Test]
        public void VerifyTechResponse()
        {
            var response = new TechController(new CustomRestClient()).GetTechItems<List<TechItemSingleResponseModel>>();
            Assert.That(response.Response.StatusCode, Is.EqualTo(HttpStatusCode.OK), "Invalid status code data!");
        }

        [Test]
        public void VerifyAllTechItemsAreReturned()
        {
            var response = new TechController(new CustomRestClient()).GetTechItems<List<TechItemSingleResponseModel>>();
            Assert.That(response.TechModel?.Any(), Is.True, "Invalid data!");
        }

        [Test]
        public void VerifyAbilityToAddTechItem()
        {
            var techItem = new TechItemRequestModel()
            {
                name = "apple MacBook Pro 16",
                data = new TechData
                {
                    CpuModel = "Intel Core i9",
                    HardDiskSize = "1 TB",
                    Price = (float)1867.99,
                    Year = 2019
                }
            };

            var createdItem =
                new TechController(new CustomRestClient()).AddTechItem<TechItemCreatedResponseModel>(techItem)
                    .TechModel;

            var receivedItem = new TechController(new CustomRestClient()).GetSingleTechItem<TechItemSingleResponseModel>(createdItem.id).TechModel;

            Assert.That(receivedItem, Is.Not.Null, "Tech item was not created!");
        }
    }
}
