using System;

    class PrintADeckOf52Cards
    {
        static void Main()
        {
            char[] cardSymbols = { '\u0003', '\u0004', '\u0005', '\u0006'};
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            for (int i = 0; i < cards.Length; i++)
            {
                for (int symbol = 0; symbol < 4; symbol++)
                {
                    Console.Write(cards[i]+cardSymbols[symbol] + " ");
                }
                Console.WriteLine();
            }
        }
    }

