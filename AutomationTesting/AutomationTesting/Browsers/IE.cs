using AutomationTesting.Selenium;

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

        public void SendKeys(string keys)
        {
            Console.WriteLine("Send the text: " + keys);
        }
    }
}
