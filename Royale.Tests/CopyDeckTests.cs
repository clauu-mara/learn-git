using Framework.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Royale.Tests
{
    public class CopyDeckTests
    {
        [SetUp]
    public void BeforeEach()
    {
        Driver.Init(); //something unclear...
        Royale.Pages.Pages.Init();
        Driver.GoTo("https://statsroyale.com");
    }

    [TearDown]
    public void AfterEach()
    {
         Driver.Current.Quit();
    }
    [Test]
    public void UserCanCopyTheDeckTest()
    {
       // var wait = new WebDriverWait(Driver.Current, TimeSpan.FromSeconds(10)); I forgot to remove this one
        Royale.Pages.Pages.DeckBuilder.Goto();
        Royale.Pages.Pages.DeckBuilder.AddCardsManually();
        Royale.Pages.Pages.DeckBuilder.CopyDeckIcon();
        Royale.Pages.Pages.CopyDeck.ClickOnYesButton();        

        Assert.That(Royale.Pages.Pages.CopyDeck.CopiedMessageIsDisplayed);
    } 

    }
}