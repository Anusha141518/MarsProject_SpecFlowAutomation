using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using RazorEngine.Compilation.ImpromptuInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MarsProject_SpecFlowAutomation.Pages
{
    public class AddLanguagePage
    {
        IWebDriver driver;

        By addNewButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div");
        By addLanguageTextBox = By.Name("name");
        //By languageLevelDropdown = By.Name("level"); //dropdown webelement
        By addButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]");
        By cancelButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[2]");
        By editOption = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i");
        By updateButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]");
        By removeIconOption = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i");
        

        public AddLanguagePage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Window.Maximize();
        }
        
        public void clickOnAddNewButton(IWebDriver driver)
        {
            driver.FindElement(addNewButton).Click();
        }
        public void setaddLanguageTextBox()
        {
            driver.FindElement(addLanguageTextBox).SendKeys("Telugu");
        }
        public void selectLanguageLevelDropdown()
        {
            var languageLevelDropdown = driver.FindElement(By.Name("level"));
            var selectElement  = new SelectElement(languageLevelDropdown);
            selectElement.SelectByValue("Fluent");
        }
        public void clickOnAddButton()
        {
            driver.FindElement(addButton).Click();
        }
        public void clickOnCancelButton()
        {
            driver.FindElement(cancelButton).Click();

        }

        public void verifyingForm() 
        {

            Assert.AreEqual(true, driver.FindElements(addLanguageTextBox).Count == 0, "Invalid cancel button");  

        }
        public void clickOnEditOption()
        {
            driver.FindElement(editOption).Click();
        }

        public void verifyingUpdateAndCancelOptions()
        {
            var updateBtn = driver.FindElement(updateButton);
            Assert.AreEqual(true, updateBtn != null, "update button not found");
        }

        public void updateValue()
        {
            driver.FindElement(addLanguageTextBox).Clear();
            driver.FindElement(addLanguageTextBox).SendKeys("English");

        }

        public void clickOnUpdateButton()
        {
            driver.FindElement(updateButton).Click();
        }
        public void clickOnRemoveIconOption()
        {
            driver.FindElement(removeIconOption).Click();

        }
        

    }
}
