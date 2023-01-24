using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.TestAutomation.API
{
    public class AppConfiguration
    {
        public Uri BiblesBaseUrl { get; set; }

        public Uri PhonesBaseUrl { get; set; }

        public string ApiKey { get; set; }
    }
}
