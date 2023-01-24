using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Epam.TestAutomation.API.Controllers;
using Epam.TestAutomation.API.Models.ResponseModels;
using NUnit.Framework;
using RestSharp;

namespace Epam.TestAutomation.API.Tests
{
    [TestFixture]
    public class BiblesTests
    {
        [Test]
        public void CheckAllBiblesResponseWithValidParams()
        {
            var response = new BiblesController(new CustomRestClient()).GetBibles<RestResponse>();
            Assert.That(response.Response.StatusCode, Is.EqualTo(HttpStatusCode.OK),
                "Invalid status code was returned while sending GET request to /v1/bibles!");
        }

        [Test]
        public void CheckAllBiblesResponseWithoutAuthorization()
        {
            var response = new BiblesController(new CustomRestClient(), string.Empty).GetBibles<RestResponse>();
            Assert.That(response.Response.StatusCode, Is.EqualTo(HttpStatusCode.Unauthorized),
                "Invalid status code was returned while sending GET request to /v1/bibles without authorization!");
        }

        [Test]
        public void CheckAllBiblesResponseReturnObject()
        {
            var response = new BiblesController(new CustomRestClient()).GetBibles<AllBiblesModel>();
            Assert.That(response.Bibles.data.Any, Is.True, "GET request to /v1/bibles should return any object!");
        }

        [Test]
        public void CheckSingleBibleResponseWithValidParams()
        {
            var bibles = new BiblesController(new CustomRestClient()).GetBibles<AllBiblesModel>().Bibles.data;

            var response = new BiblesController(new CustomRestClient()).GetBible<RestResponse>(bibles.First().id);
            
            Assert.That(response.Response.StatusCode, Is.EqualTo(HttpStatusCode.OK),
                "Invalid status code was returned while sending GET request to /v1/bibles{id}!");
        }
    }
}
