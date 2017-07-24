using System;
using System.Collections.Generic;

namespace WarCardGame
{
    public class Game
    {
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }
        public List<Card> _bounty { get; set; }

        public Game(string playerOneName, string playerTwoName)
        {
            PlayerOne = new Player() { Name = playerOneName};
            PlayerTwo = new Player() { Name = playerTwoName};
            _bounty = new List<Card>();
        }

        public string DealCards()
        {
            Deck deck = new Deck();

            string result = "";

            while (deck.ShuffleDeck.Count > 0)
            {
                result += getCard(deck,PlayerOne);
                result += getCard(deck,PlayerTwo);
            }
            return result;
        }

        public string PlayGame()
        {
            string results = "";
            int round = 0;
            while (round < 15)
            {
                _bounty.Clear();
                int playerOneCard = getCardOnTable(PlayerOne);
                int playerTwoCard = getCardOnTable(PlayerTwo);

                results += battleBegins(playerOneCard, playerTwoCard);
                round++;
            }
            results += printFinalResults(PlayerOne, PlayerTwo);
            return results;
        }

        private string printFinalResults(Player playerOne, Player playerTwo)
        {
            string result = "";
             if (playerOne.Card.Count > playerTwo.Card.Count)
            {
                result += string.Format("<br/>-----------------The winner is {0} with {1} cards", playerOne.Name, playerOne.Card.Count);
            }
             else
            {
                result += string.Format("<br/>-----------------The winner is {0} with {1} cards", playerTwo.Name, playerTwo.Card.Count);
            }
            return result;
        }

        private int getCardOnTable(Player player)
        {
            foreach (var plCard in player.Card)
            {
                int playerCard = plCard.CardValue();
                _bounty.Add(plCard);
                player.Card.Remove(plCard);
                return playerCard;
            }
            return 0;
        }

        private string warBegins(Player playerOne, Player playerTwo)
        {
            string result = "";
            result += string.Format("...................WAAAAAR BEGIN!!!!.....................");
            int pl1card1 = getCardOnTable(PlayerOne);
            int pl1card2 = getCardOnTable(PlayerOne);
            int pl1card3 = getCardOnTable(PlayerOne);

            int pl2card1 = getCardOnTable(PlayerTwo);
            int pl2card2 = getCardOnTable(PlayerTwo);
            int pl2card3 = getCardOnTable(PlayerTwo);

            result += battleBegins(pl1card3, pl2card3);

            return result;
        }

        private string battleBegins(int playerOneCard, int playerTwoCard)
        {
            if (playerOneCard > playerTwoCard)
            {
                return bountyWinner(PlayerOne);
            }
            if (playerOneCard < playerTwoCard)
            {
                return bountyWinner(PlayerTwo);
            }
            else
            {
                return warBegins(PlayerOne, PlayerTwo);
            }
        }

        private string bountyWinner(Player player)
        {
            player.Card.AddRange(_bounty);
            return printBattleDetails(_bounty, player);
        }

        private string getCard(Deck deck, Player player)
        {
            Card dealCard = deck.ShuffleDeck[0];
            player.Card.Add(dealCard);
            deck.ShuffleDeck.Remove(dealCard);

            return printDealCards(dealCard, player);
        }

        private string printBattleDetails(List<Card> bounty, Player player)
        {
            string result = "";
            result += string.Format("<br/>.............BATTLE BEGINS.............");
            result += string.Format("<br/>{0} win the battle and takes...", player.Name);
            foreach (var cards in bounty)
            {
                result += string.Format("<br/>{0} {1}", cards.Kind, cards.Value);
            }
            return result;
        }

   
        private string printDealCards(Card dealCard, Player player)
        {
            string result = "";

            result += string.Format("<br/>{0}: {1}-{2}", player.Name, dealCard.Kind, dealCard.Value);

            return result;
        }
    }
}