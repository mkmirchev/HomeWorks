using System;

    class GreatestCommonDivisor
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int absA = Math.Abs(a);
            int absB = Math.Abs(b);
            while (absA != absB)
            {
                if (absA > absB)
                {
                    absA = absA - absB;
                    //Console.WriteLine("absA = " + absA);
                }
                if (absB > absA)
                {
                    absB = absB - absA;
                    //Console.WriteLine("absB = " + absB);
                }                                                                  
            }
            Console.WriteLine("Greatest Commond Divisor is : " + absA);
        }
    }

