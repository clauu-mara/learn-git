using Framework.Models;
using OpenQA.Selenium;

namespace Royale.Pages
{
 public class CardDetailsPage: PageBase
 {
    public readonly CardDetailsPageMap Map;
    public CardDetailsPage(IWebDriver driver): base(driver)
    {
        Map= new CardDetailsPageMap(driver);
    }
    public (string Category, string Arena) GetCardCategory()
    {
        var category = Map.CardCategory.Text.Split(",");
        return (category[0].Trim(), category[1].Trim());
    } 

    public Card GetBaseCard()
    {
        var (category, arena)= GetCardCategory();
        return new Card
        {
            Name=Map.CardName.Text,
            Type=category,
            Arena=arena,
            Rarity=Map.CardRarity.Text
        };
    }

 }
 public class CardDetailsPageMap
 {
    IWebDriver _driver;
    public CardDetailsPageMap(IWebDriver driver)
    {
        _driver=driver;
    }
    //property?
    public IWebElement CardName => _driver.FindElement(By.CssSelector("div[class*='cardName']"));
    public IWebElement CardCategory => _driver.FindElement(By.CssSelector("div[class*='card__rarity']"));
    public IWebElement CardRarity => _driver.FindElement(By.CssSelector("div[class*='card__count']"));
 }
}