using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Player
    {
        public string Name;
        public List<Card> Hand;

        public Player(string name){
            Name=name;
            Hand = new List<Card>();
        }

        public Card Draw(Deck deck){
            Card DrawCard = deck.Deal();
            Hand.Add(DrawCard);
            return DrawCard;
        }

        public Card Discard(int index)
        {
            if (Hand[index] != null)
            {
                Card dcard = Hand[index];
                Hand.Remove(dcard);
                return dcard;
            }
            return null;
        }
        public void SeeHand()
        {
            foreach (var card in Hand)
            {
                Console.WriteLine(card);
            }
}
    }
}