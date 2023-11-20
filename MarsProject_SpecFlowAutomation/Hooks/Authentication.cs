using Docker.DotNet.Models;
using MarsProject_SpecFlowAutomation.Pages;
using MarsProject_SpecFlowAutomation.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProject_SpecFlowAutomation.Hooks
{
    [Binding]
    public class Authentication : CommonDriver
    {
        LoginPage LoginPageObj = new LoginPage(driver);

        [BeforeScenario(Order = 3)]
        [Scope(Tag = "LoginBackground")]
        public void loginAuthentication() 
        {
            //Launch Mars portal and navigate to website login page
            driver.Navigate().GoToUrl(Configurations.AppConfig.Website);
            LoginPageObj.clickOnSignIn();


            LoginPageObj.setUserName(Configurations.AppConfig.UserName);
            LoginPageObj.setPassword(Configurations.AppConfig.Password);

            LoginPageObj.clickOnLoginButton();
            Thread.Sleep(3000);


        }






    }
}
