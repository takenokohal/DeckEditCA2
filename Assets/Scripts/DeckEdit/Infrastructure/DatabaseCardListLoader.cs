using System.Collections.Generic;
using System.Linq;
using Databases;
using DeckEdit.Domain.UseCases;
using VContainer;

namespace DeckEdit.Infrastructure
{
    public class DatabaseCardListLoader : ICardListLoader
    {
        [Inject] private readonly CardDatabase _database;
        
        public IEnumerable<string> LoadCardList()
        {
            return _database.CardDatas.Select(value => value.cardKey);
        }
    }
}