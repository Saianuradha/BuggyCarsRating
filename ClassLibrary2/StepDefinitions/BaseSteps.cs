using BoDi;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BuggyCarsRating.StepDefinitions
{
    public abstract class BaseSteps
    {
        protected readonly IWebDriver driver;
        protected IObjectContainer objectContainer;
        protected ScenarioContext scenarioContext;
        protected FeatureContext featureContext;
        protected BaseSteps(IWebDriver driver, IObjectContainer objectContainer, ScenarioContext scenarioContext, FeatureContext featureContext)
        {
            this.driver = driver;
            this.objectContainer = objectContainer;
            this.scenarioContext = scenarioContext;
            this.featureContext = featureContext;
        }

    }
}
