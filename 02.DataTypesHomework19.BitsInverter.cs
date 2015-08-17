using System;

class BitsInverter
{
    static void Main()
    {
        //Initializing input data
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        // Implement the logic to solve the example
        int index = 0;
        for (int i = 0; i < n; i++) 
        {
            int num = int.Parse(Console.ReadLine());
            for (int bit = 7; bit >= 0; bit--)
            {
                index++;
                if ((step == 1) || (index % step == 1))
                {
                    num = num ^ (1 << bit);
                }
            }

            //Printing Output data
            Console.WriteLine(num);
        }
    }
}
