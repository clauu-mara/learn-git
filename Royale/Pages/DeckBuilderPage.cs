using Framework;
using Framework.Selenium;
using OpenQA.Selenium;

namespace Royale.Pages
{
    public class DeckBuilderPage: PageBase
    {
        //define map to access attributes inside it
        public readonly DeckBuilderPageMap Map;
        public DeckBuilderPage()
        {
            Map = new DeckBuilderPageMap();
        }
        public DeckBuilderPage Goto()
        {
          FW.Log.Step("Click Deck Builder Link");
          HeaderNav.Map.DeckBuilderLink.Click();    
          return this; // it is returning itself 
        }
        // I am going to do methods for every selector I have 
        public void AddCardsManually()
        {
            Driver.Wait.Until(driver => Map.AddCardsManuallyLink.Displayed);
            FW.Log.Step("Click Add Cards Manually Link");
            //call map here
             Map.AddCardsManuallyLink.Click();             
        }
        public void CopyDeckIcon()
        {
            Driver.Wait.Until(driver => Map.CopyDeckIconButton.Displayed);  
            FW.Log.Step("Click Copy Deck Icon");
            Map.CopyDeckIconButton.Click();
        }

    }

    public class DeckBuilderPageMap
    {
        //declaring selectors in the map class
        public IWebElement AddCardsManuallyLink => (IWebElement)Driver.FindElement(By.XPath("//a[text()='add cards manually']"));
        public IWebElement CopyDeckIconButton => Driver.Current.FindElement(By.CssSelector(".copyButton"));
    }
}