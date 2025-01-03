using Cysharp.Threading.Tasks;
using DeckEdit.Domain.UseCases;
using VContainer.Unity;

namespace DeckEdit.God
{
    public class StartUp : IInitializable
    {
        private readonly CardPoolReset _cardPoolReset;

        public StartUp(CardPoolReset cardPoolReset)
        {
            _cardPoolReset = cardPoolReset;
        }

        public void Initialize()
        {
            UniTask.Void(async () =>
            {
                await UniTask.Yield();
                _cardPoolReset.Reset();
            });
        }
    }
}