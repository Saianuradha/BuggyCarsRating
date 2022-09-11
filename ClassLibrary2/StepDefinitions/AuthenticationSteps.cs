using BoDi;
using BuggyCarsRating.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BuggyCarsRating.StepDefinitions
{
    [Binding]
    public class AuthenticationSteps : BaseSteps
    {
        public AuthenticationSteps(IWebDriver driver, IObjectContainer objectContainer, ScenarioContext scenarioContext, FeatureContext featureContext) : base(driver, objectContainer, scenarioContext, featureContext)
        {
        }

        [Given(@"I'm on Buggy Cars Rating home page")]
        public void GivenImOnBuggyCarsRatingHomePage()
        {

          HomePage homePage = new HomePage(driver);
            homePage.IsHeaderPresent();


        }

        [When(@"I enter User Name ""([^""]*)"" and Password ""([^""]*)""")]
        public void WhenIEnterUserNameAndPassword(string username, string password)
        {
            
            LoginPage login = new LoginPage(driver);
            login.EnterDetails(username,password);
        }

        [Then(@"I should be able to login successfully\.")]
        public void ThenIShouldBeAbleToLoginSuccessfully_()
        {
            LoginPage login = new LoginPage(driver);
            Assert.IsTrue(login.SuccessLogin.Displayed, "Login Sucess");
        }

        [Then(@"I should not be able to login successfully\.")]
        public void ThenIShouldNotBeAbleToLoginSuccessfully_()
        {
            HomePage homePage = new HomePage(driver);
            Assert.IsFalse(homePage.IsHeaderPresent(), "Invalid username/password");
        }

        [When(@"I click on the Logout button\.")]
        public void WhenIClickOnTheLogoutButton_()
        {
            HomePage homePage = new HomePage(driver);
            homePage.LogoutButton.Click();
        }

        [Then(@"I should be logged off")]
        public void ThenIShouldBeLoggedOff()
        {
            HomePage homePage = new HomePage(driver);
            Assert.IsTrue(homePage.IsHeaderPresent());
        }

       
    }
}
