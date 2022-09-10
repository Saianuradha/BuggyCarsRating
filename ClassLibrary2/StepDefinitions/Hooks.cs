using BoDi;
using ClassLibrary2.BaseClasses;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;


namespace BuggyCarsRating.StepDefinitions
{
    [Binding]
    public class Hooks
    {
        private const string GeckoDriverDirectory = "@C:/Users/shyam/OneDrive/Desktop/Anuradha/ClassLibrary2/ClassLibrary2/Drivers, geckodriver.exe";

        private readonly IObjectContainer objectContainer;
        private readonly FeatureContext featureContext;
        private readonly ScenarioContext scenarioContext;
        public Hooks(IObjectContainer objectContainer, FeatureContext featureContext, ScenarioContext scenarioContext)
        {
            this.objectContainer = objectContainer;
            this.featureContext = featureContext;
            this.scenarioContext = scenarioContext;
        }

        [BeforeFeature]
        public static void SetupStuffForFeatures(ScenarioContext scenarioContext)
        {
            Console.WriteLine("Starting " + scenarioContext.ScenarioInfo.Title);
        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            var appSettings = ConfigurationManager.AppSettings;
            var implicitWait = int.Parse(appSettings["implicitWait"]);
            var Url = appSettings["URL"];
            IWebDriver driver = new FirefoxDriver(GeckoDriverDirectory);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWait);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(Url);
        }

        [AfterScenario]
        public void AfterScenario()
        {

            IWebDriver driver = (IWebDriver)objectContainer.Resolve<IWebDriver>();
            driver.Quit();
        }

    }

}
