using System;
using System.Linq;
using System.Collections.Generic;

    class CatalanNumbs
    {
        static void Main()
        {
            Console.WriteLine("Enter value of 1< N < 100");
            int n = int.Parse(Console.ReadLine());
            decimal fact2N = 1;
            decimal factN = 1;
            for (int i = 2*n; i > n+1; i--)
            {
                fact2N *= i;
            }
            for (int j = 1; j <= n; j++)
            {
                factN *= j;
            }
            decimal result = fact2N * (1/factN);
            //Console.WriteLine(fact2N);
            //Console.WriteLine(factN);
            Console.WriteLine("{0:F0}", result);
        }
    }

