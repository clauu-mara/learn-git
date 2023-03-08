namespace AutomationTesting.Selenium
{
    public interface IWebDriver
    {
        void FindElement();
        void Click();
        void SendKeys(string keys);
    }
}
