using System;

    class LongestAreaInArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = new string[n];
            for (int i = 0; i < n; i++)
            {
                input[i] = Console.ReadLine();
            }
            int length = 0;
            string value = null;
            for (int i = 0; i < n; i++)
            {
                int counter = 0;
                for (int j = 0; j < n; j++)
                {
                    if (input[i] == input[j])
                    {
                        counter++;                       
                    }                  
                    if (length < counter)
                    {
                        length = counter;
                        value = input[i];
                    }
                }
                
            }
            Console.WriteLine(length);
            for (int index = 0; index < length; index++)
            {
                Console.WriteLine(value);
            } 
        }
    }

