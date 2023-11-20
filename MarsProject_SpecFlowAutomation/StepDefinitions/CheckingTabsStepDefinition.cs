using MarsProject_SpecFlowAutomation.Pages;
using MarsProject_SpecFlowAutomation.Utilities;
using System;
using TechTalk.SpecFlow;

namespace MarsProject_SpecFlowAutomation.StepDefinitions
{
    [Binding]
    public class CheckingTabsStepDefinition : CommonDriver
    {
        CheckingTabsPage checkingTabPageObj = new CheckingTabsPage(driver);


        [Given(@"I am on Profile Page")]
        public void IAmOnProfilePage()
        {
            checkingTabPageObj.clickOnProfileButton();
            Console.WriteLine("Profile page selected");
        }

        [When(@"I try to click on Languages tab")]
        public void ITryToClickOnLanguagesTab()
        {
            checkingTabPageObj.clickOnLanguagesTab();
        }

        [Then(@"I can see Language tab should be active")]
        public void ICanSeeLanguageTabShouldBeActive()
        {
            checkingTabPageObj.verifyingLanguageTab();
        }

        [When(@"I click on Skills tab")]
        public void IClickOnSkillsTab()
        {
            checkingTabPageObj.clickOnSkillsTab();
        }

        [Then(@"I can see Skills tab should be active")]
        public void ICanSeeSkillsTabShouldBeActive()
        {
            checkingTabPageObj.verifyingSkillsTab();
        }

        [When(@"I click on Eduction tab")]
        public void IClickOnEductionTab()
        {
            checkingTabPageObj.clickOnEductionTab();
        }

        [Then(@"I can see Eduction tab should be active")]
        public void ICanSeeEductionTabShouldBeActive()
        {
            checkingTabPageObj.verifyingEducationTab();
        }

        [When(@"I click on Certifications tab")]
        public void IClickOnCertificationsTab()
        {
            checkingTabPageObj.clickOnCertificationsTab();
        }

        [Then(@"I can see Certifications tab should be active")]
        public void ICanSeeCertificationsTabShouldBeActive()
        {
            checkingTabPageObj.verifyingCertificationsTab();
        }


    }
}

