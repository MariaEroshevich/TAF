using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using RestSharp;

namespace Epam.TestAutomation.API
{
    public class CustomRestClient
    {
        public readonly AppConfiguration _apiConfig = new ();

        public CustomRestClient()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            config.Bind(_apiConfig);
        }

        public RestClient CreateRestClient(Service service)
        {
            var baseUrl = service switch
            {
                Service.Bibles => _apiConfig.BiblesBaseUrl,
                Service.Phones => _apiConfig.PhonesBaseUrl,
                _ => throw new ArgumentException("Invalid service option provided!")
            };

            var options = new RestClientOptions()
            {
                BaseUrl = baseUrl,
            };

            var restClient = new RestClient(options);
            return restClient;
        }
    }
}
