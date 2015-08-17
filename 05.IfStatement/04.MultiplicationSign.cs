using System;

    class MultiplicationSign
    {
        static void Main()
        {
            //initialize the input data
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            // Solution without calculation values
            if (a < 0 && b > 0 && c > 0)
            {
                Console.WriteLine("-");  
            }
            else if (a > 0 && b < 0 && c > 0)
            {
                Console.WriteLine("-");  
            }
            else if (a > 0 && b > 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            else if (a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            else if (a == 0 || b == 0 || c ==0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("+");
            }
        }
    }

