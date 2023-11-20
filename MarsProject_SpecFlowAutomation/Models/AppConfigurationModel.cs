using MarsProject_SpecFlowAutomation.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProject_SpecFlowAutomation.Models
{
    public class AppConfigurationModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Website { get; set; }
        public int PageLoadTimeOut { get; set; }
        public int ImplicitWait { get; set; }
        public int ExplicitWait { get; set; }
        public BrowserType Browser { get; set; }
    }
}
