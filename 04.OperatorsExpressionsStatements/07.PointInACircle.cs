using System;

    class PointInACircle
    {
        static void Main()
        {
            //Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). Examples:
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double dist = Math.Sqrt(x * x +y * y);
            if (dist<=2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }

