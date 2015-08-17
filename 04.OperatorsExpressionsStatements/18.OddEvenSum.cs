using System;

    class OddEvenSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 1; i <= 2*n; i++)
            {
                int p = int.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    evenSum += p;   
                }
                else
                {
                    oddSum += p;
                }
            }
            if (evenSum==oddSum)
            {
                Console.WriteLine("Yes, sum=" + evenSum);
            }
            else
            {
                Console.WriteLine("No, Diff=" + Math.Abs(evenSum-oddSum));
            }
        }
    }

