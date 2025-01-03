using System.Collections.Generic;
using DeckEdit.Domain;
using DeckEdit.Domain.Core;
using ObservableCollections;
using R3;
using UnityEngine;
using VContainer;

namespace DeckEdit.UIs.Binder
{
    public class DeckCardButtonBinder : MonoBehaviour
    {
        [Inject] private readonly Deck _deck;

        [SerializeField] private DeckCardButtonPresenter deckCardButtonPrefab;

        private readonly Dictionary<DeckCard, DeckCardButtonPresenter> _instances = new();

        private void Start()
        {
            _deck.DeckCards.ObserveAdd()
                .Subscribe(value => OnAdd(value.Value)).AddTo(this);

            _deck.DeckCards.ObserveRemove()
                .Subscribe(value => OnRemove(value.Value)).AddTo(this);
        }

        private void OnAdd(DeckCard deckCard)
        {
            var instance = Instantiate(deckCardButtonPrefab, transform);
            instance.SetUp(deckCard, _deck);

            _instances.Add(deckCard, instance);
        }

        private void OnRemove(DeckCard deckCard)
        {
            var instance = _instances[deckCard];
            Destroy(instance.gameObject);
            _instances.Remove(deckCard);
        }
    }
}