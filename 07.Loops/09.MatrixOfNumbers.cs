using System;

    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            if (1 < n && n < 20)
            {
                int counter = 0;
                for (int j = 1; j <= n; j++)
                {
                   for (int i = j; i <= n+counter; i++)
                {
                    Console.Write(i + " ");
                }
                   Console.WriteLine();
                   counter++;
                }
               
            }
            else
            {
                Console.WriteLine("Enter n that is 1 < n < 20");
                Main();
            }
        }
    }

