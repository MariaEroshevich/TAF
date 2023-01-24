using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.TestAutomation.API.Controllers
{
    public class PhoneController : BaseController
    {
        public PhoneController(CustomRestClient client) : base(client, Service.Phones)
        {
        }
    }
}
