using System;

    class BonusScore
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            if (a>0 && a<4)
            {
                Console.WriteLine(a*10);
            }
            else if (a>3 && a<7)
            {
                Console.WriteLine(a*100);
            }
            else if (a>6 && a<10)
            {
                Console.WriteLine(a*1000);
            }
            else
            {
                Console.WriteLine("Invalid score");
            }
            
        }
    }

