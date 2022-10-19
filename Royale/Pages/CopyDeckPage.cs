using Framework.Selenium;
using OpenQA.Selenium;

namespace Royale.Pages
{
    public class CopyDeckPage: PageBase
    {
        public readonly CopyDeckPageMap Map;
        public CopyDeckPage()
        {
            Map =new CopyDeckPageMap();
        }
        
        public void ClickOnYesButton()
        {
            Map.YesButton.Click();
        }
        public bool CopiedMessageIsDisplayed()
        {
           return Map.CopiedMessage.Displayed;
        }

    }
    
    public class CopyDeckPageMap
    {
      //selectors
      public IWebElement YesButton =>  Driver.Current.FindElement(By.CssSelector("button-open"));
      public IWebElement CopiedMessage => Driver.Current.FindElement(By.CssSelector(".notes.active"));

    }
}