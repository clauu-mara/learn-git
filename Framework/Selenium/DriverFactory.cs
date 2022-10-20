using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Framework.Selenium
{
    public static class DriverFactory
    {
        public static IWebDriver Build(string browserName)
        {
            FW.Log.Info($"Browser: {browserName}");
            switch(browserName)
            {
                case "Chrome":
                  return new ChromeDriver(FW.WORKSPACE_DIRECTORY + "_drivers");
                
                case "FireFox":
                  return new FirefoxDriver();

                default:
                  throw new System.ArgumentException($"{browserName} not supported");
            }
        }
    }
}