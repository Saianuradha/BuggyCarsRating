using System;
using TechTalk.SpecFlow;

namespace BuggyCarsRating.StepDefinitions
{
    [Binding]
    public class AuthenticationStepDefinitions
    {
        [Given(@"I'm on Buggy Cars Rating home page")]
        public void GivenImOnBuggyCarsRatingHomePage()
        {
            throw new PendingStepException();
        }

        [When(@"I enter User Name ""([^""]*)"" and Password ""([^""]*)""")]
        public void WhenIEnterUserNameAndPassword(string p0, string p1)
        {
            throw new PendingStepException();
        }

        [Then(@"I should be able to login successfully\.")]
        public void ThenIShouldBeAbleToLoginSuccessfully_()
        {
            throw new PendingStepException();
        }

        [Given(@"I am logged in")]
        public void GivenIAmLoggedIn()
        {
            throw new PendingStepException();
        }

        [When(@"I click on the Logout button\.")]
        public void WhenIClickOnTheLogoutButton_()
        {
            throw new PendingStepException();
        }

        [Then(@"I should be logged off")]
        public void ThenIShouldBeLoggedOff()
        {
            throw new PendingStepException();
        }
    }
}
