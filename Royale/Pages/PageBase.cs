namespace Royale.Pages
{
    public abstract class PageBase
    {
        public HeaderNav HeaderNav;
        public PageBase()
        {
            HeaderNav = new HeaderNav();
        }
    }
}