using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck{
        public List<Card> Cards = new List<Card>();
        public Deck() {
            MakeDeck();
        }

        private void MakeDeck()
        {
            Cards.Clear();
            
            string [] Suits = {"Clubs","Diamond","Spades","Hearts"};
            string[] CardVals = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};

            for(int i=0; i<Suits.Length; i++ ){
                for(int j=0; j<CardVals.Length; j++){
                    
                    // System.Console.Write(CardVals[j]);
                    // System.Console.WriteLine(" of " + Suits[i] );

                    Cards.Add(new Card( CardVals[j], Suits[i], j+1));
                }   
            }
        }

        public Card Deal(){
            Card ReturnCard = Cards[0];
            Cards.RemoveAt(0);
            return ReturnCard;
        }


        public void Shuffle()
        {
            for(int i=0; i<Cards.Count; i++){
                Random rand = new Random();
                int Switch = rand.Next(Cards.Count);

                Card temp = Cards[i];
                Cards[i] = Cards[Switch];
                Cards[Switch] = temp;
            }
        }

        public void Reset(){
            MakeDeck();
        }

    }
}