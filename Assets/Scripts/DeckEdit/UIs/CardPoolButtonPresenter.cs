using DeckEdit.Domain;
using DeckEdit.Domain.Core;
using R3;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VContainer;

namespace DeckEdit.UIs
{
    public class CardPoolButtonPresenter : MonoBehaviour
    {
        [SerializeField] private Button button;

        [SerializeField] private TMP_Text text;

        private string _myKey;
        private Deck _deck;

        public void SetUp(string myKey, Deck deck)
        {
            _myKey = myKey;
            _deck = deck;
        }

        private void Start()
        {
            text.text = _myKey;
            button.OnClickAsObservable().Subscribe(_ => _deck.Add(new DeckCard(_myKey)));
        }
    }
}