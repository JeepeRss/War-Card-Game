using System.Collections.Generic;

namespace WarCardGame
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public List<Card> Card { get; set; }

        public Player()
        {
            this.Card = new List<Card>();
            
        }
    }
}