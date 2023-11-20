using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;
using MarsProject_SpecFlowAutomation.Models;
using MarsProject_SpecFlowAutomation.Drivers;

namespace MarsProject_SpecFlowAutomation.Utilities
{
    public class AppConfigurationFileReader : IAppConfigurationFileReader
    {
        private AppConfigurationModel appConfigurationModel;
        public AppConfigurationFileReader()
        {
            try
            {
                using (StreamReader reader = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "/Configurations/AppConfiguration.json"))
                {

                    appConfigurationModel = JsonConvert.DeserializeObject<AppConfigurationModel>(reader.ReadToEnd());
                }
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
                throw;
            }
          
        }

        public AppConfigurationModel GetAppConfigurationData()
        {
            return appConfigurationModel;
        }

    }
}
