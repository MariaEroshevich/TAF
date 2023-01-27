using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Epam.TestAutomation.API.Models.SharedMoels.Phone
{
    public class PhoneData
    {
        public string color { get; set; }
        public string capacity { get; set; }

        [JsonProperty("capacity GB")]
        public int CapacityGb { get; set; }

        public float price { get; set; }
        public string generation { get; set; }
        public int year { get; set; }
        public string CPUmodel { get; set; }
        public string Harddisksize { get; set; }
        public string StrapColour { get; set; }
        public string CaseSize { get; set; }
        public string Description { get; set; }
        public float Screensize { get; set; }
    }
}
