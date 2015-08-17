using System;

    class Rectangle
    {
        static void Main()
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = w * h;
            double perim = 2 * (w + h);
            Console.WriteLine("Area is : {0} .Perimeter is {1} .",area,perim);
        }
    }

