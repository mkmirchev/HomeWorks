using System;

    class CirclePandS
    {
        static void Main()
        {
           double radius = double.Parse(Console.ReadLine());
           double perimeter = 2 * radius * Math.PI;
           double area = Math.PI * radius * radius;
           Console.WriteLine("{0:F2}", perimeter);
           Console.WriteLine("{0:F2}", area);
        }
    }

