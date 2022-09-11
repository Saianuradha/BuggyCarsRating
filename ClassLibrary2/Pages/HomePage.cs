using ClassLibrary2.BaseClasses;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuggyCarsRating.Pages
{
    public class HomePage : BasePage
    {
        public IWebElement Register => driver.FindElement(By.XPath("//a[text()='Register']"));
        public IWebElement LoginErrorMessage => driver.FindElement(By.XPath("//span[contains(text(), 'Invalid username/password')]"));
        public IWebElement LogoutButton => driver.FindElement(By.XPath("//a[@class='nav-link'][text()='Logout']"));
        public IWebElement HeaderLogin => driver.FindElement(By.XPath("//span[contains(text(),'Hi')]"));
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public bool IsHeaderPresent()
        {
            try
            {
                return HeaderLogin.Displayed;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        
    }
}
