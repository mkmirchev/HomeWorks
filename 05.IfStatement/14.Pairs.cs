using System;

    class Pairs
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int minValue = 1000;
            int maxValue = 0;
            int maxDiff = 0;
            int sum = 0;
            bool isEqual = true;
            for (int i = 0; i < input.Length; i++)
            {
                sum = Convert.ToInt32(input[i]) + Convert.ToInt32(input[i + 1]);
                i++;
                if (minValue>sum)
                {
                    minValue = sum;
                    
                }
                if (maxValue<sum)
                {
                    maxValue = sum;
                }
                maxDiff = maxValue + minValue;
            }
            if (maxDiff!=0)
            {
                isEqual = false;
            }
            Console.WriteLine(isEqual==true? "Yes, value=" + sum:"No, maxdiff=" + (maxDiff));
        }
    }

