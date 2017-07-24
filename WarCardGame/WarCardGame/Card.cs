namespace WarCardGame
{
    public class Card
    {
        public string Kind { get; set; }
        public string Value { get; set; }

        public int CardValue()
        {
            switch (Value)
            {
                case "Jack":
                    return 11;
                    
                case "Queen":
                    return 12;

                case "King":
                    return 13;

                case "Ace":
                    return 14;

                default: return int.Parse(Value);
                    break;
            }
        }
    }
}