namespace DeckOfCards
{   
    public class Card
    {
        public string  StringVal;
        public string Suit;
        public int Val;
    

        public Card(string StringValParam, string SuitParam, int ValParam)
        {
            StringVal = StringValParam;
            Suit = SuitParam;
            Val = ValParam;
        }

        public override string ToString()
        {
            return $"{StringVal} of {Suit}";
        }
    }
}