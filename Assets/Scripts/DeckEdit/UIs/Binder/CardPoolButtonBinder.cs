using System.Collections.Generic;
using DeckEdit.Domain;
using DeckEdit.Domain.Core;
using R3;
using UnityEngine;
using VContainer;

namespace DeckEdit.UIs.Binder
{
    public class CardPoolButtonBinder : MonoBehaviour
    {
        [Inject] private readonly CardPool _cardPool;
        [Inject] private readonly Deck _deck;

        [SerializeField] private CardPoolButtonPresenter buttonPrefab;
        
        private readonly List<CardPoolButtonPresenter> _instances = new();

        private void Start()
        {
            _cardPool.OnReset.Subscribe(_ => OnReset()).AddTo(this);
        }

        private void OnReset()
        {
            foreach (var cardPoolButtonPresenter in _instances)
            {
                Destroy(cardPoolButtonPresenter.gameObject);
            }

            var list = _cardPool.CardList;
            foreach (var cardPoolCard in list)
            {
                var instance = Instantiate(buttonPrefab, transform);
                instance.SetUp(cardPoolCard.Key, _deck);
                _instances.Add(instance);
            }
        }
    }
}