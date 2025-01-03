using System.Collections.Generic;
using R3;

namespace DeckEdit.Domain.Core
{
    public class CardPool
    {
        private readonly List<CardPoolCard> _cardList = new();
        public IReadOnlyList<CardPoolCard> CardList => _cardList;

        public void Reset(IEnumerable<CardPoolCard> next)
        {
            _cardList.Clear();
            _cardList.AddRange(next);
            _onReset.OnNext(default);
        }

        private readonly Subject<Unit> _onReset = new();
        public Observable<Unit> OnReset => _onReset;
    }
}