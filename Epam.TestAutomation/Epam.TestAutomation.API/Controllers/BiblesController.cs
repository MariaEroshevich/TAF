using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.TestAutomation.API.Controllers
{
    public class BiblesController : BaseController
    {
        public BiblesController(CustomRestClient client, string apiKey) : base(client, Service.Bibles, apiKey)
        {
        }

        public BiblesController(CustomRestClient client) : base(client, Service.Bibles, client.AppConfig.ApiKey)
        {
        }

        private const string AllBiblesResourse = "/v1/bibles";

        /// <summary>
        /// Gets list of Bibles from API
        /// </summary>
        /// <typeparam name="T"><see cref="AllBiblesModel"/></typeparam>
        /// <returns>response info <see cref="RestResponse"/> and <see cref="AllBiblesModel"/></returns>
        public (RestResponse response, T? Bibles) GetBibles<T>()
        {
            return Get<T>(AllBiblesResourse);
        }
    }
}
