using System;
using System.Data;



    class CombinationFotmula
    {
        static void Main()
        {
            Console.WriteLine("Enter value of N > 1");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of K<n<100");
            double k = double.Parse(Console.ReadLine());

            double factorialN = 1;
            double factorialK = 1;

            if (1 < k && n > k && n < 100)
            {              
                for (double i = k + 1; i <= n; i++)
                {
                    factorialN *= i;
                }
                for (double j = 1; j <= (n - k); j++)
                {
                    factorialK *= j;
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            double result = factorialN / factorialK;
            Console.WriteLine("N! / K!(N-K)! = {0}", result);
        }
    }

