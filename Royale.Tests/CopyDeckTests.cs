using Framework.Selenium;
using Tests.Base;

namespace Royale.Tests
{
    public class CopyDeckTests :TestBase
    {
        [Test, Category("copydeck")]
        public void UserCanCopyTheDeckTest()
        {
            // var wait = new WebDriverWait(Driver.Current, TimeSpan.FromSeconds(10)); I forgot to remove this one
            Pages.Pages.DeckBuilder.Goto().AddCardsManually();
            Pages.Pages.DeckBuilder.CopyDeckIcon();
            Pages.Pages.CopyDeck.ClickOnYesButton();
            Assert.Fail();
            Assert.That(Pages.Pages.CopyDeck.CopiedMessageIsDisplayed);
        }
        [Test, Category("copydeck")]
        public void UserOpensAppStore()
        {
            Pages.Pages.DeckBuilder.Goto().AddCardsManually();
            Pages.Pages.DeckBuilder.CopyDeckIcon();
            Pages.Pages.CopyDeck.ClickOnNoButton().OpenAppStore();

            Assert.That(Driver.Title, Is.EqualTo("Clash Royale on the App Store")); // tests will fail because this string is not exaclty what we are expecting => this is a challenge FOR ME TO DO IT, BUT NOT NOW
        }

        [Test, Category("copydeck")]
        public void UsetOpensGooglePlay()
        {
            Pages.Pages.DeckBuilder.Goto().AddCardsManually();
            Pages.Pages.DeckBuilder.CopyDeckIcon();
            Pages.Pages.CopyDeck.ClickOnNoButton().OpenGooglePlay();

            Assert.That(Driver.Title, Is.EqualTo("Clash Royale - Apps on Google Play")); // here we caught a bug, because it is redirecting to the App store page
        } // we're repeating ourselves => next chapter = logging 
          //Logging is a very important strategy to programming because it helps us locate issues when we inevitably have to debug a problem.
    }
}