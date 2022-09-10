using OpenQA.Selenium;

namespace ClassLibrary2.BaseClasses
{
    public abstract class BasePage
    {
        protected IWebDriver driver;
        public IWebElement HomePage => driver.FindElement(By.LinkText("Buggy Rating"));

        protected BasePage(IWebDriver driver)
        {
            
            this.driver = driver;
        }
    }
}
