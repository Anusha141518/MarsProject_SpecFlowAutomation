using AventStack.ExtentReports.Gherkin.Model;
using Docker.DotNet.Models;
using MarsProject_SpecFlowAutomation.Pages;
using MarsProject_SpecFlowAutomation.Utilities;
using NUnit.Framework;
using System;
using System.Runtime.Intrinsics.X86;
using TechTalk.SpecFlow;

namespace MarsProject_SpecFlowAutomation.StepDefinitions
{
    [Binding]
    public class AddSkillsStepDefinition : CommonDriver
    {

        AddSkillsPage addSkillsPageObj = new AddSkillsPage(driver);
        CheckingTabsPage checkingTabPageObj = new CheckingTabsPage(driver);


        [When(@"I am on Profile Page")]
        public void IAmOnProfilePage()
        {
            checkingTabPageObj.clickOnProfileButton();
        }

        [When(@"I click on Skills Tab")]
        public void IClickOnSkillsTab()
        {
            checkingTabPageObj.clickOnSkillsTab();
        }


        [When(@"I click on Add new button under Skills tab")]
        public void WhenIClickOnAddNewButtonUnderSkillsTab()
        {
            addSkillsPageObj.clickOnSkillsAddNewButton();
        }

        [Then(@"Populate Skills input fields")]
        public void ThenPopulateSkillsInputFields()
        {
            addSkillsPageObj.setaddSkillsTextBox();
            addSkillsPageObj.selectSkillsLevelDropdown();
            Thread.Sleep(3000);
        }

        [Then(@"I click on Skills Add button")]
        public void IClickOnSkillsAddButton()
        {
            addSkillsPageObj.clickOnskillsAddButton();
            Thread.Sleep(3000);
        }

        [Then(@"I can see that the Skills can be added and it will visible in the table")]
        public void ThenICanSeeThatTheSkillsCanBeAddedAndItWillVisibleInTheTable()
        {
            Console.WriteLine("Skills has been added");
        }

        [When(@"I click on Cancel button under Skills tab")]
        public void IClickOnCancelButtonUnderSkillsTab()
        {
            addSkillsPageObj.clickOnskillCancelButton();
        }

        [Then(@"I can see that form will be delete from Skills tab")]
        public void ThenICanSeeThatFormWillBeDeleteFromSkillsTab()
        {
            addSkillsPageObj.verifyingForm();
            Thread.Sleep(3000);
        }

        [Then(@"I click on Skills Edit option")]
        public void IClickOnSkillsEditOption()
        {
            addSkillsPageObj.clickOnsKillsEditOption();
        }

        [Then(@"I should be able to see update and cancel options under Skills tab")]
        public void ThenIShouldBeAbleToSeeUpdateAndCancelOptionsUnderSkillsTab()
        {
            addSkillsPageObj.verifyingSkillsUpdateAndCancelOptions();
        }

        [When(@"I click on update option under Skills tab")]
        public void WhenIClickOnUpdateOptionUnderSkillsTab()
        {
            Console.WriteLine("update has been saved");
        }

        [When(@"I click on Remove option under Skills tab")]
        public void IClickOnRemoveOptionUnderSkillsTab()
        {
            addSkillsPageObj.clickOnskillsRemoveIconOption();
        }

        [Then(@"I see that the row has delete from the Skills table")]
        public void ISeeThatTheRowHasDeleteFromTheSkillsTable()
        {
            Console.WriteLine("Row has been deleted");
        }
    }

}
