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
            _driver = DriverFactory.Build(FW.Config.Driver.Browser);
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
        public static void TakeScreenshot(string imageName)
        {
          var ss = ((ITakesScreenshot)Current).GetScreenshot();
          var ssFileName = Path.Combine(FW.CurrentTestDirectory.FullName, imageName);
          ss.SaveAsFile($"{ssFileName}.png", ScreenshotImageFormat.Png);
        }
        public static Element FindElement(By by, string elementName)
        {
            return new Element(Current.FindElement(by), elementName)
            {
                FoundBy = by
            };
        }
        public static Elements FindElements(By by)
        {
            return new Elements(Current.FindElements(by))
            {
                FoundBy = by
            };
        }

        public static void Quit()
        {
            FW.Log.Info("Close Browser");
            Current.Quit();
        }
    }
}