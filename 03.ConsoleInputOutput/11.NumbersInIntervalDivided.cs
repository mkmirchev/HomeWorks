using System;

    class NumbersInIntervalDivided
    {
        static void Main()
        {
            // Initialize the input data.
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int counter = 0;
            // Making for loop to check every value between start and end value.
            for (int i = start; i <= end; i++)
            {
                if (i%5==0)  // checking if value is divided by 5 with reminder 0 and counting them in the counter.
                {
                    counter++; 
                }            
            }
            // Printing the answer.
            Console.WriteLine(counter);
        }
    }

