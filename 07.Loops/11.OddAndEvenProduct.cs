using System;

    class OddAndEvenProduct
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] dataIn = input.Split(' ');
            int oddSum = 1;
            int evenSum = 1;
            for (int i = 0; i < dataIn.Length; i++)
            {
                oddSum *= Convert.ToInt32(dataIn[i]);
                i++;
            }
            for (int j = 1; j < dataIn.Length; j++)
            {
                evenSum *= Convert.ToInt32(dataIn[j]);
                j++;
            }
            if (oddSum==evenSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("product = {0}", oddSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Odd_Product = {0}", oddSum);
                Console.WriteLine("Even_Product = {0}", evenSum);
            }
        }
    }

