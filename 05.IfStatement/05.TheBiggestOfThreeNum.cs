using System;

    class TheBiggestOfThreeNum
    {
        static void Main()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float biggest = a;
            if (b > biggest)
            {
                biggest = b;
            }
            else if (c > biggest)
            {
                biggest = c;
            }          
            Console.WriteLine(biggest);
            
            
        }
    }

