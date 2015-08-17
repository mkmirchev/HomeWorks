using System;

    class ExtractBit3
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int checker = (num >> 3) & 1;
            Console.WriteLine(checker);
            
        }
    }

