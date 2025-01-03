namespace DeckEdit.Domain.Core
{
    public class DeckCard
    {
        public DeckCard(string key)
        {
            Key = key;
        }

        public string Key { get; }
    }
}