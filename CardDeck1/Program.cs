
using System;

namespace CardDeck1
{

    internal class Program()
    {

        static void Main(string[] args)

        {

            Console.Beep();

            //call my deck 
            Deck playDeck = InitDeck();
            //display 
            //playDeck.DisplayDeck();
            //later graphic version
            //playDeck.GraphicDeck();

            int counter = 0;

            while (counter <= 10)
            {

                Card playerCard = playDeck.Pop();
                playerCard.DrawCard();
                counter++;


            }



        }


        public static Deck InitDeck()
        {

            //create, populate and shuffle 1 deck 
            Deck playDeck = new Deck();
            playDeck.CreateDeck(1);
            playDeck.Shuffle();
            return playDeck;

        }
    }
}