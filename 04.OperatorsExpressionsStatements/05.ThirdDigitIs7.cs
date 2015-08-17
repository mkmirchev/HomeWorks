using System;

    class ThirdDigitIs7
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            a = a / 100;
            a = a % 10;
            if (a==7)
            {
                Console.WriteLine("True"); 
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }

