using System;

    class House
    {
        static void Main()
        {
            char house = '*';
            char empty = '.';
            int n = int.Parse(Console.ReadLine());
            int mid = n / 2;
            int border = 0;
            double wll = Math.Floor((double)n / 4);

            Console.Write(new string(empty, mid));
            Console.Write(new string(house, 1));
            Console.Write(new string(empty, mid));
            Console.WriteLine();

            for (int row = 0; row < mid-1; row++)
            {
                Console.Write(new string(empty, mid  - border - 1));
                Console.Write(new string(house, 1));
                Console.Write(new string(empty, 1 + (2 * border)));
                Console.Write(new string(house, 1));
                Console.Write(new string(empty, mid  - border - 1));
                Console.WriteLine();
                border++;
            }
            Console.WriteLine(new string (house,n));
            for (int walls = 0; walls < mid-1; walls++)
            {
                Console.Write(new string(empty,(int)wll));
                Console.Write(new string(house, 1));
                Console.Write(new string(empty, n-2-2*((int)wll)));
                Console.Write(new string(house, 1));
                Console.Write(new string(empty, (int)wll));
                Console.WriteLine();
            }
            Console.Write(new string(empty, (int)wll));
            Console.Write(new string(house, n - 2 * (int)wll));
            Console.WriteLine(new string(empty, (int)wll));
        }
    }

