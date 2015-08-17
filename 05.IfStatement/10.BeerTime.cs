using System;
using System.Globalization;
    class BeerTime
    {
        static void Main()
        {   // Initialize some variables for culture info,format of the date and time value

            CultureInfo provider = CultureInfo.InvariantCulture;
            string format = "h:mm tt";
            DateTime time;
            DateTime startDrink = DateTime.Parse("1:00 PM");
            DateTime stopDrink = DateTime.Parse("3:00 AM");

            // Initialize the input hour and minutes

            string input = Console.ReadLine();
            bool result = DateTime.TryParseExact(input, format,provider, DateTimeStyles.AdjustToUniversal, out time);
            
            if (result == true)
            {
               if (time >= startDrink || time <= stopDrink)
                  {
                  Console.WriteLine("Beer time !");
                  }
            else
                  {
                  Console.WriteLine("Not a beer time! :(");
                  }  
            }
            else
            {
               Console.WriteLine("Invalid time.");
            }
           
        }
    }

