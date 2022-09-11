using BoDi;
using BuggyCarsRating.Pages;
using BuggyCarsRating.StepDefinitions;
using ClassLibrary2.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Configuration;
using System.Web.UI.WebControls;
using TechTalk.SpecFlow;
using Table = TechTalk.SpecFlow.Table;

namespace ClassLibrary2.StepDefinitions


{
    [Binding]

    public class RegistrationSteps : BaseSteps

    {
        public RegistrationSteps(IWebDriver driver, IObjectContainer objectContainer, ScenarioContext scenarioContext, FeatureContext featureContext) : base(driver, objectContainer, scenarioContext, featureContext)
        {
            
        }

        [Given(@"I register on the site using (.*), (.*), (.*), (.*), (.*) as input")]
        public void GivenIRegisterOnTheSiteUsingAsInput(string Login, string FirstName, string LastName, string Password, string ConfirmPassword)
        {
            HomePage homePage = new HomePage(driver);
            homePage.Register.Click();
            RegistrationPage register = new RegistrationPage(driver);
            register.CreateNewUser(Login, FirstName, LastName, Password, ConfirmPassword);
            register.RegisterButton.Click();
        }

        [When(@"verify registration is a success")]
        public void WhenVerifyRegistrationIsASuccess()
        {
            RegistrationPage register = new RegistrationPage(driver);
            Assert.IsTrue(register.RegistrationSuccessMessage.Displayed, "registration message successful shown");
        }

        [Then(@"I use created credentials to log in successfully")]
        public void ThenIUseCreatedCredentialsToLogInSuccessfully()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.enterDetails();
            HomePage homePage = new HomePage(driver);
            Assert.IsTrue(homePage.IsHeaderPresent(), "Login was successful.");
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
