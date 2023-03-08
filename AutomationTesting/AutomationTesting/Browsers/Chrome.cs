﻿using AutomationTesting.Selenium;

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

        public void SendKeys(string keys)
        {
            Console.WriteLine("Send the text: " + keys);
        }
    }
}
