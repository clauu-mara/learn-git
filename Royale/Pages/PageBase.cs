using OpenQA.Selenium;

namespace Royale.Pages
{
    public abstract class PageBase
    {
        public HeaderNav HeaderNav;
        public PageBase(IWebDriver driver)
        {
            HeaderNav= new HeaderNav(driver);
        }
    }
}