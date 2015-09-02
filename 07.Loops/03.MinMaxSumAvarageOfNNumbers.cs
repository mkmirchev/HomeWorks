using System;

class MinMaxSumAvarageOfNNumbers
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        int min = 0;
        int max = 0;
        int sum = 0;
        double avarage = 0;

        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());
            if (i == 0)
            {
                min = input;
                max = input;
            }
            if (input > max)
            {
                max = input;
            }
            if (input < min)
            {
                min = input;
            }
            sum += input;
        }

        avarage = (sum / n);

        Console.WriteLine("Min = {0}", min);
        Console.WriteLine("Max = {0}", max);
        Console.WriteLine("Sum = {0}", sum);
        Console.WriteLine("Avarage = {0:F2}", avarage);
    }
}

