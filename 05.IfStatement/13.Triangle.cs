using System;

    class Triangle
    {
        static void Main()
        {   
            //Initialize the input data
            int xa = int.Parse(Console.ReadLine());
            int ya = int.Parse(Console.ReadLine());
            int xb = int.Parse(Console.ReadLine());
            int yb = int.Parse(Console.ReadLine());
            int xc = int.Parse(Console.ReadLine());
            int yc = int.Parse(Console.ReadLine());

            //Calculating the lenght of each side
            double distanceAB = Math.Sqrt((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb));
            double distanceBC = Math.Sqrt((xb - xc) * (xb - xc) + (yb - yc) * (yb - yc));
            double distanceCA = Math.Sqrt((xc - xa) * (xc - xa) + (yc - ya) * (yc - ya));
            double p = (distanceAB + distanceBC + distanceCA) / 2;
            double area = Math.Sqrt(p * (p - distanceAB) * (p - distanceBC) * (p - distanceCA));

            //Printing the result
            if (distanceAB+distanceBC > distanceCA && distanceBC + distanceCA > distanceAB && distanceAB + distanceCA > distanceBC)
            {
                Console.WriteLine("Yes\n{0:F2}",area);
            }
            else
            {
                Console.WriteLine("No\n{0:F2}",distanceAB);
            }
        }
    }

