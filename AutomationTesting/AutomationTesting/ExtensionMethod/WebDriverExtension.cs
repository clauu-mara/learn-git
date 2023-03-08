using AutomationTesting.Selenium;

namespace AutomationTesting.ExtensionMethod
{
    public static class WebDriverExtension
    {
        //IWebDriver should be public
        public static void SendKeysWithSpecialChar(this IWebDriver driver, string keys, string specialChar)
        {
            driver.SendKeys(keys);
            driver.SendKeys(specialChar);
        }

        //convert int to double
        public static void ConvertIntToDouble(this int integers) // think more about it
        {
            Console.WriteLine(Convert.ToDouble(integers));
        }
        
        //TO DO: string - delete special characters 
    }
}
