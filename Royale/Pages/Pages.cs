namespace Royale.Pages
{
    public static class Pages
    {
        //declared
        [ThreadStatic]
        public static CardsPage Cards;

        [ThreadStatic]
        public static CardDetailsPage CardDetails;

        [ThreadStatic]
        public static DeckBuilderPage DeckBuilder;

        [ThreadStatic]
        public static CopyDeckPage CopyDeck;

        //initialized
        public static void Init()
        {
            Cards = new CardsPage();
            CardDetails = new CardDetailsPage();
            DeckBuilder = new DeckBuilderPage();
            CopyDeck = new CopyDeckPage();
        }
    }
}