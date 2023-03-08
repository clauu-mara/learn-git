using AutomationTesting.Selenium;

namespace AutomationTesting.Browsers
{
    class Firefox : IWebDriver
    {
        public void FindElement()
        {
            Console.WriteLine("Find the UI element using Firefox");
        }

        public void Click()
        {
            Console.WriteLine("Click the element in Firefox");
        }

        public void SendKeys(string keys) { }

    }
}
