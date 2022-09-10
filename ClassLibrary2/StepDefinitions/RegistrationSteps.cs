using BoDi;
using BuggyCarsRating.Pages;
using BuggyCarsRating.StepDefinitions;
using ClassLibrary2.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace ClassLibrary2.StepDefinitions


{
    [Binding]

    public class RegistrationSteps : BaseSteps

    {
      

        public RegistrationSteps(IWebDriver driver, IObjectContainer objectContainer, ScenarioContext scenarioContext, FeatureContext featureContext) : base(driver, objectContainer, scenarioContext, featureContext)
        {
        }

        [Given(@"I register on the site using:")]
        public void GivenIRegisterOnTheSiteUsing()
        {
           // HomePage home = new HomePage(driver);
          //  home.RegisterButton.Click();
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
           
        }
    }
}
