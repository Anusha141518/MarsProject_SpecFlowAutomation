using MarsProject_SpecFlowAutomation.Utilities;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProject_SpecFlowAutomation.Drivers
{
    public class ChromeBrowser : CommonDriver
    {
        public ChromeBrowser() {
            driver = new ChromeDriver();
        }
    }
}
