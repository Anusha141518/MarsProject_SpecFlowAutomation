using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MarsProject_SpecFlowAutomation.Pages
{
    public class LoginPage
    {
        IWebDriver driver;
    
        By signIn = By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a");
        By usernameTextbox = By.Name("email");
        By passwordTextbox = By.Name("password");
        By loginButton = By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button");
        By dashboardButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[1]");
        By sendVerificationEmailButton = By.XPath("//*[@id=\"submit-btn\"]");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Window.Maximize();

        }
        public void clickOnSignIn()
        {
            driver.FindElement(signIn).Click();
        }
        public void setUserName(String username)
        {

            driver.FindElement(usernameTextbox).SendKeys(username);
        }
        public void setPassword(String password)
        {

            driver.FindElement(passwordTextbox).SendKeys(password);
        }
        public void clickOnLoginButton()
        {

            driver.FindElement(loginButton).Click();
        }
        public void dashBoardButton()
        {

            driver.FindElement(dashboardButton).Click();
        }
        public void verificationEmailButton()
        {
            driver.FindElement(sendVerificationEmailButton).Click();

        }

        public  void VerifyHomePageTitle()
        {
            var homePageTitle = driver.Title;
            Assert.AreEqual(true, driver.Title.Contains("Home"), "Title is not matching");

        }

    }
        
}
