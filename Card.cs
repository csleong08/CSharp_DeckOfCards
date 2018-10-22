using System.Collections.Generic;

namespace DeckOfCards
{
    public class Card
    {
        public string cStringVal;
        public string cSuit;
        public int cVal;
        public Card(string suit, string stringVal)
        {
            cSuit = suit;
            cStringVal = stringVal;
        }
    }
}