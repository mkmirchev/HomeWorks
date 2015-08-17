using System;

    class JoroThePlayer
    {
        static void Main()
        {
            // Initialize the input data
            char t = char.Parse(Console.ReadLine());
            decimal p = decimal.Parse(Console.ReadLine());
            decimal h = decimal.Parse(Console.ReadLine());
            // Calculate the day's that Joro play's football
            decimal weeks = 52m - h;            
            decimal play = h + ((weeks * 2m )/ 3m) + (p * 0.5m);
            if (t == 't')
            {
                play += 3;
            }
            // Print the day's that Joro play's football
            Console.WriteLine("{0}",decimal.Floor(play)); // decimal.Floor() gives the lower value after rounding

        }
    }

