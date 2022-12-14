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
        public Element CardName => Driver.FindElement(By.CssSelector("div[class*='cardName']"),"CardName");
        public Element CardCategory => Driver.FindElement(By.CssSelector("div[class*='card__rarity']"), "Card Category");
        public Element CardRarity => Driver.FindElement(By.CssSelector("div[class*='card__count']"), "Card Rarity");
    }
}