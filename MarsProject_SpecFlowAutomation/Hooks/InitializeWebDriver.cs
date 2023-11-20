using MarsProject_SpecFlowAutomation.Drivers;
using MarsProject_SpecFlowAutomation.Models;
using MarsProject_SpecFlowAutomation.Utilities;
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
       
        private static Configurations configurations;
       
        [BeforeScenario(Order = 1)]
        public void SetConfigurations()
        {
            configurations = new Configurations(); 
        }

        [BeforeScenario(Order =2)]
        public void SetDriver()
        {

            switch (Configurations.DriverType)
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
