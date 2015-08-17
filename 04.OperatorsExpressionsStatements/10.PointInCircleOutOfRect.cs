using System;

    class PointInCircleOutOfRect
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double pos = Math.Sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1));
            if (x >= -0.5 && x <= 2.5 && y > 1 && y <= 2.5 && pos <=1.5) // Checking if the point is inside the circle
            {              
                    Console.WriteLine("True");                                
            }
            else
            {
                Console.WriteLine("False");
            }
            
        }
    }

