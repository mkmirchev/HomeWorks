using System;

    class CheckBitAtPos
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int pos = int.Parse(Console.ReadLine());
            int checker = (num >> pos) & 1;
            Console.WriteLine(checker==1? "True":"False");
        }
    }

