using Framework.Selenium;
using OpenQA.Selenium;

namespace Royale.Pages
{
    public class CopyDeckPage : PageBase
    {
        public readonly CopyDeckPageMap Map;
        public CopyDeckPage()
        {
            Map = new CopyDeckPageMap();
        }

        public CopyDeckPage ClickOnYesButton()
        {
            Map.YesButton.Click();
            Driver.Wait.Until(driver => Map.CopiedMessage.Displayed);
            return this; // i am still on the same page
        }
        public bool CopiedMessageIsDisplayed()
        {
            return Map.CopiedMessage.Displayed;
        }
        public CopyDeckPage ClickOnNoButton()
        {
            Map.NoButton.Click();
            CloseCookieNotification();
            Driver.Wait.Until(driver => Map.OtherStoresButton.Displayed);
            return this; // it is returning the same page/itself
        }

        public void CloseCookieNotification()
        {
            Map.CookieNotificationButton.Click();
            Driver.Wait.Until(driver => !Map.CookieNotificationButton.Displayed);
        }

        public void OpenAppStore()
        {
            Map.AppStoreButton.Click();
        }
        public void OpenGooglePlay()
        {
            Map.GooglePlayButton.Click();
        }

    }

    public class CopyDeckPageMap
    {
        //selectors
        public IWebElement YesButton => Driver.Current.FindElement(By.CssSelector("button-open"));
        public IWebElement CopiedMessage => Driver.Current.FindElement(By.CssSelector(".notes.active"));
        public IWebElement NoButton => Driver.Current.FindElement(By.Id("not-installed"));

        public IWebElement AppStoreButton => Driver.Current.FindElement(By.XPath("//a[text()='App Store']"));

        public IWebElement GooglePlayButton => Driver.Current.FindElement(By.XPath("//a[text()='Google Play']"));

        public IWebElement CookieNotificationButton => Driver.Current.FindElement(By.CssSelector("a.cc-btn.cc-dismiss"));

        public IWebElement OtherStoresButton => Driver.Current.FindElement(By.Id("other-stores"));

    }
}