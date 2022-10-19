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
          HeaderNav.Map.DeckBuilderLink.Click();   
          Driver.Wait.Until(driver => Map.AddCardsManuallyLink.Displayed);
          return this; // it is returning itself 
        }
        // I am going to do methods for every selector I have 
        public void AddCardsManually()
        {
            //call map here
             Map.AddCardsManuallyLink.Click(); 
             Driver.Wait.Until(driver => Map.CopyDeckIconButton.Displayed);  
        }
        public void CopyDeckIcon()
        {
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