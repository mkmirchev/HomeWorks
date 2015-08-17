using System;

    class NewHouse
    {   
        // Declare some constants as a main building elements of the house
        const char asterisk = '*';
        const char dash = '-';
        const char pipe = '|';

        static void Main()
        {
            // Initialize the input data
            int n = int.Parse(Console.ReadLine());
            int center = n / 2;
            int border = 0;
            // Drawing the roof of the house
            for (int i = 0; i < center+1; i++)
            {
                Console.Write(new string(dash, n / 2 - border));
                Console.Write(new string(asterisk, 1 + 2*i));
                Console.Write(new string(dash, n / 2 - border));
                border++;
                Console.WriteLine();
            }
            // Drawing the body of the house
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(pipe,1));
                Console.Write(new string(asterisk,n-2));
                Console.Write(new string(pipe, 1));
                Console.WriteLine();
            }
        }
    }

