using MarsProject_SpecFlowAutomation.Utilities;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProject_SpecFlowAutomation.Drivers
{
    internal class FirefoxBrowser : CommonDriver
    {
        public FirefoxBrowser()
        {
            driver = new FirefoxDriver();
        }
    }
}
