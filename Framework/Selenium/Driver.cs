using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework.Selenium
{
    public static class Driver
    {
        [ThreadStatic] // read more about it
                       //means that the value of the static field (this case _driver) is unique for each thread => each thread would have its own instance of driver
        private static IWebDriver _driver;

        [ThreadStatic]
        public static Wait Wait;

        public static void Init()
        {
            FW.Log.Info("Browser: Chrome");
            _driver = new ChromeDriver(Path.GetFullPath(@"../../../../" + "_drivers"));
            Wait = new Wait(10);
        }

        //property -> current value of the _driver
        public static IWebDriver Current => _driver ?? throw new NullReferenceException("driver is null");

        public static string Title => Current.Title; // now our driver has a TITLE property

        public static void GoTo(string url)
        {
            if (!url.StartsWith("https"))
            {
                url = $"http//{url}";
            }

            FW.Log.Info(url);
            Current.Navigate().GoToUrl(url);
        }
        public static IWebDriver FindElement(By by)
        {
            return (IWebDriver)Current.FindElement(by);
        }
        public static IList<IWebDriver> FindElements(By by)
        {
            return (IList<IWebDriver>)Current.FindElements(by);
        }

        public static void Quit()
        {
            FW.Log.Info("Close Browser");
            Current.Quit();
        }
    }
}