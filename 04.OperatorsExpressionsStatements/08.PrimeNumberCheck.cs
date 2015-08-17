using System;

    class PrimeNumberCheck
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            bool isPrime = a!=1&&a%2!=0&&a%3!=0 && a%5!=0 && a%7!=0||a==2||a==3||a==5||a==7;
            Console.WriteLine(isPrime);
            
        }
    }

