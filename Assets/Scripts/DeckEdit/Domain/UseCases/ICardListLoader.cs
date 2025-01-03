using System.Collections.Generic;

namespace DeckEdit.Domain.UseCases
{
    public interface ICardListLoader
    {
        public IEnumerable<string> LoadCardList();
    }
}