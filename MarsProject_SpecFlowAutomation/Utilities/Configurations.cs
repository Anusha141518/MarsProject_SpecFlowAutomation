using MarsProject_SpecFlowAutomation.Drivers;
using MarsProject_SpecFlowAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProject_SpecFlowAutomation.Utilities
{
    public class Configurations
    {
        public static BrowserType? DriverType = null;
        public static AppConfigurationModel AppConfig = new AppConfigurationModel();

        public Configurations()
        {
            AppConfig = new AppConfigurationFileReader().GetAppConfigurationData(); // Loading all config data before scanario runs
            DriverType = AppConfig.Browser;
        }

    }
}
