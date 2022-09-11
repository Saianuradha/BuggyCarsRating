using BoDi;
using BuggyCarsRating.Pages;
using ClassLibrary2.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Web.UI.WebControls;
using TechTalk.SpecFlow;

namespace BuggyCarsRating.StepDefinitions
{
    [Binding]
    public class RegistrationSteps : BaseSteps
    {
        public RegistrationSteps(IWebDriver driver, IObjectContainer objectContainer, ScenarioContext scenarioContext, FeatureContext featureContext) : base(driver, objectContainer, scenarioContext, featureContext)
        {
        }

        [Given(@"I'm on the Registration page")]
        public void GivenImOnTheRegistrationPage()
        {
            HomePage homePage = new HomePage(driver);
            homePage.Register.Click();
           
        }

        [When(@"I submit Login ""([^""]*)"", First Name ""([^""]*)"", Last Name ""([^""]*)"", Password ""([^""]*)"" ,Confirm Password ""([^""]*)""")]
        public void WhenISubmitLoginFirstNameLastNamePasswordConfirmPassword(string Login, string FirstName, string LastName, string Password, string ConfirmPassword)
        {
            RegistrationPage register = new RegistrationPage(driver);
            register.CreateNewUser(Login, FirstName, LastName, Password, ConfirmPassword);
            register.RegisterButton.Click();
        }

        [Then(@"I should see Success message ""([^""]*)""")]
        public void ThenIShouldSeeSuccessMessage(string message)
        {
            RegistrationPage register = new RegistrationPage(driver);
            Assert.IsTrue(register.RegistrationSuccessMessage.Displayed, "registration message successful shown");
        }

        [Then(@"I should see an error message ""([^""]*)""")]
        public void ThenIShouldSeeAnErrorMessage(string message)
        {
            RegistrationPage register = new RegistrationPage(driver);
            Assert.IsTrue(register.RegistrationFailMessage.Displayed , message);
            
        }
    }
}
