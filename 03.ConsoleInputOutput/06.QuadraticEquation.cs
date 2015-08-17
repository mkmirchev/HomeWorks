using System;

    class QuadraticEquation
    {
        static void Main()
        {
            // Initiaize the input data
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double dis = (b *b) - (4 * a * c);
            // Make some logic to represent the answers
            if (dis > 0)
            {
                double x1 = (-b - Math.Sqrt(dis)) / ( 2 * a );
                double x2 = (-b + Math.Sqrt(dis)) / ( 2 * a );
                Console.WriteLine("Roots are x1 = {0} and x2 = {1} .",x1,x2);
            }
            else if (dis == 0)
            {
                double x1 = -b / (2 * a);
                Console.WriteLine("Roots are x1 = x2 = {0} .",x1);
            }
            else if (dis<0)
            {
                Console.WriteLine("No real roots");
            }
        }
    }

