using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.TestAutomation.API.Models.SharedModels.Tech;

namespace Epam.TestAutomation.API.Models.RequestModel
{
    public class TechItemRequestModel
    {
        public string name { get; set; }
        public TechData data { get; set; }
    }
}
