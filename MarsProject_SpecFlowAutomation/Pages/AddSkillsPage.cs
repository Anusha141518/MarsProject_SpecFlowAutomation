using Microsoft.CodeAnalysis.Emit;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProject_SpecFlowAutomation.Pages
{
    public class AddSkillsPage
    {
        IWebDriver driver;

        By skillsAddNewButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div");
        By addSkillsTextBox = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input");
       // By skillLevelDropdown = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select");
        By skillsAddButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]");
        By skillsCancelButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[2]");
        By skillsEditOption = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i");
        By skillssUpdateButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]");
        By skillsRemoveIconOption = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i");

        public AddSkillsPage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Window.Maximize();
        }

        public void clickOnSkillsAddNewButton()
        {
            driver.FindElement(skillsAddNewButton).Click();
        }
        public void setaddSkillsTextBox()
        {
            driver.FindElement(addSkillsTextBox).SendKeys("Commnunication");
        }

        public void selectSkillsLevelDropdown()
        {
            var skillLevelDropdown = driver.FindElement(By.Name("level"));
            var selectElement = new SelectElement(skillLevelDropdown);
            selectElement.SelectByValue("Beginner");
        }
        public void clickOnskillsAddButton()
        {
            driver.FindElement(skillsAddButton).Click();
        }
        public void clickOnskillCancelButton()
        {
            driver.FindElement(skillsCancelButton).Click();

        }

        public void verifyingForm()
        {

            //var form = driver.FindElement(addSkillsTextBox);

            Assert.AreEqual(true, driver.FindElements(addSkillsTextBox).Count == 0, "Invalid cancel button");

           // Assert.AreEqual(true, form == null, "Invalid cancel button");  // need to implement
        }

        public void clickOnsKillsEditOption()
        {
            driver.FindElement(skillsEditOption).Click();
        }
        public void verifyingSkillsUpdateAndCancelOptions()
        {
            var updateBtn = driver.FindElement(skillssUpdateButton);
            Assert.AreEqual(true, updateBtn != null, "update button not found");
        }

        public void updateSkillsValue()
        {
            driver.FindElement(addSkillsTextBox).Clear();
            driver.FindElement(addSkillsTextBox).SendKeys("English");

        }

        public void clickOnskillssUpdateButton()
        {
            driver.FindElement(skillssUpdateButton).Click();
        }
        public void clickOnskillsRemoveIconOption()
        {
            driver.FindElement(skillsRemoveIconOption).Click();

        }



    }
}
