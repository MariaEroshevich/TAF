using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Epam.TestAutomation.API.Controllers;
using Epam.TestAutomation.API.Models.RequesModels.Phone;
using Epam.TestAutomation.API.Models.ResponseModels.Phone;
using Epam.TestAutomation.API.Models.SharedMoels.Phone;
using NUnit.Framework;

namespace Epam.TestAutomation.API.Tests
{
    [TestFixture]
    public class PhoneTests
    {
        [Test]
        public void VerifyAllPhonesResponse()
        {
            var response = new PhoneController(new CustomRestClient()).GetPhones<List<Phone>>();
            Assert.That(response.Response.StatusCode, Is.EqualTo(HttpStatusCode.OK), "Invalid status code for GET /objects request!");
        }

        [Test]
        public void VerifySinglePhoneResponse()
        {
            var phone = new PhoneController(new CustomRestClient()).GetPhones<List<Phone>>().AllPhones.First();

            var response = new PhoneController(new CustomRestClient()).GetPhone<Phone>(phone.id);
            Assert.That(response.Response.StatusCode, Is.EqualTo(HttpStatusCode.OK), "Invalid status code for GET /objects/{id} request!");
        }

        [Test]
        public void VerifyAbilityToAddPhone()
        {
            var phoneToCreate = new PhoneModel
            {
                name = "Samsung Galaxy A70",
                data = new PhoneData
                {
                    price = 170,
                    year = 2019
                }
            };

            var createdPhone = new PhoneController(new CustomRestClient()).AddPhone<Phone>(phoneToCreate).Phone;

            var receivedPhone = new PhoneController(new CustomRestClient()).GetPhone<Phone>(createdPhone.id).Phone;

            Assert.That(receivedPhone, Is.Not.Null, $"Phone with id {createdPhone.id} was not created!");
        }
    }
}
