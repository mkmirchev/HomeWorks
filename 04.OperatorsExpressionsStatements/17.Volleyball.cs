using System;

    class Volleyball
    {
        static void Main()
        {
            string yearType = Console.ReadLine();   // is year leap or normal
            int p = int.Parse(Console.ReadLine());  // holidays
            int h = int.Parse(Console.ReadLine());  // hometown
            double playTime = (p*0.666 + (48-h)*0.75 + h);          
            if (yearType == "leap")
            {
                playTime = (playTime * 1.15); 
                Console.WriteLine(Math.Floor(playTime));
            }
            else
            {
                playTime = Math.Floor(playTime);
                Console.WriteLine(playTime);
            }
        }
    }

