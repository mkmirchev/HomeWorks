using System;

    class SortNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }
            while (counter < n/2)
            {
               for (int i = 0; i < n-1; i++)
               {
                  if (input[i] > input[i+1])
                  {
                     int sorter = input[i];
                     input[i] = input[i + 1];
                     input[i + 1] = sorter;
                  }
               }
               counter++;
            }
            
            for (int index = 0; index < n; index++)
            {
                Console.Write(input[index] + " ");
            }
        }
    }

