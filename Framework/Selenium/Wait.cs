using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework.Selenium
{
    // wait webdriver is customizable 
    public class Wait
    {
        private readonly WebDriverWait _wait;
        public Wait(int waitSeconds)
        {
            _wait = new WebDriverWait(Driver.Current, TimeSpan.FromSeconds(waitSeconds))
            {
                PollingInterval = TimeSpan.FromMilliseconds(500)
            };

            _wait.IgnoreExceptionTypes(
                typeof(NoSuchElementException),
                typeof(ElementNotVisibleException),
                typeof(StaleElementReferenceException)
            );
        }
        // read about Func
        public bool Until(Func<IWebDriver, bool> condition)
        {
            return _wait.Until(condition);
        }
    }
}