//and we need to create our deck 

using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;

namespace CardDeck1
{
    class Deck
    {
        // deck is a list 
        private List<Card> deck { get; set; } = new List<Card>() { }; // Encapsulated deck

        public Deck()
        {
        }

        // Method to create decks based on the number of decks required
        public void CreateDeck(int deckNumber)
        {
            // Define the colors, suits, values, and symbols for cards
            string[] suits = { "Spades", "Hearts", "Diamonds", "Clubs" };
            string[] values = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            char[] symbols = { '♠', '♥', '♦', '♣' };

            // Create a dictionary to map suits to their symbols
            Dictionary<string, char> cardWithSymbol = new Dictionary<string, char>();

            for (int c = 0; c < suits.Length; c++)
            {
                // Allocate card symbols into dictionary
                cardWithSymbol[suits[c]] = symbols[c];
            }

            // Loop for the number of decks
            for (int d = 0; d < deckNumber; d++)
            {
                for (int i = 0; i < suits.Length; i++)
                {
                    for (int j = 0; j < values.Length; j++)
                    {
                        // Determine the card color based on the suit
                        string color = (suits[i] == "Hearts" || suits[i] == "Diamonds") ? "Red" : "Black";

                        // Create a card
                        Card card = new Card()
                        {
                            Suit = suits[i],
                            Value = values[j],
                            Symbol = cardWithSymbol[suits[i]],
                            Color = color
                        };

                        // Add the card to the deck
                        this.deck.Add(card);
                    }
                }
            }
        }

        // Method to retrieve the deck
        public List<Card> GetDeck()
        {
            return deck;
        }



        //we need to shuffle deck

        public void Shuffle()
        {
            Random random = new Random();
            int n = deck.Count;

            for (int i = n - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1); // Get random index
                (deck[i], deck[j]) = (deck[j], deck[i]); // Swap elements
            }
        }


        //player gets a card from deck 

        public Card Pop()
        {
            //first check if deck zero or not 

            if (deck.Count == 0)
            {
                throw new InvalidOperationException("The Deck is Empty");

            }
            //get card
            Card card = deck[deck.Count - 1];

            //remove last card
            deck.RemoveAt(deck.Count - 1);

            //check if we created correct 
            Console.WriteLine(deck.Count);
            return card;
        }



        // Method to display the deck (optional, for debugging purposes)
        public void DisplayDeck()
        {
            foreach (var card in deck)
            {
                Console.WriteLine(card.ToString());
            }
        }

        //and we can also show graphic version 
        public void GraphicDeck()
        {
            foreach (var card in deck)
            {
                card.DrawCard(); //we called draw card method 
            }
        }
    }
}
