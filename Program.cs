using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Rabin = new Player("rabin");
            Player Sumnima = new Player("tapan");
            Player Yesika = new Player("max");

            Deck myDeck = new Deck();

            myDeck.Shuffle();

            Rabin.Draw(myDeck);
            Rabin.Draw(myDeck);
            Rabin.Draw(myDeck);

            Sumnima.Draw(myDeck);
            Sumnima.Draw(myDeck);
            Sumnima.Draw(myDeck);

            Yesika.Draw(myDeck);
            Yesika.Draw(myDeck);
            Yesika.Draw(myDeck);
            
            System.Console.WriteLine(myDeck);
            System.Console.WriteLine(Rabin.Hand);
            System.Console.WriteLine(Sumnima.Hand);
            System.Console.WriteLine(Yesika.Hand);

            Console.WriteLine("**********Cards in Rabin's hanad: **********");
            foreach (Card card in Rabin.Hand)
            {
                System.Console.WriteLine(card);
            }

            Console.WriteLine("***********Cards in Sumnima's hanad:*********** ");
            foreach (Card card in Sumnima.Hand)
            {
                System.Console.WriteLine(card);
            }

            Console.WriteLine("***********Cards in Yesika's hanad: ************");
            foreach (Card card in Yesika.Hand)
            {
                System.Console.WriteLine(card);
            }
        }
    }
}
