using System;

    class ExchangeVariables
    {
        static void Main()
        {
            //Declare variables
            int a = 5;
            int b = 10;
            Console.WriteLine("Before:");
            Console.WriteLine(a);
            Console.WriteLine(b);
            // Exchange the variables
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("After:");
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }

