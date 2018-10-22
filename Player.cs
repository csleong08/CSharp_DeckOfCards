using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Player
    {
        public string pName;
        public List<Card> pHand = new List<Card>();
        public Player(string name)
        {
           pName = name; 
        }
        
        public Card Draw(Deck cardDeck)
        {
            System.Console.WriteLine("DRAW");
            Card draw = cardDeck.CardDeck[0];
            System.Console.WriteLine(draw.cSuit + "," + draw.cStringVal);
            pHand.Add(draw);
            cardDeck.CardDeck.RemoveAt(0);
            foreach (var item in pHand)
            {
                System.Console.WriteLine(item.cSuit + "," + item.cStringVal);
            }
            return draw;
        }
        
        public Card Discard(int idx)
        {   
            if (idx > pHand.Count)
            {
                System.Console.WriteLine("null");
                return null;
            }
            else
            {
                System.Console.WriteLine("DISCARD");
                Card discard = pHand[idx];
                System.Console.WriteLine(discard.cSuit + "," + discard.cStringVal);
                pHand.RemoveAt(idx);
                return discard;
            }
        }
    }
}