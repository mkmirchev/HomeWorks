using System;

    class PrintASCII
    {
        static void Main()
        {                      
            for (int i = 0; i < byte.MaxValue; i++)
            {
                Console.WriteLine("Symbol " + i + " -> " + Convert.ToChar(i));
                i++;
            }
        }
    }

