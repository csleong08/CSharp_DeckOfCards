using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Program
    {
        public static void Main(string[] args)
        {
            Player myPlayer = new Player("Pedro");
            Deck cardDeck = new Deck();
            foreach (var item in cardDeck.CardDeck)
            {
                System.Console.WriteLine(item.cSuit + "," + item.cStringVal);
            }
            cardDeck.Shuffle();
            System.Console.WriteLine("Shuffling Shuffling");
            foreach (var item in cardDeck.CardDeck)
            {
                System.Console.WriteLine(item.cSuit + "," + item.cStringVal);
            }
            
            myPlayer.Draw(cardDeck);
            myPlayer.Draw(cardDeck);
            myPlayer.Draw(cardDeck);
            myPlayer.Draw(cardDeck);
            myPlayer.Draw(cardDeck);
            myPlayer.Draw(cardDeck);
            myPlayer.Draw(cardDeck);

            myPlayer.Discard(5);

            // // Discard Method
            // Player myPlayer = new Player("Pedro");
            // Deck cardDeck = new Deck();
            // myPlayer.Discard(5);

            // // Draw Method
            // Player myPlayer = new Player("Pedro");
            // Deck cardDeck = new Deck();
            // myPlayer.Draw(cardDeck);

            // // Shuffle Method
            // Deck cardDeck = new Deck();
            // foreach (var item in cardDeck.CardDeck)
            // {
            //     System.Console.WriteLine(item.cSuit + "," + item.cStringVal);
            // }
            // cardDeck.Shuffle();
            // System.Console.WriteLine("Shuffling Shuffling");
            // foreach (var item in cardDeck.CardDeck)
            // {
            //     System.Console.WriteLine(item.cSuit + "," + item.cStringVal);
            // }

            // // Reset Method
            // Deck cardDeck = new Deck();
            // System.Console.WriteLine(cardDeck.CardDeck2.Count);

            // // Deal Method
            // Deck cardDeck = new Deck();
            // cardDeck.Deal();

            // // Initializing 52-card deck. 
            // Deck cardDeck = new Deck();
            // foreach (var item in cardDeck.CardDeck)
            // {
            //     System.Console.WriteLine(item.cSuit + "," + item.cStringVal);
            // }
        }
    }
}
