using System;

    class ModBitAtGivPos
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            if (v==1)
            {
                n = n | mask;
                Console.WriteLine(n);
            }
            else if (v==0)
            {
                n = n & ~mask;
                Console.WriteLine(n);
            }
        }
    }

