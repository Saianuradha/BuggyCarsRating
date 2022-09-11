using ClassLibrary2.BaseClasses;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuggyCarsRating.Pages
{
   
    public class LoginPage : BasePage
    {
        public IWebElement UsernameField => driver.FindElement(By.Name("login"));
        public IWebElement PasswordField => driver.FindElement(By.Name("password"));
        public IWebElement SubmitButton => driver.FindElement(By.XPath("//button[@type='submit'][text()='Login']"));

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public void enterDetails(string user, string password)
        {
            UsernameField.SendKeys(user);
            PasswordField.SendKeys(password);
            SubmitButton.Click();

        }
    }
}
