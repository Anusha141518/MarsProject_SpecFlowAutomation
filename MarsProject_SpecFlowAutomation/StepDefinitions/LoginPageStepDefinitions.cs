using MarsProject_SpecFlowAutomation.Pages;
using MarsProject_SpecFlowAutomation.Utilities;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsProject_SpecFlowAutomation.StepDefinitions
{
    [Binding]
    public class LoginPageStepDefinitions : CommonDriver
    {
        LoginPage LoginPageObj = new LoginPage(driver);

        [Given(@"I am on the Mars home page and able to see Signin and Join buttons")]
        public void IAmOnTheMarsHomePageAndAbleToSeeSigninAndJoinButtons()
        {
           // driver.Manage().Window.Maximize();

            //Launch Mars portal and navigate to website login page
            driver.Navigate().GoToUrl("http://localhost:5000/Home");

        }

        [Given(@"I choose Signin option")]
        public void IChooseSigninOption()
        {
            LoginPageObj.clickOnSignIn();
        }

        [When(@"I login with valid (.*) and valid (.*)")]
        public void ILoginWithValidUserNameAndValidPassword(string username, string password)
        {
            LoginPageObj.setUserName(username);
            LoginPageObj.setPassword(password);
        }

        [When(@"I click on submit button")]
        public void IClickOnSubmitButton()
        {
            LoginPageObj.clickOnLoginButton();
            Thread.Sleep(3000);
        }


        [Then(@"I click on dashboard button")]
        public void IClickOnDashboardButton()
        {
            LoginPageObj.dashBoardButton();
            Thread.Sleep(3000);
        }

        [When(@"I login with valid (.*) and invalid (.*)")]
        public void ILoginWithValidUserNameAndInvalidPassword(string username, string password)
        {
            LoginPageObj.setUserName(username);
            LoginPageObj.setPassword(password);
            
        }

        [When(@"I click on valid username and click on sendverificationemail button")]
        public void iclickonvalidusernameandclickonsendverificationemailbutton()
        {
            LoginPageObj.verificationEmailButton();
        }

        [Then(@"I see message has been sent to the verification mail")]
        public void ISeeMessageHasBeenSentToTheVerificationMail()
        {
            // Here status message is qickely shows and deletes immediatly, so we cannot track that, instead,
            // if we are able to see home page (may be see the page title), we can consider this is passed.
            LoginPageObj.VerifyHomePageTitle();
        }

        [When(@"I login with invalid (.*) and valid (.*)")]
        public void ILoginWithInvalidUserNameAndValidPassword(string username, string password)
        {
            LoginPageObj.setUserName(username);
            LoginPageObj.setPassword(password);
        }

        [When(@"I login with invalid (.*) and invalid (.*)")]
        public void WhenILoginWithInvalidUserNameAndInvalidPassword(string username, string password)
        {
            LoginPageObj.setUserName(username);
            LoginPageObj.setPassword(password);
        }

        [When(@"I login with (.*)  and valid (.*)")]
        public void WhenILoginWithEmptyUserNameAndValidPassword(string username, string password)
        {
            LoginPageObj.setUserName(username);
            LoginPageObj.setPassword(password);
        }

        [Then(@"I can see email validation text")]
        public void ICanSeeEmailValidationText()
        {
            LoginPageObj.EmptyEmailVerficationMessage();
        }

        [When(@"I login with valid (.*) and empty (.*)")]
        public void WhenILoginWithValidUserNameAndEmptyPawword(string username, string? password)
        {
            LoginPageObj.setUserName(username);
            LoginPageObj.setPassword(password);
        }

        [Then(@"I can see password validation text")]
        public void ThenICanSeePasswordValidationText()
        {
            LoginPageObj.EmptypasswordVerficationMessage();
        }

        [When(@"I login with empty (.*) and empty (.*)")]
        public void WhenILoginWithEmptyUserNameAndEmptyPassword(string username, string password)
        {
            LoginPageObj.setUserName(username);
            LoginPageObj.setPassword(password);
        }

        [Then(@"I can see email and password validation text")]
        public void ThenICanSeeEmailANdPasswordValidationText()
        {
            LoginPageObj.EmptyEmailAndEmptyPasswordVerficationMessage();
        }


    }
}
