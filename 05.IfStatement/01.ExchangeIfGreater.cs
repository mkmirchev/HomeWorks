using System;

    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.WriteLine("Enter value for a : ");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for b : ");
            decimal b = decimal.Parse(Console.ReadLine());
            if (a>b)
            {
                Console.WriteLine("{0} {1}",b,a);
            }
            else
            {
                Console.WriteLine("{0} {1}", a, b);
            }
        }
    }

