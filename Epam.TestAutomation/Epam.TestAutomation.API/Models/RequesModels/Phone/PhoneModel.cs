using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.TestAutomation.API.Models.SharedMoels.Phone;

namespace Epam.TestAutomation.API.Models.RequesModels.Phone
{
    public class PhoneModel
    {
        public string name { get; set; }
        public PhoneData? data { get; set; }
    }
}
