using Framework;
using Framework.Models;
using Framework.Selenium;
using Framework.Services;
using Royale.Pages;

namespace Royale.Tests
{
    public class CardTests
    {
        [OneTimeSetUp]
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
            Driver.Quit();
        }

        static IList<Card> apiCards = new ApiCardService().GetAllCards();

        [Test, Category("cards")] // i forgot about it or maybe I deleted, idk
        [TestCaseSource("apiCards")]
        [Parallelizable(ParallelScope.Children)]
        public void CardOnPageTest(Card card)
        {
            var _cardOnPage = Royale.Pages.Pages.Cards.GoTo().GetCardByName(card.Name);
            Assert.That(_cardOnPage.Displayed);
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

        // we don't need it anymore since we use API cards
        //static string[] cardNames={"Ice Spirit", "Mirror"};

        [Test, Category("cards")] // to can filter tests when running them
        [TestCaseSource("apiCards")]
        [Parallelizable(ParallelScope.Children)]// because we have a caseSource and we split up tests to run in parallel/ concurrently
        public void CardHeadersAreCorrectOnCardDetailsPageTest(Card card)
        {
            Royale.Pages.Pages.Cards.GoTo().GetCardByName(card.Name).Click();

            var cardOnPage = Royale.Pages.Pages.CardDetails.GetBaseCard();
            // we are passing in the card as an argument
            //var card = new InMemoryCardService().GetCardByName(card.Name);

            Assert.AreEqual(card.Name, cardOnPage.Name);
            Assert.AreEqual(card.Type, cardOnPage.Type);
            Assert.AreEqual(card.Arena, cardOnPage.Arena);
            Assert.AreEqual(card.Rarity, cardOnPage.Rarity);
        }
        // tests are failing
        // 2 tests cannot run in parallel using the same instance of webdriver => using a static/global webdriver in every test is not so fun 
        // => but there is a solution: using multiple instances of webdriver being able to use it like a static driver
        // verify why my tests are not passing

        //loggin for tests that run in paralle => a single directory is created using the test => race condition
        // lock -> forces the workers to wait in line until the current worker exits the lock
    }
}