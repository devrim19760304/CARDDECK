//color: red for hearts and diamonds black for spades and clubs 
//suit: Spades, Hearts,Diamonds, Clubs 
//value: Ace, 2,3,.... Jack , Queen , King 

using System.Linq.Expressions;

namespace CardDeck1
{

    class Card
    {

        public string Color { get; set; } = "";
        public string Value { get; set; } = "";

        public string Suit { get; set; } = "";

        public char Symbol { get; set; }


        public Card()
        {

        }

        //print 
        public override string ToString()
        {
            return $"{Value} of {Suit} ({Color}) {Symbol}";

        }


        public void DrawCard()
        {
            // Card details
            string color = this.Color;
            string value = this.Value;
            string suit = this.Suit;
            char symbol = this.Symbol;
            //to create same size i prefer to get first letter of chart 
            char shortValue = this.Value[0];


            // Create a card with the value and symbol properly aligned
            string cardShape = $@"
    ╔══════════╗
    ║{shortValue}         ║
    ║          ║
    ║    {symbol}     ║
    ║          ║
    ║       {shortValue}  ║
    ╚══════════╝
";

            string cardShape1 = $@"
    ╔══════════╗
    ║{shortValue}░░░░░░░░░║
    ║░░░░░░░░░░║
    ║░░░░{symbol}░░░░░║
    ║░░░░░░░░░░║
    ║░░░░░░░░{shortValue}░║
    ╚══════════╝";


            // Print the card
            Console.ForegroundColor = color == "Red" ? ConsoleColor.Red : ConsoleColor.White;
            Console.WriteLine(cardShape1);
            Console.ResetColor();
        }

    }
}