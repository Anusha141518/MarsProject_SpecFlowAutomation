using MarsProject_SpecFlowAutomation.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProject_SpecFlowAutomation.Hooks
{
    [Binding]
    public class TearDown : CommonDriver
    {
        [AfterScenario(Order = 1)]
        public void QuitBrowser()
        {
            driver.Quit();
        }

    }
}
