using Framework.Models;

namespace Framework.Services
{
    public interface ICardService
    {
        public Card GetCardByName(string cardName);
    }
}