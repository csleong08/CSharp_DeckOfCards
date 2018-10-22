using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck
    {
        public List<Card> CardDeck = new List<Card>(); 
        public List<Card> CardDeck2 = new List<Card>();
        public string[] cStringVal = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
        public string[] cSuit = {"Clubs", "Spades", "Hearts", "Diamonds"}; 
        public int[] cVal = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13}; 

        public Deck()
        {
            for (int i = 0; i<cStringVal.Length; i++)
            {
                for (int j = 0; j<cSuit.Length; j++)
                {
                    Card card = new Card(cSuit[j], cStringVal[i]);
                    CardDeck.Add(card);
                    CardDeck2.Add(card);
                }
            }
        }
        public Card Deal()
        {
            Card dealt = CardDeck[0];
            CardDeck.RemoveAt(0);
            System.Console.WriteLine(dealt.cSuit);
            System.Console.WriteLine(dealt.cStringVal);
            System.Console.WriteLine(CardDeck.Count);
            return dealt;
        }
        public void Shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i<CardDeck.Count; i++)
            {
                Card temp = CardDeck[i];
                CardDeck[i] = CardDeck[rand.Next(CardDeck.Count)];
                CardDeck[rand.Next(CardDeck.Count)] = temp;
            }
        }
    }
}