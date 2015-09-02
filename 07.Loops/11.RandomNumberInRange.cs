using System;

    class RandomNumberInRange
    {
        static void Main()
        {
            Console.WriteLine("Enter n , min value and max value: ");
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            if (min < max)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(rnd.Next(min,max+1) + " ");
                }
                
            }
            else
            {
                Console.WriteLine("Invalid input data. Reenter the numbers in order n , min value, max value");
                Main();
            }
                    
        }
    }

