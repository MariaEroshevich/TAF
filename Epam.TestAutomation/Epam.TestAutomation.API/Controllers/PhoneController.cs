using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.TestAutomation.API.Models.RequesModels.Phone;
using Epam.TestAutomation.API.Models.ResponseModels;
using Epam.TestAutomation.API.Models.ResponseModels.Phone;
using RestSharp;

namespace Epam.TestAutomation.API.Controllers
{
    public class PhoneController : BaseController
    {
        public PhoneController(CustomRestClient client) : base(client, Service.Phones)
        {
        }

        private const string PhonesResource = "/objects";

        private const string SinglePhoneResource = "/objects/{0}";

        /// <summary>
        /// Request that receive all list of phones
        /// </summary>
        /// <typeparam name="T"><see cref="Phone"/></typeparam>
        /// <returns>response typeof <see cref="RestResponse"/> and List of <see cref="Phone"/></returns>
        public (RestResponse Response, T AllPhones) GetPhones<T>()
        {
            return Get<T>(PhonesResource);
        }

        /// <summary>
        /// Request that receive single phone by id
        /// </summary>
        /// <typeparam name="T"><see cref="Phone"/></typeparam>
        /// <returns>response typeof <see cref="RestResponse"/> and <see cref="Phone"/></returns>
        public (RestResponse Response, T Phone) GetPhone<T>(string phoneId)
        {
            return Get<T>(string.Format(SinglePhoneResource, phoneId));
        }

        /// <summary>
        /// Request that created phone that was sent as <see cref="PhoneModel"/> model
        /// </summary>
        /// <typeparam name="T"><see cref="Phone"/></typeparam>
        /// <param name="model"><see cref="PhoneModel"/></param>
        /// <returns>response typeof <see cref="RestResponse"/> and <see cref="Phone"/></returns>
        public (RestResponse Response, T Phone) AddPhone<T>(PhoneModel model)
        {
            return Post<T, PhoneModel>(PhonesResource, model);
        }
    }
}
