//using OpenQA.Selenium.Support.UI;
//using OpenQA.Selenium;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace BuggyCarsRating.BaseClasses
//{
//    public class WaitHelperTools
//    {
   
//            private WebDriverWait _waitHelper;
//            private IWebDriver _driver;

//            public WaitHelperTools(IWebDriver driver)
//            {
//                _waitHelper = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
//                _driver = driver;
//            }

//            public WaitHelperTools(IWebDriver driver, double timeSpan)
//            {
//                _waitHelper = new WebDriverWait(driver, TimeSpan.FromSeconds(timeSpan));
//                _driver = driver;
//            }

//            public void WaitForElementClickable(By locator)
//            {
//            //    _waitHelper.Until(SeleniumExtras.ElementToBeClickable(locator));
//            }
//            public void WaitForElementClickable(IWebElement element)
//            {
//             //   _waitHelper.Until(SeleniumExtras.ElementToBeClickable(element));
//            }
            

//        }
//    }
