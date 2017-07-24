using System;

namespace WarCardGame
{
    public class Game
    {
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }

        public Game(string playerOneName, string playerTwoName)
        {
            PlayerOne = new Player() { Name = playerOneName};
            PlayerTwo = new Player() { Name = playerTwoName};
        }

        public string playGame()
        {
            Deck deck = new Deck();

            string result = "";

            while (deck.ShuffleDeck.Count > 0)
            {
                result += dealCards(deck,PlayerOne);
                result += dealCards(deck,PlayerTwo);
            }
            return result;
        }

        private string dealCards(Deck deck, Player player)
        {
            Card dealCard = deck.ShuffleDeck[0];
            player.Card.Add(dealCard);
            deck.ShuffleDeck.Remove(dealCard);

            return printDealCards(dealCard, player);
        }

        private string printDealCards(Card dealCard, Player player)
        {
            string result = "";

            result += string.Format("<br/>{0}: {1}-{2}", player.Name, dealCard.Kind, dealCard.Value);

            return result;
        }
    }
}