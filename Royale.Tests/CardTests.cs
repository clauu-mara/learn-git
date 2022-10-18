using Framework.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Royale.Pages;

namespace Royale.Tests;

public class CardTests
{
    IWebDriver driver;

    [SetUp]
    public void BeforeEach()
    {
       driver= new ChromeDriver(Path.GetFullPath(@"../../../../"+"_drivers"));
       driver.Url= "https://statsroyale.com";
    }

    [TearDown]
    public void AfterEach()
    {
        driver.Quit();
    }

    [Test]
    public void IceSpiritIsOnCardsPageTest()
    {
        var cardPage = new CardsPage(driver);
        var iceSpiritCard = cardPage.GoTo().GetCardByName("Ice Spirit");
        Assert.That(iceSpiritCard.Displayed);
    }
    [Test]
    public void IceSpiritHeadersAreCorrectOnCardDetailsPageTest()
    {
       new CardsPage(driver).GoTo().GetCardByName("Ice Spirit").Click();
       var cardDetails = new CardDetailsPage(driver);

       var (cardCategory, cardArena) = cardDetails.GetCardCategory();
       var cardName = cardDetails.Map.CardName.Text;
       var cardRarity = cardDetails.Map.CardRarity.Text;

       Assert.AreEqual("Ice Spirit",cardName);
       Assert.AreEqual("Troop",cardCategory);
       Assert.AreEqual("Arena 8", cardArena);
       Assert.AreEqual("Common", cardRarity);
    }
     [Test]
    public void MirrorHeadersAreCorrectOnCardDetailsPageTest()
    {
       new CardsPage(driver).GoTo().GetCardByName("Mirror").Click();
       var cardDetails = new CardDetailsPage(driver);

       var card = cardDetails.GetBaseCard();
       var mirror = new MirrorCard();

       Assert.AreEqual(mirror.Name,card.Name);
       Assert.AreEqual(mirror.Type,card.Type);
       Assert.AreEqual(mirror.Arena, card.Arena);
       Assert.AreEqual(mirror.Rarity, card.Rarity);
    }
}