using ClassLibrary2.BaseClasses;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Pages
{
    internal class RegistrationPage : BasePage
    {
        public IWebElement LoginField => driver.FindElement(By.Id("username"));
        public IWebElement FirstNameField => driver.FindElement(By.Id("firstName"));
        public IWebElement LastNameField => driver.FindElement(By.Id("lastName"));
        public IWebElement PasswordField => driver.FindElement(By.Id("password"));
        public IWebElement ConfirmPasswordField => driver.FindElement(By.Id("confirmPassword"));
        
        public IWebElement RegistrationSuccessMessage => driver.FindElement(By.XPath("//div[contains(text(),'Registration is successful')]"));

        public RegistrationPage(IWebDriver driver) : base(driver)
        {
        }
    }
}
