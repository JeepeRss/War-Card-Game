using System;
using System.Collections.Generic;

namespace WarCardGame
{
    public class Deck
    {
        private List<Card> _deck { get; set; }
        private Random _random { get; set; }


        public List<Card> ShuffleDeck { get; set; }
        

        public Deck()
        {
            _deck = new List<Card>();
            _random = new Random();
            ShuffleDeck = new List<Card>();

            string[] kinds = new[] { "Clubs", "Hearts", "Diamonds", "Spades" };
            string[] values = new[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            foreach (var kind in kinds)
            {
                foreach (var value in values)
                {
                    Card card = new Card() {Kind = kind, Value = value};
                    _deck.Add(card);
                }
            }

            shuffleCards();
        }

        private void shuffleCards()
        {
            while (_deck.Count > 0)
            {
                int shuffleIndex = _random.Next(_deck.Count);
                Card pickedCard = _deck[shuffleIndex];
                ShuffleDeck.Add(pickedCard);
                _deck.RemoveAt(shuffleIndex);
            }
        }
    }
}