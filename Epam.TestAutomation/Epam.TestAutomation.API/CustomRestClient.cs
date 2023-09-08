using Microsoft.Extensions.Configuration;
using RestSharp;

namespace Epam.TestAutomation.API
{
    public class CustomRestClient
    {
        public readonly AppConfiguration AppConfig = new();

        public CustomRestClient()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            config.Bind(AppConfig);
        }

        public RestClient CreateRestClient(Service service)
        {
            var baseUrl = service switch
            {
                Service.Bibles => AppConfig.BiblesBaseUrl,
                Service.Tech => AppConfig.TechBaseUrl,
                _ => throw new ArgumentException("Invalid service option provided!")
            };

            var options = new RestClientOptions(baseUrl);

            return new RestClient(options);
        }
    }
}
