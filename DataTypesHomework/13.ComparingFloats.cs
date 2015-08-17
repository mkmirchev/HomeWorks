using System;

    class ComparingFloats
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = Math.Abs(a-b);
            double eps = 0.000001;
            if (c<eps)
            {
                Console.WriteLine("The difference is: {0:F8} < eps ", c);
            }
            else if (c==eps)
            {
                Console.WriteLine("Border case. The difference == eps.");
                Console.WriteLine("We consider that the two numbers are differnet.");
            }
            else
            {
                Console.WriteLine("The differnece is : {0} > eps ",c);
            }
        }
    }

