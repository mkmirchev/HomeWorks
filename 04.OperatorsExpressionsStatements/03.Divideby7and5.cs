using System;

    class Divideby7and5
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            if (a % 7 == 0 && a % 5 == 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
