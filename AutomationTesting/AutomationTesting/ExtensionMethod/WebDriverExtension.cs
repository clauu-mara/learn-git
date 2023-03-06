using AutomationTesting.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTesting.ExtensionMethod
{
    public static class WebDriverExtension
    {
        //IWebDriver should be public
        public static void SendKeysWithSpecialChar(this IWebDriver driver, string keys, string specialChar)
        {
            driver.SendKeys(keys);
            driver.SendKeys(specialChar);
        }
        //pt string -  sa stearga cateva caractere speciale din string /int sa covertesc in double
    }
}
