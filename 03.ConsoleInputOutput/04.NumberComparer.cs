using System;

    class NumberComparer
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double greater = a > b ? a : b;
            Console.WriteLine("{0}",greater);
           
        }
    }

