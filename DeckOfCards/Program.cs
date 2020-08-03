using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Player me = new Player("Justin");
            Player lili = new Player("Lili");
            Deck deck = new Deck();

            me.Draw(deck);
            me.Draw(deck);
            me.Draw(deck);
            me.Draw(deck);
            me.Draw(deck);
            lili.Draw(deck);
            lili.Draw(deck);
            lili.Draw(deck);
            lili.Draw(deck);
            lili.Draw(deck);
            me.PrintHand();
            lili.PrintHand();
            Card disc1 = me.Discard(0);
            Card disc2 = me.Discard(6);
            Card disc3 = lili.Discard(4);
            Console.WriteLine($"Discarded {disc1}");
            Console.WriteLine($"Discarded {disc2}");
            Console.WriteLine($"Discarded {disc3}");
            me.PrintHand();
            lili.PrintHand();
        }
    }
}
