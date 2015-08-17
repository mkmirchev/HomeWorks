using System;

    class WorkHours
    {
        static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int work = (int)Math.Floor((d*0.9m*12*p)/100);
            // Console.WriteLine(work); Prints the working hours
            if (h<=work)
            {
                Console.WriteLine("Yes");
                Console.WriteLine(((h-work)*-1));
            }
            else if (h>work)
            {
                Console.WriteLine("No");
                Console.WriteLine(((h - work) * -1));
            }
            
        }
    }

