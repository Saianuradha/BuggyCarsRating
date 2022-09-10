using NUnit.Framework.Internal;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.BaseClasses
{
    internal class BaseClass
    {
        
        public static ChromeOptions GetChromeOptions()
       {
           ChromeOptions option = new ChromeOptions();
           option.AddArgument("start-maximized");
            return option;
        }
    }
}
