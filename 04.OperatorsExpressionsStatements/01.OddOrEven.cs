using System;

    class OddOrEven
    {
        static void Main()
        {
            Console.Write("Enter an integer number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a % 2 != 0 ? "True" : "False");
        }
    }

