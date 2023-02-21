using AutomationTesting.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTesting.Browsers
{
     class IE : IWebDriver
    {
        public void FindElement()
        {
            Console.WriteLine("Find the UI element using in IE");
        }

        public void Click()
        {
            Console.WriteLine("Click the element in IE");
        }

        public void SendKeys()
        {
            Console.WriteLine("Send the text");
        }
    }
}
