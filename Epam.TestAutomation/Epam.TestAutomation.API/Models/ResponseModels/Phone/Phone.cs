using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.TestAutomation.API.Models.SharedMoels.Phone;
using Newtonsoft.Json;

namespace Epam.TestAutomation.API.Models.ResponseModels.Phone
{
    public class Phone
    {
        public string id { get; set; }
        public string name { get; set; }
        public PhoneData? data { get; set; }
        public DateTime createdAt { get; set; }
    }
}
