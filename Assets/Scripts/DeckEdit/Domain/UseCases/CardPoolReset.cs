using System.Linq;
using DeckEdit.Domain.Core;

namespace DeckEdit.Domain.UseCases
{
    public class CardPoolReset
    {
        private readonly CardPool _cardPool;
        private readonly ICardListLoader _cardListLoader;

        public CardPoolReset(CardPool cardPool, ICardListLoader cardListLoader)
        {
            _cardPool = cardPool;
            _cardListLoader = cardListLoader;
        }

        public void Reset()
        {
            var list = _cardListLoader.LoadCardList();
            _cardPool.Reset(list.Select(value => new CardPoolCard(value)));
        }
    }
}