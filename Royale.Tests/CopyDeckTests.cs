using Framework.Selenium;
using OpenQA.Selenium;

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
        //go to deck builder page
        //Driver.Current.FindElement(By.CssSelector("[href='/deckbuilder']")).Click(); // hmmm, why only using current?
        Royale.Pages.Pages.DeckBuilder.Goto();
        //Click add cards manually
        Royale.Pages.Pages.DeckBuilder.AddCardsManually();
        //click copy deck icon
        Royale.Pages.Pages.DeckBuilder.CopyDeckIcon();
        //click yes
        Royale.Pages.Pages.CopyDeck.ClickOnYesButton();
        //assert the if click yes message is displayed

        // I changed here, he used: Pages.CopyDeck.Map.CopiedMessage.Displayed 
        Assert.That(Royale.Pages.Pages.CopyDeck.CopiedMessageIsDisplayed);
        // test failed because it moves to fast so we need to use wait 
    }

    }
}