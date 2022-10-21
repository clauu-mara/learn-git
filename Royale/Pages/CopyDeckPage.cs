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
        public Element YesButton => Driver.FindElement(By.CssSelector("button-open"), "Yes Button");
        public Element CopiedMessage => Driver.FindElement(By.CssSelector(".notes.active"), "Copied Message");
        public Element NoButton => Driver.FindElement(By.Id("not-installed"), "No Button");

        public Element AppStoreButton => Driver.FindElement(By.XPath("//a[text()='App Store']"), "App Store Button");

        public Element GooglePlayButton => Driver.FindElement(By.XPath("//a[text()='Google Play']"), "Google Play Button");

        public Element CookieNotificationButton => Driver.FindElement(By.CssSelector("a.cc-btn.cc-dismiss"), "Cookie Button");

        public Element OtherStoresButton => Driver.FindElement(By.Id("other-stores"), "Other Stores Button");

    }
}