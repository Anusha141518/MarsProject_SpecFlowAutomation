using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MarsProject_SpecFlowAutomation.Pages
{
    public class CheckingTabsPage
    {
        IWebDriver driver;

        By profileButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]");
        By languagesTab = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]");
        By skillsTab = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]");
        By educationTab = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]");
        By certificationsTab = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]");

        public CheckingTabsPage(IWebDriver driver)
        {
            this.driver = driver;
            //driver.Manage().Window.Maximize();
        }
        public void clickOnProfileButton()
        {
            driver.FindElement(profileButton).Click();
        }
        public void clickOnLanguagesTab()
        {
            driver.FindElement(languagesTab).Click();
        }

        public void verifyingLanguageTab()
        {
            var tabname = driver.FindElement(languagesTab).Text;

            Assert.AreEqual(true, tabname.Contains("Languages"), "You are not landed on Languages tab");

        }
        public void clickOnSkillsTab()
        {
            driver.FindElement(skillsTab).Click();
        }
        public void verifyingSkillsTab()
        {
            var tabname = driver.FindElement(skillsTab).Text;

            Assert.AreEqual(true, tabname.Contains("Skills"), "You are not landed on Skills tab");

        }
        public void clickOnEductionTab()
        {
            driver.FindElement(educationTab).Click();
        }
        public void verifyingEducationTab()
        {
            var tabname = driver.FindElement(educationTab).Text;

            Assert.AreEqual(true, tabname.Contains("Education"), "You are not landed on Education tab");

        }
        public void clickOnCertificationsTab()
        {
            driver.FindElement(certificationsTab).Click();

        }
        public void verifyingCertificationsTab()
        {
            var tabname = driver.FindElement(certificationsTab).Text;

            Assert.AreEqual(true, tabname.Contains("Certifications"), "You are not landed on Certifications tab");

        }








    }
}
