using Framework;
using Framework.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Royale.Tests
{
    public class CopyDeckTests
    {
        [OneTimeSetUp] // it is done before any of tests run to create our test results directory
        public void BeforeAll()
        {
            FW.CreateTestResultsDirectory();
        }

        [SetUp]
        public void BeforeEach()
        {
            FW.SetLogger();
            Driver.Init(); //something unclear...
            Royale.Pages.Pages.Init();
            Driver.GoTo("https://statsroyale.com");
        }

        [TearDown]
        public void AfterEach()
        {
            Driver.Current.Quit();
        }
        [Test, Category("copydeck")]
        public void UserCanCopyTheDeckTest()
        {
            // var wait = new WebDriverWait(Driver.Current, TimeSpan.FromSeconds(10)); I forgot to remove this one
            Royale.Pages.Pages.DeckBuilder.Goto().AddCardsManually();
            Royale.Pages.Pages.DeckBuilder.CopyDeckIcon();
            Royale.Pages.Pages.CopyDeck.ClickOnYesButton();

            Assert.That(Royale.Pages.Pages.CopyDeck.CopiedMessageIsDisplayed);
        }
        [Test, Category("copydeck")]
        public void UserOpensAppStore()
        {
            Royale.Pages.Pages.DeckBuilder.Goto().AddCardsManually();
            Royale.Pages.Pages.DeckBuilder.CopyDeckIcon();
            Royale.Pages.Pages.CopyDeck.ClickOnNoButton().OpenAppStore();

            Assert.That(Driver.Title, Is.EqualTo("Clash Royale on the App Store")); // tests will fail because this string is not exaclty what we are expecting => this is a challenge FOR ME TO DO IT, BUT NOT NOW
        }

        [Test, Category("copydeck")]
        public void UsetOpensGooglePlay()
        {
            Royale.Pages.Pages.DeckBuilder.Goto().AddCardsManually();
            Royale.Pages.Pages.DeckBuilder.CopyDeckIcon();
            Royale.Pages.Pages.CopyDeck.ClickOnNoButton().OpenGooglePlay();

            Assert.AreEqual("Clash Royale - Apps on Google Play", Driver.Title); // here we caught a bug, because it is redirecting to the App store page
        } // we're repeating ourselves => next chapter = logging 
          //Logging is a very important strategy to programming because it helps us locate issues when we inevitably have to debug a problem.
    }
}