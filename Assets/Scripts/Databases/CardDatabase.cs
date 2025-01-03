using System;
using System.Collections.Generic;
using UnityEngine;

namespace Databases
{
    [CreateAssetMenu(menuName = "Create CardDatabase", fileName = "CardDatabase", order = 0)]
    public class CardDatabase : ScriptableObject
    {
        [Serializable]
        public class CardData
        {
            public string cardKey;
        }

        [SerializeField] private List<CardData> cardDatas;
        public IReadOnlyList<CardData> CardDatas => cardDatas;
    }
}