using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework.Selenium
{
    public static class Driver
    {
        [ThreadStatic] // read more about it
        //means that the value of the static field (this case _driver) is unique for each thread => each thread would have its own instance of driver
       private static IWebDriver _driver;
       
       public static void Init()
       {
         _driver= new ChromeDriver(Path.GetFullPath(@"../../../../"+"_drivers"));
       }

       //property -> current value of the _driver
       public static IWebDriver Current => _driver ?? throw new NullReferenceException("driver is null");
    }
}