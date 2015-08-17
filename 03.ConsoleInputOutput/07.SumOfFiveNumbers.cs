using System;

    class SumOfFiveNumbers
    {
        static void Main()
        {   
            string str = Console.ReadLine(); 
            string[] num = str.Split(' ');
            double ans = 0;
            for (int index = 0; index < num.Length; index++)
            {
                ans += Convert.ToDouble(num[index]);
            }
            Console.WriteLine(ans);
        }
    }

