using System;
using System.Collections.Generic;

namespace WarCardGame
{
    public class Deck
    {
        public List<Card> _deck { get; set; }
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }
        private Random _random { get; set; }

        public Deck()
        {
            _deck = new List<Card>();
            _random = new Random();
            PlayerOne = new Player();
            PlayerTwo = new Player();
         
            string[] kinds = new[] { "Clubs", "Hearts", "Diamonds", "Spades" };
            string[] values = new[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Dolek", "Queen", "King", "Ace" };

            foreach (var kind in kinds)
            {
                foreach (var value in values)
                {
                    Card card = new Card() {Kind = kind, Value = value};
                    _deck.Add(card);
                }
            }
        }

        public void pickCard(Player player)
        {
            int pickedIndex = _random.Next(_deck.Count);
            Card pickedCard = _deck[pickedIndex];
            player.Card.Add(pickedCard);
            _deck.RemoveAt(pickedIndex);   
        }

        public void dealAllCards()
        {
            while (_deck.Count > 0)
            {
                pickCard(PlayerOne);
                pickCard(PlayerTwo);
            }
        }
    }
}