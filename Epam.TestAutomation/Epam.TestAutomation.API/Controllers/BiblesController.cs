using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.TestAutomation.API.Models.ResponseModels;
using RestSharp;

namespace Epam.TestAutomation.API.Controllers
{
    /// <summary>
    /// Class that contains methods and resources for /v1 micro service
    /// </summary>
    public class BiblesController : BaseController
    {
        public BiblesController(CustomRestClient client, string apiKey = "") : base(client, Service.Bibles, apiKey)
        {
        }

        public BiblesController(CustomRestClient client) : base(client, Service.Bibles, client._apiConfig.ApiKey)
        {
        }

        private const string AllBiblesResource = "/v1/bibles";

        private const string SingleBibleResource = "/v1/bibles/{0}";

        /// <summary>
        /// Request that receive all list of bibles
        /// </summary>
        /// <typeparam name="T"><see cref="AllBiblesModel"/></typeparam>
        /// <returns>response typeof <see cref="RestResponse"/> and <see cref="AllBiblesModel"/></returns>
        public (RestResponse Response, T Bibles) GetBibles<T>()
        {
            return Get<T>(AllBiblesResource);
        }

        public (RestResponse Response, T Bibles) GetBible<T>(string id)
        {
            return Get<T>(string.Format(SingleBibleResource, id));
        }
    }
}
