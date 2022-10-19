using Framework.Models;
using Framework.Selenium;
using OpenQA.Selenium;

namespace Royale.Pages
{
    public class CardDetailsPage : PageBase
    {
        public readonly CardDetailsPageMap Map;
        public CardDetailsPage()
        {
            Map = new CardDetailsPageMap();
        }
        public (string Category, string Arena) GetCardCategory()
        {
            var category = Map.CardCategory.Text.Split(",");
            return (category[0].Trim(), category[1].Trim());
        }

        public Card GetBaseCard()
        {
            var (category, arena) = GetCardCategory();
            return new Card
            {
                Name = Map.CardName.Text,
                Type = category,
                Arena = arena,
                Rarity = Map.CardRarity.Text
            };
        }

    }
    public class CardDetailsPageMap
    {
        //property?
        public IWebElement CardName => (IWebElement)Driver.FindElement(By.CssSelector("div[class*='cardName']"));
        public IWebElement CardCategory => (IWebElement)Driver.FindElement(By.CssSelector("div[class*='card__rarity']"));
        public IWebElement CardRarity => (IWebElement)Driver.FindElement(By.CssSelector("div[class*='card__count']"));
    }
}