using MarsProject_SpecFlowAutomation.Pages;
using MarsProject_SpecFlowAutomation.Utilities;
using OpenQA.Selenium;
using RazorEngine;
using System;
using TechTalk.SpecFlow;

namespace MarsProject_SpecFlowAutomation.StepDefinitions
{
    [Binding]
    public class AddLanguageStepDefinition : CommonDriver
    {
        AddLanguagePage addLanguagePageObj = new AddLanguagePage(driver);
        CheckingTabsPage checkingTabPageObj = new CheckingTabsPage(driver);

        [When(@"I am on Profile Page")]
        public void IAmOnProfilePage()
        {
            checkingTabPageObj.clickOnProfileButton();
        }

        [When(@"I click on Languages tab")]
        public void IClickOnLanguagesTab()
        {
            checkingTabPageObj.clickOnLanguagesTab();
        }

        [When(@"I click on Add new button under Languages tab")]
        public void IClickOnAddNewButtonUnderLanguagesTab()
        {
            addLanguagePageObj.clickOnAddNewButton(driver);

        }

        [Then(@"Populate Language input fields")]
        public void PopulateLanguageInputFields()
        {
            addLanguagePageObj.setaddLanguageTextBox();
            addLanguagePageObj.selectLanguageLevelDropdown();
            Thread.Sleep(3000);
        }

        [Then(@"I click on Add button")]
        public void IClickOnAddButton()
        {
            addLanguagePageObj.clickOnAddButton();
            Thread.Sleep(3000);
        }

        [Then(@"I can see that the language can be added and it will visible in the table")]
        public void ICanSeeThatTheLanguageCanBeAddedAndItWillVisibleInTheTable()
        {
            Console.WriteLine("Language has been added to the grid");
        }

        [When(@"I click on Cancel button")]
        public void IClickOnCancelButton()
        {
            addLanguagePageObj.clickOnCancelButton();
        }
        
        [Then(@"I can see that form will be delete from language tab")]
        public void ICanSeeThatFormWillBeDeleteFromLanguageTab()
        {
            addLanguagePageObj.verifyingForm();
            Thread.Sleep(3000);
        }

        [Then(@"I click on Edit option")]
        public void IClickOnEditOption()
        {
            addLanguagePageObj.clickOnEditOption();
        }

        [Then(@"I should be able to see update and cancel options")]
        public void IShouldBeAbleToSeeUpdateAndCancelOptions()
        {
            addLanguagePageObj.verifyingUpdateAndCancelOptions();
        }

        [Then(@"I update the value in the input fields")]
        public void IUpdateTheValueInTheInputFields()
        {
            addLanguagePageObj.updateValue();
            Thread.Sleep(3000);
        }

        [When(@"I click on update option")]
        public void IClickOnUpdateOption()
        {
            addLanguagePageObj.clickOnUpdateButton();
        }

        [Then(@"I can see update value saved")]
        public void ICanSeeUpdateValueSaved()
        {
            Console.WriteLine("update has been saved");

            /*
            //To locate table.
            WebElement mytable = (WebElement) driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table"));
            //To locate rows of table.
            var rows_table = (mytable.FindElements(By.TagName("tr")));
            //To calculate no of rows In table.
            int rows_count = rows_table.Count;

            //Loop will execute till the last row of table.
            for (int rowIndex = 0; rowIndex < rows_count; rowIndex++)
            {
                var rowdata = rows_table[rowIndex];

               var  rowcells = (rowdata.FindElements(By.TagName("td")));
                var languageCellValue = rowcells[0].Text;

                //*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]

                //To locate columns(cells) of that specific row.
                //List<WebElement> Columns_row = rows_table.FirstOrDefault(x=>x.FindElement(By.TagName("td"))) get(row).findElements(By.tagName("td"));
                //To calculate no of columns(cells) In that specific row.
                //int columns_count = Columns_row.size();
                //System.out.println("Number of cells In Row " + row + " are " + columns_count);

                ////Loop will execute till the last cell of that specific row.
                //for (int column = 0; column < columns_count; column++)
                //{
                //    //To retrieve text from that specific cell.
                //    String celtext = Columns_row.get(column).getText();
                //    System.out.println("Cell Value Of row number " + row + " and column number " + column + " Is " + celtext);
                //}
                //System.out.println("--------------------------------------------------");
            }
            */
        }

        [When(@"I click on Remove option")]
        public void IClickOnRemoveOption()
        {
            addLanguagePageObj.clickOnRemoveIconOption();
        }

        [Then(@"I see that the row has delete from the table")]
        public void ISeeThatTheRowHasDeleteFromTheTable()
        {
            Console.WriteLine("Row has been deleted");
        }

    }
}
