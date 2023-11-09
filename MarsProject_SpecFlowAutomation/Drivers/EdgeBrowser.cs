using MarsProject_SpecFlowAutomation.Utilities;
using OpenQA.Selenium.Edge;

namespace MarsProject_SpecFlowAutomation.Drivers
{
    internal class EdgeBrowser : CommonDriver
    {
        public EdgeBrowser()
        {
            driver = new EdgeDriver();
        }
    }
}
