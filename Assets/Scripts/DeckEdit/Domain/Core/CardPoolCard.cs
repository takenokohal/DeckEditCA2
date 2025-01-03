namespace DeckEdit.Domain.Core
{
    public class CardPoolCard
    {
        public CardPoolCard(string key)
        {
            Key = key;
        }

        public string Key { get; }
    }
}