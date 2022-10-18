using Framework.Models;
using Framework.Services;
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
    // these are NUnit attributes
    // these tests are running one by one => we want them to run in parallel
    //refactoring -> this test method is now 2 test cases
     static string[] cardNames={"Ice Spirit", "Mirror"};

     [Test,Category("Cards")] // to can filter tests when running them
     [TestCaseSource("cardNames")]
     [Parallelizable(ParallelScope.Children)]// because we have a caseSource and we split up tests to run in parallel/ concurrently
    public void MirrorHeadersAreCorrectOnCardDetailsPageTest(string cardName)
    {
       new CardsPage(driver).GoTo().GetCardByName(cardName).Click();
       var cardDetails = new CardDetailsPage(driver);

       var cardOnPage = cardDetails.GetBaseCard();
       var card = new InMemoryCardService().GetCardByName(cardName);

       Assert.AreEqual(card.Name,cardOnPage.Name);
       Assert.AreEqual(card.Type,cardOnPage.Type);
       Assert.AreEqual(card.Arena, cardOnPage.Arena);
       Assert.AreEqual(card.Rarity, cardOnPage.Rarity);
    }
}