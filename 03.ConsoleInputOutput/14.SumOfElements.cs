using System;

    class SumOfElements
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] num = input.Split(' ');
            int maxValue = 0;
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (maxValue < Convert.ToInt32(num[i]))
                {
                    maxValue = Convert.ToInt32(num[i]);
                }
                sum = sum + Convert.ToInt32(num[i]);

            }
            sum = sum - maxValue;
            if (sum == maxValue)
            {
                Console.WriteLine("Yes, sum = {0}",sum); 
            }
            else
            {
                Console.WriteLine("No, diff = {0}",Math.Abs(maxValue-sum));
            }
        }
    }

