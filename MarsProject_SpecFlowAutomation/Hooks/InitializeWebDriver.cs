using MarsProject_SpecFlowAutomation.Drivers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProject_SpecFlowAutomation.Hooks
{
    [Binding]
    public class InitializeWebDriver
    {
        private static BrowserType? driverType =null;

        [BeforeScenario(Order = 1)]
        public void GetBrowesrToExexuteTestCases()
        {
            driverType = BrowserType.Chrome; // TODO: need to read this value from config file.
        }

        [BeforeScenario(Order =2)]
        public void SetDriver()
        {

            switch (driverType)
            {
                case BrowserType.Chrome:
                new ChromeBrowser();
                    break;  

                case BrowserType.Firefox:
                    new FirefoxBrowser();
                    break;

                 case BrowserType.Edge:
                    new EdgeBrowser();
                    break;

                default:
                    throw new Exception("Browser type is not defined!!");
            }
        }

    }
}
