using System;

    class SumOfNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double ans = 0;
            for (int i = 0; i < n; i++)
            {
                ans += double.Parse(Console.ReadLine());
            }
            Console.WriteLine(ans);
        }
    }

