using System;

    class DecimalToBinary
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int bitCounter = input;
            int counter = 1;
            int abv = 0;
            while (bitCounter > 0)
            {
               counter = bitCounter / 2;               
               bitCounter = counter;
               abv++;
            }
            int[] binary = new int[abv];
            for (int i = abv-1; i >= 0; i--)
            {
                binary[i] = input % 2;
                input = input / 2;
            }
            for (int i = 0; i < abv; i++)
            {
                Console.Write(binary[i]);
            }
        }
    }

