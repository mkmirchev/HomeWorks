using System;

    class TrailingZerosInN
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int div = 5;
            while (div<n)
            {
                counter += n / div;
                div *= 5;
            }                    
            Console.WriteLine(counter);
        }
    }

