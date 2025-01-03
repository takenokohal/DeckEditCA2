using DeckEdit.Domain;
using DeckEdit.Domain.Core;
using R3;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DeckEdit.UIs
{
    public class DeckCardButtonPresenter : MonoBehaviour
    {
        private Deck _deck;

        [SerializeField] private Button button;
        [SerializeField] private TMP_Text text;
        

        private DeckCard _deckCard;

        public void SetUp(DeckCard deckCard, Deck deck)
        {
            _deckCard = deckCard;
            _deck = deck;
        }

        private void Start()
        {
            button.OnClickAsObservable().Subscribe(_ => _deck.Remove(_deckCard)).AddTo(this);

            text.text = _deckCard.Key;
        }
    }
}