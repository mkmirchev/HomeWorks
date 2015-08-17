using System;

    class FourDigitNumber
    {
        static void Main()
        {
            Console.Write("Enter a four digit number abcd : ");
            int input = int.Parse(Console.ReadLine());
            int a = input / 1000;
            int b = (input / 100) % 10;
            int c = (input / 10) % 10;
            int d = input % 10;
            Console.WriteLine("The sum of the digits is : " + a + b + c + d);
            Console.WriteLine("The digits in order dcba : {0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("The digits in order dcba : {0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("The digits in order dcba : {0}{1}{2}{3}", a, c, b, d);
        }
    }

