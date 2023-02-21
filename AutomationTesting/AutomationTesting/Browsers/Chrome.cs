using AutomationTesting.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTesting.Browsers
{
     class Chrome: IWebDriver
    {
        public void FindElement()
        {
            Console.WriteLine("Find the UI element using Chrome");
        }

        public void Click()
        {
            Console.WriteLine("Click the element in Chrome");
        }

        public void SendKeys()
        {
            Console.WriteLine("Send the text");
        }
    }
}
