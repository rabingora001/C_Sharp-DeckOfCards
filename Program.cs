using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Rabin = new Player("rabin");
            Player Tapan = new Player("tapan");
            Player Max = new Player("max");

            Deck myDeck = new Deck();

            myDeck.Shuffle();

            Rabin.Draw(myDeck);
            Rabin.Draw(myDeck);

            Tapan.Draw(myDeck);
            Tapan.Draw(myDeck);

            Max.Draw(myDeck);
            Max.Draw(myDeck);
            
            System.Console.WriteLine(myDeck);
            System.Console.WriteLine(Rabin.Hand);
            System.Console.WriteLine(Tapan.Hand);
            System.Console.WriteLine(Max.Hand);
            foreach (Card card in Rabin.Hand)
            {
                System.Console.WriteLine(card);
            }
        }
    }
}
