using System;

    class HalfSum
    {
        static void Main()
        {
            // Initialize the input data
            int n = int.Parse(Console.ReadLine());
            // Define some variables
            int firsthalf = 0;
            int secondhalf = 0;
            // Calculate the sum's of numbers and print the answer
            for (int a = 0; a < n; a++)
            {
                int num = int.Parse(Console.ReadLine());
                firsthalf += num;                
            }

            for (int b = 0 ; b < n; b++)
            {
                int num = int.Parse(Console.ReadLine());
                secondhalf += num;
            }

            if (firsthalf == secondhalf)
            {
                Console.WriteLine("Yes, sum=" + firsthalf); 
            }
            else 
            {
                Console.WriteLine("No, diff=" + Math.Abs(firsthalf-secondhalf));
            }
        }
    }

