using ObservableCollections;

namespace DeckEdit.Domain.Core
{
    public class Deck
    {
        private readonly ObservableList<DeckCard> _deckCards = new();
        public void Add(DeckCard deckCard) => _deckCards.Add(deckCard);
        public void Remove(DeckCard deckCard) => _deckCards.Remove(deckCard);
        public IReadOnlyObservableList<DeckCard> DeckCards => _deckCards;
    }
}
