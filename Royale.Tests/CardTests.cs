using Framework.Selenium;
using Framework.Services;
using Royale.Pages;

namespace Royale.Tests;

public class CardTests
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
    public void IceSpiritIsOnCardsPageTest()
    {
        var iceSpiritCard = Royale.Pages.Pages.Cards.GoTo().GetCardByName("Ice Spirit");
        Assert.That(iceSpiritCard.Displayed);
    }
   /* [Test]
    public void IceSpiritHeadersAreCorrectOnCardDetailsPageTest()
    {
       new CardsPage( Driver.Current).GoTo().GetCardByName("Ice Spirit").Click();
       var cardDetails = new CardDetailsPage( Driver.Current);

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
    //refactoring -> this test method is now 2 test cases */
     static string[] cardNames={"Ice Spirit", "Mirror"};

     [Test, Category("cards")] // to can filter tests when running them
     [TestCaseSource("cardNames")]
     [Parallelizable(ParallelScope.Children)]// because we have a caseSource and we split up tests to run in parallel/ concurrently
    public void CardHeadersAreCorrectOnCardDetailsPageTest(string cardName)
    {
       Royale.Pages.Pages.Cards.GoTo().GetCardByName(cardName).Click();

       var cardOnPage = Royale.Pages.Pages.CardDetails.GetBaseCard();
       var card = new InMemoryCardService().GetCardByName(cardName);

       Assert.AreEqual(card.Name,cardOnPage.Name);
       Assert.AreEqual(card.Type,cardOnPage.Type);
       Assert.AreEqual(card.Arena, cardOnPage.Arena);
       Assert.AreEqual(card.Rarity, cardOnPage.Rarity);
    }
    // tests are failing
    // 2 tests cannot run in parallel using the same instance of webdriver => using a static/global webdriver in every test is not so fun 
    // => but there is a solution: using multiple instances of webdriver being able to use it like a static driver
    // verify why my tests are not passing
}