using MarsProject_SpecFlowAutomation.Drivers;
using MarsProject_SpecFlowAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProject_SpecFlowAutomation.Utilities
{
    public interface IAppConfigurationFileReader
    {
        AppConfigurationModel GetAppConfigurationData();
    }
}
